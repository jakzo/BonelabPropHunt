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

namespace Sst.PropHunt {
[RegisterTypeInIl2Cpp]
public class PropAvatar : MonoBehaviour {
  // TODO: Switch to then modify the actual polyblank (create my own prop avatar
  // crate in future)
  public static void Switch(RigManager rigManager, GameObject prop,
                            GameObject polyblankPrefab) {
    var propAvatar = rigManager.avatar?.GetComponent<PropAvatar>();
    if (!propAvatar) {
      if (!prefab)
        prefab = PropAvatarPrefab.Load(rigManager);
      var tr = rigManager.transform;
      var avatarGo =
          GameObject.Instantiate(prefab, tr.position, tr.rotation, tr);
      propAvatar = avatarGo.GetComponent<PropAvatar>();

      // We can't serialize this field in the prefab so have to set it here
      propAvatar.Avatar = avatarGo.GetComponent<SLZ.VRMK.Avatar>();

      propAvatar.RigManager = rigManager;
      rigManager.SwitchAvatar(propAvatar.Avatar);
      SetBeltAndHolstersVisible(rigManager, false);
      MelonCoroutines.Start(
          SetRigCollisionExceptHeadHandsFeet(rigManager, false));
      // TODO: Disabled for testing
      // rigManager.bodyVitals.hasBodyLog = false;
    }

    propAvatar.SetProp(prop);
  }

  public static void ResetRig(RigManager rigManager) {
    SetBeltAndHolstersVisible(rigManager, true);
    SetRigCollisionExceptHeadHandsFeet(rigManager, true);
    // TODO: Get proper value from save
    rigManager.bodyVitals.hasBodyLog = true;
  }

  public static void SetBeltAndHolstersVisible(RigManager rigManager,
                                               bool isVisible) {
    Utils.ForEachChild(rigManager.physicsRig.m_pelvis,
                       child => child.active = isVisible);
    Utils.ForEachChild(rigManager.physicsRig.m_spine,
                       child => child.active = isVisible);
  }

  public static IEnumerator
  SetRigCollisionExceptHeadHandsFeet(RigManager rigManager, bool isEnabled) {
    var physicsRig = rigManager.physicsRig;
    var colliderTransforms = new Transform[] {
      physicsRig.m_chest,  physicsRig.m_elbowLf,    physicsRig.m_elbowRt,
      physicsRig.m_footLf, physicsRig.m_footRt,     physicsRig.m_hipLf,
      physicsRig.m_hipRt,  physicsRig.m_kneeLf,     physicsRig.m_kneeRt,
      physicsRig.m_pelvis, physicsRig.m_shoulderLf, physicsRig.m_shoulderRt,
      physicsRig.m_spine,
    };
    foreach (var transform in colliderTransforms) {
      for (var i = 0; i < 50; i++)
        yield return null;
      Dbg.Log($"disabling collision for: {transform.name}");
      transform.GetComponent<Rigidbody>().detectCollisions = isEnabled;
    }
  }

  public RigManager RigManager;
  public SLZ.VRMK.Avatar Avatar;
  public GameObject Prop;
  public ConfigurableJoint Joint;

  public PropAvatar(IntPtr ptr) : base(ptr) {}

  public void SetProp(GameObject prop) {
    if (Prop) {
      Destroy(Prop);
      Prop = null;
      Joint = null;
    }

    Prop = GameObject.Instantiate(prop, transform.position, transform.rotation,
                                  transform);
    AddJointFromPropToBody();
    DisableCollisionsOfPropWithPlayer();

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

    PropAvatarPrefab.InitAvatar(Avatar);
    CalculateAvatarStats();
    // RigManager.bodyVitals.PROPEGATE_SOFT();
  }

  private void AddJointFromPropToBody() {
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
    Joint.linearLimit = new SoftJointLimit() {
      limit = 0.01f,
    };
    Joint.linearLimitSpring = new SoftJointLimitSpring() {
      spring = 1000f,
    };
    Joint.angularXMotion = Joint.angularYMotion = Joint.angularZMotion =
        ConfigurableJointMotion.Limited;
    Joint.highAngularXLimit = Joint.angularYLimit = Joint.angularZLimit =
        new SoftJointLimit() {
          limit = 45f,
        };
    Joint.lowAngularXLimit = new SoftJointLimit() {
      limit = -45f,
    };
    Joint.angularXDrive = Joint.angularYZDrive = new JointDrive() {
      positionSpring = 10f,
      positionDamper = 1f,
    };
  }

  private void DisableCollisionsOfPropWithPlayer() {
    var feetLayer = LayerMask.NameToLayer("Feet");
    foreach (var propCol in Utils.GetNestedComponents<Collider>(Prop)) {
      if (!propCol.attachedRigidbody)
        continue;
      propCol.gameObject.layer = feetLayer;
    }
  }

  private void DisablePropDestruction() {
    var destructable = Prop.GetComponent<ObjectDestructable>();
    if (destructable)
      destructable.enabled = false;
  }

  private void CalculateAvatarStats() {
    // PrecomputeAvatar();
    // RefreshBodyMeasurements();
    // TODO: Do we need a hook on RefreshBodyMeasurements?
    // _speed = 5f;
    // _agility = 2f;
    // TODO
  }
}
}
