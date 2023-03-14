
private SLZ.VRMK.Avatar GenerateAvatar() {
  var avatar = new SLZ.VRMK.Avatar();
  CopyFromStrongAvatar(avatar);

  // TODO
  // avatar.animator = null;
  // avatar.bodyMeshes =
  //     "UnhollowerBaseLib.Il2CppReferenceArray`1[UnityEngine.SkinnedMeshRenderer]";
  // avatar.headMeshes =
  //     "UnhollowerBaseLib.Il2CppReferenceArray`1[UnityEngine.SkinnedMeshRenderer]";
  // avatar.hairMeshes =
  //     "UnhollowerBaseLib.Il2CppReferenceArray`1[UnityEngine.SkinnedMeshRenderer]";
  // avatar.wristLf = "UnityEngine.Transform";
  // avatar.wristRt = "UnityEngine.Transform";
  // avatar.neck2 = "UnityEngine.Transform";
  // avatar.scapulaLf = "UnityEngine.Transform";
  // avatar.scapulaRt = "UnityEngine.Transform";
  // avatar.carpalLf = "UnityEngine.Transform";
  // avatar.carpalRt = "UnityEngine.Transform";
  // avatar.twistUpperArmLf = "UnityEngine.Transform
  // avatar.twistUpperArmRt = "UnityEngine.Transform
  // avatar.twistForearmLf = "UnityEngine.Transform";
  // avatar.twistForearmRt = "UnityEngine.Transform";
  // avatar.bulgeBreast = "SLZ.VRMK.Avatar+SoftBulge";
  // avatar.bulgeUpperBack = "SLZ.VRMK.Avatar+SoftBulge";
  // avatar.bulgeAbdomen = "SLZ.VRMK.Avatar+SoftBulge";
  // avatar.bulgeLowerBack = "SLZ.VRMK.Avatar+SoftBulge";
  // avatar.bulgeGroin = "SLZ.VRMK.Avatar+SoftBulge";
  // avatar.bulgeButt = "SLZ.VRMK.Avatar+SoftBulge";
  // avatar.footstepsWalk = "SLZ.Data.AudioVarianceData";
  // avatar.footstepsJog = "SLZ.Data.AudioVarianceData";
  // avatar.highFallOntoFeet = "SLZ.Data.AudioVarianceData
  // avatar.spawn = "SLZ.Data.AudioVarianceData";
  // avatar.smallPain = "SLZ.Data.AudioVarianceData";    // sample = null
  // avatar.bigPain = "SLZ.Data.AudioVarianceData";      // sample = null
  // avatar._spineZ = "UnityEngine.AnimationCurve";      // sample = null
  // avatar._ellipseZ = "UnityEngine.AnimationCurve";    // sample = null
  // avatar._ellipseNegZ = "UnityEngine.AnimationCurve"; // sample = null
  // avatar._ellipseX = "UnityEngine.AnimationCurve";    // sample = null
  // avatar._thighUpperEllipse =
  //     "SLZ.VRMK.Avatar+SoftEllipse"; // sample = Avatar+SoftEllipse
  // avatar._kneeEllipse =
  //     "SLZ.VRMK.Avatar+SoftEllipse"; // sample = Avatar+SoftEllipse
  // avatar._calfEllipse =
  //     "SLZ.VRMK.Avatar+SoftEllipse"; // sample = Avatar+SoftEllipse
  // avatar._ankleEllipse =
  //     "SLZ.VRMK.Avatar+SoftEllipse"; // sample = Avatar+SoftEllipse
  // avatar._upperarmEllipse =
  //     "SLZ.VRMK.Avatar+SoftEllipse"; // sample = Avatar+SoftEllipse
  // avatar._elbowEllipse =
  //     "SLZ.VRMK.Avatar+SoftEllipse"; // sample = Avatar+SoftEllipse
  // avatar._forearmEllipse =
  //     "SLZ.VRMK.Avatar+SoftEllipse"; // sample = Avatar+SoftEllipse
  // avatar._wristEllipse =
  //     "SLZ.VRMK.Avatar+SoftEllipse"; // sample = Avatar+SoftEllipse
  // avatar._cervicalRom = "UnityEngine.Vector4"; // sample =
  // UnityEngine.Vector4 avatar._thoracicRom = "UnityEngine.Vector4"; //
  // sample = UnityEngine.Vector4 avatar._lumbarRom = "UnityEngine.Vector4";
  // // sample = UnityEngine.Vector4 avatar._clavicularRom =
  //     "UnityEngine.Vector4"; // sample = UnityEngine.Vector4
  // avatar._skullCameraLocal =
  //     "UnityEngine.Vector3";                  // sample =
  //     UnityEngine.Vector3
  // avatar._eyeLfLocal = "UnityEngine.Vector3"; // sample =
  // UnityEngine.Vector3 avatar._eyeRtLocal = "UnityEngine.Vector3"; //
  // sample = UnityEngine.Vector3 avatar._jawLocal = "UnityEngine.Vector3";
  // // sample = UnityEngine.Vector3 avatar._cervicalHalfLocal =
  //     "UnityEngine.Vector3";                   // sample =
  //     UnityEngine.Vector3
  // avatar._t7Local = "UnityEngine.Vector3";     // sample =
  // UnityEngine.Vector3 avatar._l1Local = "UnityEngine.Vector3";     //
  // sample = UnityEngine.Vector3 avatar._l3Local = "UnityEngine.Vector3";
  // // sample = UnityEngine.Vector3 avatar._sacrumLocal =
  // "UnityEngine.Vector3";
  // // sample = UnityEngine.Vector3 avatar._scLfLocal =
  // "UnityEngine.Vector3";   // sample = UnityEngine.Vector3
  // avatar._acLfLocal = "UnityEngine.Vector3";   // sample =
  // UnityEngine.Vector3 avatar._ghLfLocal = "UnityEngine.Vector3";   //
  // sample = UnityEngine.Vector3 avatar._scRtLocal = "UnityEngine.Vector3";
  // // sample = UnityEngine.Vector3 avatar._acRtLocal =
  // "UnityEngine.Vector3";   // sample = UnityEngine.Vector3
  // avatar._ghRtLocal = "UnityEngine.Vector3";   // sample =
  // UnityEngine.Vector3 avatar._legUpperLfLocal =
  //     "UnityEngine.Vector3"; // sample = UnityEngine.Vector3
  // avatar._legUpperRtLocal =
  //     "UnityEngine.Vector3";                  // sample =
  //     UnityEngine.Vector3
  // avatar._toeLfLocal = "UnityEngine.Vector3"; // sample =
  // UnityEngine.Vector3 avatar._toeRtLocal = "UnityEngine.Vector3"; //
  // sample = UnityEngine.Vector3 avatar._palmLfLocalPerc =
  //     "UnityEngine.Vector3"; // sample = UnityEngine.Vector3
  // avatar._palmRtLocalPerc =
  //     "UnityEngine.Vector3"; // sample = UnityEngine.Vector3
  // avatar._sternumOffsetPercent =
  //     "UnityEngine.Vector3"; // sample = UnityEngine.Vector3
  // avatar._hipOffsetPercent =
  //     "UnityEngine.Vector3"; // sample = UnityEngine.Vector3
  // avatar._spineT3ToS3Percent =
  //     "UnityEngine.Vector3"; // sample = UnityEngine.Vector3
  // avatar._spineT3ToUnderbustPerc =
  //     "UnityEngine.Vector3"; // sample = UnityEngine.Vector3
  // avatar._spineUnderbustToWaistPerc =
  //     "UnityEngine.Vector3"; // sample = UnityEngine.Vector3
  // avatar._spineWaistToHighHipsPerc =
  //     "UnityEngine.Vector3"; // sample = UnityEngine.Vector3
  // avatar._spineHighHipsToS3Perc =
  //     "UnityEngine.Vector3";                // sample =
  //     UnityEngine.Vector3
  // avatar._palmSize = "UnityEngine.Vector2"; // sample =
  // UnityEngine.Vector2 avatar.artOffsets =
  //     "SLZ.VRMK.Avatar+ArtOffsets"; // sample =
  //     SLZ.VRMK.Avatar+ArtOffsets
  // avatar._nipple = "UnityEngine.Vector4"; // sample = UnityEngine.Vector4

  // Keep defaults
  // avatar.PreComputed = "True"; // sample = False
  // avatar.requiredBonesOrRefsMissing = "False"; // sample = False
  // avatar.eyeCenterOverride = "null";           // sample = null
  // avatar.twistUpperThighLf = "null";           // sample = null
  // avatar.twistUpperThighRt = "null";           // sample = null
  // avatar._headTop = "0.071";                   // sample = 0.068
  // avatar._chinY = "0.068";                     // sample = 0.068
  // avatar._underbustY = "0.3";                  // sample = 0.35
  // avatar._waistY = "0.62";                     // sample = 0.62
  // avatar._highHipY = "0.81";                   // sample = 0.81
  // avatar._crotchBottom = "0.062";              // sample = 0.04
  // avatar._headEllipseX = "0.05";               // sample = 0.044
  // avatar._jawEllipseX = "0.04";                // sample = 0.044
  // avatar._neckEllipseX = "0.04";               // sample = 0.035
  // avatar._chestEllipseX = "0.118";             // sample = 0.1
  // avatar._waistEllipseX = "0.096";             // sample = 0.091
  // avatar._highHipsEllipseX = "0.106";          // sample = 0.091
  // avatar._hipsEllipseX = "0.117";              // sample = 0.091
  // avatar._headEllipseZ = "0.074";              // sample = 0.06
  // avatar._jawEllipseZ = "0.08";                // sample = 0.06
  // avatar._neckEllipseZ = "0.052";              // sample = 0.04
  // avatar._sternumEllipseZ = "0.079";           // sample = 0.052
  // avatar._chestEllipseZ = "0.104";             // sample = 0.076
  // avatar._waistEllipseZ = "0.095";             // sample = 0.075
  // avatar._highHipsEllipseZ = "0.092";          // sample = 0.07
  // avatar._hipsEllipseZ = "0.075";              // sample = 0.07
  // avatar._headEllipseNegZ = "0.046";           // sample = 0.06
  // avatar._jawEllipseNegZ = "0.029";            // sample = 0.06
  // avatar._neckEllipseNegZ = "0.023";           // sample = 0.03
  // avatar._sternumEllipseNegZ = "0.076";        // sample = 0.052
  // avatar._chestEllipseNegZ = "0.082";          // sample = 0.07
  // avatar._waistEllipseNegZ = "0.057";          // sample = 0.06
  // avatar._highHipsEllipseNegZ = "0.082";       // sample = 0.07
  // avatar._hipsEllipseNegZ = "0.094";           // sample = 0.08
  // avatar._height = "1.826582";                        // sample = 1.75
  // avatar._eyeHeight = "1.705492";                     // sample = 1.63854
  // avatar._heightPercent = "1.071";                    // sample = 1.068
  // avatar._eyeHeightPercent = "1";                     // sample = 0.94
  // avatar._c1HeightPercent = "0.9887357";              // sample = 0.914
  // avatar._t1HeightPercent = "0.9207038";              // sample = 0.862
  // avatar._sacrumHeightPercent = "0.6159821";          // sample = 0.572
  // avatar._chestToShoulderPerc = "0.1339501";          // sample = 0.0907
  // avatar.torsoImpactSoft = "null"; // sample = null
  // avatar.torsoImpactHard = "null"; // sample = null
  // avatar.limbImpactSoft = "null";  // sample = null
  // avatar.limbImpactHard = "null";  // sample = null
  // avatar.headImpactSoft = "null";  // sample = null
  // avatar.headImpactHard = "null";  // sample = null
  // avatar.smallEffort = "null"; // sample = null
  // avatar.bigEffort = "null";   // sample = null
  // avatar.agro = "null"; // sample = null
  // avatar.unAgro = "null"; // sample = null
  // avatar.dying = "null"; // sample = null
  // avatar.dead = "null"; // sample = null
  // avatar.recovery = "null"; // sample = null
  // avatar.OnWriteTransforms = "null"; // sample = null
  // avatar.OnRefreshBodyMeasurements = "null"; // sample = null

  // Values taken from strong avatar
  // avatar._massHead = 6.306244f;
  // avatar._massChest = 25.57812f;
  // avatar._massPelvis = 17.16632f;
  // avatar._massArm = 5.673669f;
  // avatar._massLeg = 14.21116f;
  // avatar._massTotal = 88.82034f;
  // avatar._strengthUpper = 1.729254f;
  // avatar._strengthLower = 1.488679f;
  // avatar._intelligence = 1.136364f;
  // avatar._agility = 0.8850403f;
  // avatar._speed = 0.974429f;
  // avatar._vitality = 1.223636f;
  // avatar._strengthGrip = 1.453289f;
  // avatar._armLength = 0.5647894f;
  // avatar._armUpperLength = 0.2709808f;
  // avatar._armLowerLength = 0.2799333f;
  // avatar._carpalLength = 0.02775065f;
  // avatar._clavicleLength = 0.2284508f;
  // avatar._legUpperLength = 0.394875f;
  // avatar._legLowerLength = 0.3962594f;
  // avatar._footLength = 0.1701111f;
  // avatar._armPercent = 0.3311592f;
  // avatar._shoulderToPalmPercent = 0.3623613f;
  // avatar._palmOffsetLength = 0.01803279f;
  // avatar._skullHeight = 1.686281f;
  // avatar._chestHeight = 1.570253f;
  // avatar._pelvisHeight = 1.050553f;
  // avatar._armUpperPercent = 0.1588871f;
  // avatar._armLowerPercent = 0.1641364f;
  // avatar._legUpperPercent = 0.2315314f;
  // avatar._legLowerPercent = 0.2323431f;
  // avatar._carpalPercent = 0.01627134f;
  // avatar._toeHeightPercent = 0.01425506f;
  // avatar._tippyToeExt = 0.1001139f;
  // avatar._handSizeMult = 1.169573f;
  // avatar._t7OffsetZ = -0.01995833f;
  // avatar._l1OffsetZ = -0.01162391f;
  // avatar._l3OffsetZ = 0.01298063f;
  // avatar._t7Y = 0.05014686f;
  // avatar._l1Y = 0.3571989f;
  // avatar._l3Y = 0.6079374f;
  // avatar._hasUpperChest = true;

  return avatar;
}
