
public static void InitAvatar(SLZ.VRMK.Avatar avatar, SLZ.VRMK.Avatar polyblankAvatar = null) {
    if (!polyblankAvatar)
      polyblankAvatar = _polyblankAvatar;

    // Serialized (automatically copied from polyblank)
    // avatar.animator = avatar.GetComponent<Animator>();
    // avatar.neck2 = polyblankAvatar.neck2;
    // avatar.scapulaRt = polyblankAvatar.scapulaRt;
    // avatar.carpalRt = polyblankAvatar.carpalRt;
    // avatar.twistUpperArmRt = polyblankAvatar.twistUpperArmRt;
    // avatar.twistForearmRt = polyblankAvatar.twistForearmRt;
    // avatar.eyeCenterOverride = polyblankAvatar.eyeCenterOverride;
    // avatar.twistUpperThighLf = polyblankAvatar.twistUpperThighLf;
    // avatar.twistUpperThighRt = polyblankAvatar.twistUpperThighRt;
    // avatar._headTop = polyblankAvatar._headTop;
    // avatar._chinY = polyblankAvatar._chinY;
    // avatar._underbustY = polyblankAvatar._underbustY;
    // avatar._waistY = polyblankAvatar._waistY;
    // avatar._highHipY = polyblankAvatar._highHipY;
    // avatar._crotchBottom = polyblankAvatar._crotchBottom;
    // avatar._headEllipseX = polyblankAvatar._headEllipseX;
    // avatar._jawEllipseX = polyblankAvatar._jawEllipseX;
    // avatar._neckEllipseX = polyblankAvatar._neckEllipseX;
    // avatar._chestEllipseX = polyblankAvatar._chestEllipseX;
    // avatar._waistEllipseX = polyblankAvatar._waistEllipseX;
    // avatar._highHipsEllipseX = polyblankAvatar._highHipsEllipseX;
    // avatar._hipsEllipseX = polyblankAvatar._hipsEllipseX;
    // avatar._headEllipseZ = polyblankAvatar._headEllipseZ;
    // avatar._jawEllipseZ = polyblankAvatar._jawEllipseZ;
    // avatar._neckEllipseZ = polyblankAvatar._neckEllipseZ;
    // avatar._sternumEllipseZ = polyblankAvatar._sternumEllipseZ;
    // avatar._chestEllipseZ = polyblankAvatar._chestEllipseZ;
    // avatar._waistEllipseZ = polyblankAvatar._waistEllipseZ;
    // avatar._highHipsEllipseZ = polyblankAvatar._highHipsEllipseZ;
    // avatar._hipsEllipseZ = polyblankAvatar._hipsEllipseZ;
    // avatar._headEllipseNegZ = polyblankAvatar._headEllipseNegZ;
    // avatar._jawEllipseNegZ = polyblankAvatar._jawEllipseNegZ;
    // avatar._neckEllipseNegZ = polyblankAvatar._neckEllipseNegZ;
    // avatar._sternumEllipseNegZ = polyblankAvatar._sternumEllipseNegZ;
    // avatar._chestEllipseNegZ = polyblankAvatar._chestEllipseNegZ;
    // avatar._waistEllipseNegZ = polyblankAvatar._waistEllipseNegZ;
    // avatar._highHipsEllipseNegZ = polyblankAvatar._highHipsEllipseNegZ;
    // avatar._hipsEllipseNegZ = polyblankAvatar._hipsEllipseNegZ;
    // avatar._thighUpperEllipse = polyblankAvatar._thighUpperEllipse;
    // avatar._kneeEllipse = polyblankAvatar._kneeEllipse;
    // avatar._calfEllipse = polyblankAvatar._calfEllipse;
    // avatar._ankleEllipse = polyblankAvatar._ankleEllipse;
    // avatar._upperarmEllipse = polyblankAvatar._upperarmEllipse;
    // avatar._elbowEllipse = polyblankAvatar._elbowEllipse;
    // avatar._forearmEllipse = polyblankAvatar._forearmEllipse;
    // avatar._wristEllipse = polyblankAvatar._wristEllipse;

    // Safe to leave empty
    // avatar.bodyMeshes = polyblankAvatar.bodyMeshes;
    // avatar.headMeshes = polyblankAvatar.headMeshes;
    // avatar.hairMeshes = polyblankAvatar.hairMeshes;
    // avatar.bulgeUpperBack = polyblankAvatar.bulgeUpperBack;
    // avatar.bulgeLowerBack = polyblankAvatar.bulgeLowerBack;
    // avatar.bulgeButt = polyblankAvatar.bulgeButt;

    // Copy from polyblank
    // TODO: Go through this list and see if we really need to copy these
    avatar.PreComputed = polyblankAvatar.PreComputed;
    avatar.requiredBonesOrRefsMissing = polyblankAvatar.requiredBonesOrRefsMissing;
    avatar._eyeHeight = polyblankAvatar._eyeHeight;
    avatar.torsoImpactSoft = polyblankAvatar.torsoImpactSoft;
    avatar.torsoImpactHard = polyblankAvatar.torsoImpactHard;
    avatar.limbImpactSoft = polyblankAvatar.limbImpactSoft;
    avatar.limbImpactHard = polyblankAvatar.limbImpactHard;
    avatar.headImpactSoft = polyblankAvatar.headImpactSoft;
    avatar.headImpactHard = polyblankAvatar.headImpactHard;
    avatar.smallEffort = polyblankAvatar.smallEffort;
    avatar.bigEffort = polyblankAvatar.bigEffort;
    avatar.agro = polyblankAvatar.agro;
    avatar.unAgro = polyblankAvatar.unAgro;
    avatar.dying = polyblankAvatar.dying;
    avatar.dead = polyblankAvatar.dead;
    avatar.recovery = polyblankAvatar.recovery;
    avatar.OnWriteTransforms = polyblankAvatar.OnWriteTransforms;
    avatar._massHead = polyblankAvatar._massHead;
    avatar._massChest = polyblankAvatar._massChest;
    avatar._armLength = polyblankAvatar._armLength;
    avatar._armUpperLength = polyblankAvatar._armUpperLength;
    avatar._armUpperPercent = polyblankAvatar._armUpperPercent;
    avatar._l3OffsetZ = polyblankAvatar._l3OffsetZ;
    avatar._t7Y = polyblankAvatar._t7Y;
    avatar._l1Y = polyblankAvatar._l1Y;
    avatar._l3Y = polyblankAvatar._l3Y;
    avatar._hasUpperChest = polyblankAvatar._hasUpperChest;
    avatar._ellipseZ = polyblankAvatar._ellipseZ;
    avatar._ellipseX = polyblankAvatar._ellipseX;
    avatar._lumbarRom = polyblankAvatar._lumbarRom;
    avatar._clavicularRom = polyblankAvatar._clavicularRom;
    avatar._sternumOffsetPercent = polyblankAvatar._sternumOffsetPercent;
    avatar._spineT3ToUnderbustPerc = polyblankAvatar._spineT3ToUnderbustPerc;
    avatar._spineUnderbustToWaistPerc = polyblankAvatar._spineUnderbustToWaistPerc;
    avatar._spineWaistToHighHipsPerc = polyblankAvatar._spineWaistToHighHipsPerc;
    avatar._nipple = polyblankAvatar._nipple;

    // === PrecomputeAvatar() sets these
    // avatar._eyeLfLocal = polyblankAvatar._eyeLfLocal;
    // avatar._eyeRtLocal = polyblankAvatar._eyeRtLocal;
    // avatar._jawLocal = polyblankAvatar._jawLocal;
    // avatar._eyeHeightPercent = polyblankAvatar._eyeHeightPercent;
    // avatar._skullCameraLocal = polyblankAvatar._skullCameraLocal;
    // avatar._cervicalHalfLocal = polyblankAvatar._cervicalHalfLocal;
    // avatar._t7Local = polyblankAvatar._t7Local;
    // avatar._palmSize = polyblankAvatar._palmSize;
    // avatar._l1Local = polyblankAvatar._l1Local;
    // avatar._l3Local = polyblankAvatar._l3Local;
    // avatar._sacrumLocal = polyblankAvatar._sacrumLocal;
    // avatar._scLfLocal = polyblankAvatar._scLfLocal;
    // avatar._legUpperLfLocal = polyblankAvatar._legUpperLfLocal;
    // avatar._legUpperRtLocal = polyblankAvatar._legUpperRtLocal;
    // avatar._toeLfLocal = polyblankAvatar._toeLfLocal;
    // avatar._c1HeightPercent = polyblankAvatar._c1HeightPercent;
    // avatar._t1HeightPercent = polyblankAvatar._t1HeightPercent;
    // avatar._sacrumHeightPercent = polyblankAvatar._sacrumHeightPercent;
    // avatar._chestToShoulderPerc = polyblankAvatar._chestToShoulderPerc;
    // avatar._cervicalRom = polyblankAvatar._cervicalRom;
    // avatar._acLfLocal = polyblankAvatar._acLfLocal;
    // avatar._ghLfLocal = polyblankAvatar._ghLfLocal;
    // avatar._scRtLocal = polyblankAvatar._scRtLocal;
    // avatar._acRtLocal = polyblankAvatar._acRtLocal;
    // avatar._ghRtLocal = polyblankAvatar._ghRtLocal;
    // avatar._carpalPercent = polyblankAvatar._carpalPercent;
    // avatar._toeHeightPercent = polyblankAvatar._toeHeightPercent;
    // avatar._legUpperPercent = polyblankAvatar._legUpperPercent;
    // avatar._legLowerPercent = polyblankAvatar._legLowerPercent;
    // avatar._tippyToeExt = polyblankAvatar._tippyToeExt;
    // avatar._toeRtLocal = polyblankAvatar._toeRtLocal;
    // avatar._palmLfLocalPerc = polyblankAvatar._palmLfLocalPerc;
    // avatar._handSizeMult = polyblankAvatar._handSizeMult;
    // avatar._t7OffsetZ = polyblankAvatar._t7OffsetZ;
    // avatar._hipOffsetPercent = polyblankAvatar._hipOffsetPercent;
    // avatar._spineT3ToS3Percent = polyblankAvatar._spineT3ToS3Percent;
    // avatar._spineHighHipsToS3Perc = polyblankAvatar._spineHighHipsToS3Perc;
    // avatar._armLowerPercent = polyblankAvatar._armLowerPercent;
    // avatar._t7Y = polyblankAvatar._t7Y;
    // avatar.artOffsets = polyblankAvatar.artOffsets;
    // avatar._palmRtLocalPerc = polyblankAvatar._palmRtLocalPerc;
    // avatar._chestHeight = polyblankAvatar._chestHeight;
    // avatar._handSchematicLf_k__BackingField = polyblankAvatar._handSchematicLf_k__BackingField;
    // avatar._l1OffsetZ = polyblankAvatar._l1OffsetZ;
    // avatar._handSchematicRt_k__BackingField = polyblankAvatar._handSchematicRt_k__BackingField;
    // avatar.wristLf = polyblankAvatar.wristLf;

    // === RefreshBodyMeasurements() sets these
    // avatar._heightPercent = polyblankAvatar._heightPercent;
    // avatar._pelvisHeight = polyblankAvatar._pelvisHeight;
    // avatar._spineZ = polyblankAvatar._spineZ;
    // avatar._legLowerLength = polyblankAvatar._legLowerLength;
    // avatar._footLength = polyblankAvatar._footLength;
    // avatar._carpalLength = polyblankAvatar._carpalLength;
    // avatar._clavicleLength = polyblankAvatar._clavicleLength;
    // avatar._armPercent = polyblankAvatar._armPercent;
    // avatar._shoulderToPalmPercent = polyblankAvatar._shoulderToPalmPercent;
    // avatar._legUpperLength = polyblankAvatar._legUpperLength;
    // avatar._palmOffsetLength = polyblankAvatar._palmOffsetLength;
    // avatar._skullHeight = polyblankAvatar._skullHeight;
    // avatar._armLowerLength = polyblankAvatar._armLowerLength;
    // avatar._height = polyblankAvatar._height;

    // Functions below are called by RefreshBodyMeasurements
    // --- ComputeMass() sets these
    // avatar._massLeg = polyblankAvatar._massLeg;
    // avatar._massArm = polyblankAvatar._massArm;
    // avatar._massPelvis = polyblankAvatar._massPelvis;
    // avatar._massTotal = polyblankAvatar._massTotal;
    // avatar._strengthLower = polyblankAvatar._strengthLower;
    // avatar._strengthUpper = polyblankAvatar._strengthUpper;

    // --- ComputeBaseStats() sets these
    // avatar._intelligence = polyblankAvatar._intelligence;
    // avatar._agility = polyblankAvatar._agility;
    // avatar._speed = polyblankAvatar._speed;
    // avatar._vitality = polyblankAvatar._vitality;
    // avatar._strengthGrip = polyblankAvatar._strengthGrip;
    // avatar.footstepsWalk = polyblankAvatar.footstepsWalk;

    // Called at the end of RefreshBodyMeasurements()
    avatar.OnRefreshBodyMeasurements = new Action(() => UpdateStats(avatar));
}
