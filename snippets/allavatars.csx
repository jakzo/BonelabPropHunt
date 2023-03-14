
var avatarCrates = AssetWarehouse.Instance.GetCrates()
                       .ToArray()
                       .Where(crate => crate.Tags.Contains("Avatar"))
                       .ToArray();
foreach (var crate in avatarCrates)
  Log($"{crate.Title} = {crate.Barcode.ID}");

/*
Peasant Female A = SLZ.BONELAB.Core.Avatar.PeasantFemaleA
PolyBlank = c3534c5a-94b2-40a4-912a-24a8506f6c79
*/

AssetWarehouse.Instance.GetCrate(
    new Barcode("c3534c5a-94b2-40a4-912a-24a8506f6c79"));
