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

namespace BonelabPropHunt
{
	public static class PropAvatarPrefab
	{
		// The current approach is to switch to the rig manager's calibration
		// avatar (which is PolyBlank, but not the same instance as the one
		// loaded from the PolyBlank crate) then modify it into the prop avatar.
		// I tried building a prefab by instantiating it but couldn't get it to
		// work properly (super broken, torso falls to floor, can't run unless
		// crouching, see first commit for code) so I'm modifying the
		// calibration avatar in the hopes that it resets between levels and
		// can't normally be switched to. If possible it would be ideal to have
		// a "prop avatar" crate with this prefab in future.
		public static PropAvatar Setup(SLZ.VRMK.Avatar polyblankAvatar)
		{
			polyblankAvatar.name = "prop_avatar";

			var propAvatar = polyblankAvatar.gameObject.AddComponent<PropAvatar>();
			propAvatar.Avatar = polyblankAvatar;
			InitAvatar(propAvatar.Avatar);

			// TODO: Disabled for testing
			// HideLegsAndTorsoRings(polyblankAvatar.animator);

			return propAvatar;
		}

		private static void HideLegsAndTorsoRings(Animator animator)
		{
			foreach (
				var bone in new[] { HumanBodyBones.LeftUpperLeg, HumanBodyBones.RightUpperLeg }
			)
			{
				animator.GetBoneTransform(bone).localScale = Vector3.zero;
			}

			animator.transform.Find("SHJntGrp/MAINSHJnt/ROOTSHJnt/HipToSternumPointer").localScale =
				Vector3.zero;
		}

		private static void InitAvatar(SLZ.VRMK.Avatar avatar)
		{
			// TODO: Modify height, stats, etc.
			UpdateStats(avatar);
			avatar.OnRefreshBodyMeasurements = new Action(() => UpdateStats(avatar));
		}

		private static void UpdateStats(SLZ.VRMK.Avatar avatar)
		{
			// var propAvatar = avatar.GetComponent<PropAvatar>();
			// avatar._intelligence = polyblankAvatar._intelligence;
			avatar._agility = 10f;
			avatar._speed = 10f;
			// avatar._vitality = polyblankAvatar._vitality;
			// avatar._strengthGrip = polyblankAvatar._strengthGrip;
		}
	}
}
