using MelonLoader;
using UnityEngine;
using HarmonyLib;
using SLZ.Bonelab;
using SLZ.Rig;
using SLZ.Props;
using SLZ.VRMK;
using SLZ.Marrow.Warehouse;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BonelabPropHunt
{
    public class Mod : MelonMod
    {
        private bool _isThumbstickDown = false;

        public override void OnUpdate()
        {
            if (IsCtrlDown() && Input.GetKeyDown(KeyCode.P))
            {
                ShapeShift(
                    GameObject.Find("kitBash_medium_milkCrate_interactable [0]")
                );
            }

            if (
                _rigManager?.ControllerRig.rightController.GetThumbStick()
                ?? false
            )
            {
                if (!_isThumbstickDown)
                {
                    _isThumbstickDown = true;
                    var heldProp = new[]
                    {
                        _rigManager.physicsRig.leftHand,
                        _rigManager.physicsRig.rightHand
                    }
                        .Select(hand => hand.m_CurrentAttachedGO)
                        .Where(held => held && Props.IsValidProp(held))
                        .FirstOrDefault();
                    if (heldProp)
                        ShapeShift(heldProp);
                }
            }
            else
            {
                _isThumbstickDown = false;
            }
        }

        private bool IsCtrlDown() =>
            Input.GetKey(KeyCode.LeftControl)
            || Input.GetKey(KeyCode.RightControl);

        public void ShapeShift(GameObject prop)
        {
            MelonLogger.Msg($"Shape-shifting into: {prop.name}");
            var rigManager = GameObject.FindObjectOfType<RigManager>();
            if (!rigManager)
            {
                MelonLogger.Error("Could not find player rig to shape-shift!");
                return;
            }
            if (!Props.IsValidProp(prop))
            {
                MelonLogger.Warning("Cannot shape-shift into this prop!");
                return;
            }
            // PropAvatarPrefab.Load(prefab => PropAvatar.Switch(rigManager, prop, prefab));
            PropAvatar.Switch(rigManager, prop);
        }

        // [HarmonyPatch(
        // 	typeof(SLZ.VRMK.Avatar),
        // 	nameof(SLZ.VRMK.Avatar.RefreshBodyMeasurements),
        // 	new Type[] { }
        // )]
        // class Avatar_RefreshBodyMeasurements_Patch
        // {
        // 	[HarmonyPostfix()]
        // 	internal static void Postfix(SLZ.VRMK.Avatar __instance)
        // 	{
        // 		__instance._agility = 10f;
        // 		__instance._speed = 1.5f;
        // 		__instance._vitality = 2f;
        // 		__instance._strengthUpper = 2f;
        // 		__instance._strengthLower = 2f;
        // 		__instance._intelligence = 0f;
        // 	}
        // }

        private static RigManager _rigManager;

        [HarmonyPatch(typeof(RigManager), nameof(RigManager.Awake))]
        class RigManager_Awake_Patch
        {
            [HarmonyPostfix()]
            internal static void Postfix(RigManager __instance)
            {
                _rigManager = __instance;
            }
        }
    }
}
