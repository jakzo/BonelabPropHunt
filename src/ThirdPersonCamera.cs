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
#if DEBUG
    // This is only active in debug builds (and when spectator camera is
    // enabled) to make seeing the prop avatar easier during development
    public class ThirdPersonCamera
    {
        public static bool _hasCameraTarget = false;
        public static Vector3 _cameraTargetPos;

        [HarmonyPatch(
            typeof(SmoothFollower),
            nameof(SmoothFollower.MoveCameraUpdate)
        )]
        class SmoothFollower_MoveCameraUpdate_Patch
        {
            [HarmonyPrefix()]
            internal static void Prefix(SmoothFollower __instance)
            {
                __instance.RotationalSmoothTime = 10f;
                __instance.TranslationSmoothTime = 10f;
                if (_hasCameraTarget)
                    __instance.transform.localPosition = _cameraTargetPos;
            }

            [HarmonyPostfix()]
            internal static void Postfix(SmoothFollower __instance)
            {
                _cameraTargetPos = __instance.transform.localPosition;
                _hasCameraTarget = true;
                __instance.transform.localPosition +=
                    __instance.transform.localRotation * Vector3.back * 3f;
            }
        }
    }
#endif
}
