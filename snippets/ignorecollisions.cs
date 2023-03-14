public class X {
  public static IEnumerable<Collider> GetColliders(GameObject go) {
    foreach (var collider in go.GetComponents<Collider>())
      yield return collider;
    var tr = go.transform;
    for (var i = 0; i < tr.childCount; i++) {
      foreach (var collider in GetColliders(tr.GetChild(i).gameObject))
        yield return collider;
    }
  }
}

var clonedProp = GameObject.Find("prop_avatar/prop");
var physicsColliders =
    X.GetColliders(
         GameObject.FindObjectOfType<RigManager>().physicsRig.gameObject)
        .ToArray();
foreach (var propCol in X.GetColliders(clonedProp)) {
  foreach (var physCol in physicsColliders) {
    Log($"Ignoring collisions between {propCol.name} and {physCol.name}");
    Physics.IgnoreCollision(propCol, physCol);
  }
}
