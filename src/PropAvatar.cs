using MelonLoader;
using UnityEngine;
using HarmonyLib;
using SLZ.Bonelab;
using SLZ.Rig;
using SLZ.Props;
using SLZ.VRMK;
using SLZ.Marrow.Warehouse;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using SLZ.SaveData;

namespace BonelabPropHunt
{
	[RegisterTypeInIl2Cpp]
	public class PropAvatar : MonoBehaviour
	{
		public static void Switch(RigManager rigManager, GameObject prop)
		{
			var propAvatar = rigManager.avatar?.GetComponent<PropAvatar>();
			if (!propAvatar)
			{
				propAvatar =
					rigManager.CalibrationAvatar.GetComponent<PropAvatar>()
					?? PropAvatarPrefab.Setup(rigManager.CalibrationAvatar);
				rigManager.SwitchAvatar(rigManager.CalibrationAvatar);
				rigManager.AvatarCrate = new AvatarCrateReference(
					rigManager.calibrationAvatarBarcode
				);
				propAvatar.RigManager = rigManager;
				SetBeltAndHolstersVisible(rigManager, false);
				SetRigCollisionExceptHeadHandsFeet(rigManager, false);
				// TODO: Disabled for testing
				// rigManager.bodyVitals.hasBodyLog = false;
			}
			propAvatar.SetProp(prop);
		}

		public static void ResetRig(RigManager rigManager)
		{
			SetBeltAndHolstersVisible(rigManager, true);
			SetRigCollisionExceptHeadHandsFeet(rigManager, true);
			rigManager.bodyVitals.hasBodyLog =
				DataManager.ActiveSave?.Progression.HasBodyLog ?? false;
		}

		[HarmonyPatch(typeof(RigManager), nameof(RigManager.SwitchAvatar))]
		class RigManager_SwitchAvatar_Patch
		{
			[HarmonyPrefix()]
			internal static void Prefix(RigManager __instance)
			{
				if (__instance.avatar == __instance.CalibrationAvatar)
					ResetRig(__instance);
			}
		}

		public static void SetBeltAndHolstersVisible(RigManager rigManager, bool isVisible)
		{
			foreach (
				var transform in new[]
				{
					rigManager.physicsRig.m_pelvis,
					rigManager.physicsRig.m_spine
				}
			)
				Utils.ForEachChild(transform, child => child.active = isVisible);
		}

		public static void SetRigCollisionExceptHeadHandsFeet(RigManager rigManager, bool isEnabled)
		{
			var physicsRig = rigManager.physicsRig;
			var colliderTransforms = new Transform[]
			{
				physicsRig.m_chest,
				physicsRig.m_elbowLf,
				physicsRig.m_elbowRt,
				physicsRig.m_footLf,
				physicsRig.m_footRt,
				physicsRig.m_hipLf,
				physicsRig.m_hipRt,
				physicsRig.m_kneeLf,
				physicsRig.m_kneeRt,
				physicsRig.m_pelvis,
				physicsRig.m_shoulderLf,
				physicsRig.m_shoulderRt,
				physicsRig.m_spine,
			};
			foreach (var transform in colliderTransforms)
			{
				transform.GetComponent<Rigidbody>().detectCollisions = isEnabled;
			}
		}

		public RigManager RigManager;
		public SLZ.VRMK.Avatar Avatar;
		public GameObject Prop;
		public ConfigurableJoint Joint;

		public PropAvatar(IntPtr ptr)
			: base(ptr) { }

		public void SetProp(GameObject prop)
		{
			if (Prop)
			{
				Destroy(Prop);
				Prop = null;
			}
			if (Joint)
			{
				Destroy(Joint);
				Joint = null;
			}

			Prop = GameObject.Instantiate(prop, transform.position, transform.rotation, transform);
			AddJointFromPropToBody();
			DisableCollisionsBetweenPropAndPlayer();

			// TODO: Create mesh collider around prop with minimum dimensions and have
			// it only collide with non-kinematic colliders (to stop props falling
			// through the ground, etc.)

			DisablePropDestruction();

			// TODO: Can we rotate the game object instead of this?
			// if ((_pci - 1) % _propCrates.Length == 1) {
			//   joint.highAngularXLimit = new SoftJointLimit() {
			//     limit = 135f,
			//   };
			//   joint.lowAngularXLimit = new SoftJointLimit() {
			//     limit = 45f,
			//   };
			//   joint.connectedAnchor = new Vector3(0f, -0.07f, 0f);
			// }

			CalculateAvatarStats();
			// RigManager.bodyVitals.PROPEGATE_SOFT();
		}

		private void AddJointFromPropToBody()
		{
			if (!Joint)
				Joint = Prop.AddComponent<ConfigurableJoint>();
			Joint.connectedBody = RigManager.physicsRig.rbKnee;
			Joint.autoConfigureConnectedAnchor = false;
			// TODO: Set this based on prop bounding box and rig
			// Anchored 1cm above the feet on a spring to help it bounce up steps
			// propAvatar.Joint.connectedAnchor = new Vector3(
			//     0f, Joint.connectedBody.transform.localPosition.y +
			//     0.815f, 0f);
			Joint.connectedAnchor = new Vector3(0f, -0.04f, 0f);
			Joint.xMotion = Joint.zMotion = ConfigurableJointMotion.Locked;
			Joint.yMotion = ConfigurableJointMotion.Limited;
			Joint.linearLimit = new SoftJointLimit() { limit = 0.01f, };
			Joint.linearLimitSpring = new SoftJointLimitSpring() { spring = 1000f, };
			Joint.angularXMotion =
				Joint.angularYMotion =
				Joint.angularZMotion =
					ConfigurableJointMotion.Limited;
			Joint.highAngularXLimit =
				Joint.angularYLimit =
				Joint.angularZLimit =
					new SoftJointLimit() { limit = 45f, };
			Joint.lowAngularXLimit = new SoftJointLimit() { limit = -45f, };
			Joint.angularXDrive = Joint.angularYZDrive = new JointDrive()
			{
				positionSpring = 10f,
				positionDamper = 1f,
			};
		}

		private void DisableCollisionsBetweenPropAndPlayer()
		{
			var feetLayer = LayerMask.NameToLayer("Feet");
			foreach (var propCol in Utils.GetNestedComponents<Collider>(Prop))
			{
				if (!propCol.attachedRigidbody)
					continue;
				propCol.gameObject.layer = feetLayer;
			}
		}

		private void DisablePropDestruction()
		{
			var destructable = Prop.GetComponent<ObjectDestructable>();
			if (destructable)
				destructable.enabled = false;
		}

		private void CalculateAvatarStats()
		{
			// PrecomputeAvatar();
			// RefreshBodyMeasurements();
			// TODO: Do we need a hook on RefreshBodyMeasurements?
			// _speed = 5f;
			// _agility = 2f;
			// TODO
		}
	}
}
