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
    public static class Props
    {
        // TODO: Do I need all this stuff?
        public const string PROP_TAG = "Prop";
        public static HashSet<string> ALLOWED_PROP_BARCODES =
            new HashSet<string>()
            {
                "SLZ.BONELAB.Content.Spawnable.MilkCrate",
                "SLZ.BONELAB.Content.Spawnable.TrafficConeToon",
            };

        private static Crate[] _allowedPropCrates;

        public static Crate[] GetAllowedPropCrates()
        {
            if (_allowedPropCrates == null)
            {
                var filter =
                    new CrateFilters.UnlockableAndNotRedactedCrateFilter().Cast<
                        ICrateFilter<Crate>
                    >();
                _allowedPropCrates = AssetWarehouseExtensions
                    .Filter(AssetWarehouse.Instance.GetCrates(), filter)
                    .ToArray()
                    .Where(
                        crate =>
                            crate.Tags.Contains(PROP_TAG)
                            && ALLOWED_PROP_BARCODES.Contains(crate.Barcode.ID)
                    )
                    .ToArray();
            }
            return _allowedPropCrates;
        }

        public static Dictionary<string, Quaternion> CustomPropRotations =
            new Dictionary<string, Quaternion>()
            {
                ["SLZ.BONELAB.Content.Spawnable.TrafficConeToon"] =
                    Quaternion.Euler(90f, 0f, 0f),
            };

        public static bool IsValidProp(GameObject prop) =>
            prop.GetComponent<Rigidbody>() != null;
    }
}
