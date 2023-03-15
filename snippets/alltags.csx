
var tags = AssetWarehouse.Instance.GetCrates()
               .ToArray()
               .SelectMany(crate => crate.Tags.ToArray())
               .ToHashSet();
foreach (var tag in tags)
  Log(tag);
