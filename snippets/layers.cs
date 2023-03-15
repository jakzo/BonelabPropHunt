
var layer = LayerMask.NameToLayer("Feet");
Log($"layer = {layer}");
for (var i = 0; i < 32; i++) {
  Log($"{i} = {LayerMask.LayerToName(i)} = {Physics.GetIgnoreLayerCollision(layer, i)}");
}
