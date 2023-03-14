
namespace PropHunt {
  public class ThirdPersonCamera {
    private static bool _hasCameraTarget = false;
    private static Vector3 _cameraTargetPos;

    [HarmonyPatch(typeof(SmoothFollower),
                  nameof(SmoothFollower.MoveCameraUpdate))]
    class SmoothFollower_MoveCameraUpdate_Patch {
      [HarmonyPrefix()]
      internal static void Prefix(SmoothFollower __instance) {
        __instance.RotationalSmoothTime = 10f;
        __instance.TranslationSmoothTime = 10f;
        if (_hasCameraTarget)
          __instance.transform.localPosition = _cameraTargetPos;
      }

      [HarmonyPostfix()]
      internal static void Postfix(SmoothFollower __instance) {
        _cameraTargetPos = __instance.transform.localPosition;
        _hasCameraTarget = true;
        __instance.transform.localPosition += // TODO: Character's height?
            __instance.transform.localRotation * Vector3.back * 3f;
      }
    }
  }
}
