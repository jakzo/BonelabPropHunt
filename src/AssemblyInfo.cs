using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly:AssemblyTitle(PropHunt.BuildInfo.NAME)]
[assembly:AssemblyDescription(PropHunt.BuildInfo.DESCRIPTION)]
[assembly:AssemblyConfiguration("")]
[assembly:AssemblyCompany(PropHunt.BuildInfo.COMPANY)]
[assembly:AssemblyProduct(PropHunt.BuildInfo.NAME)]
[assembly:AssemblyCopyright("Created by " + PropHunt.BuildInfo.AUTHOR)]
[assembly:AssemblyTrademark(PropHunt.BuildInfo.COMPANY)]
[assembly:AssemblyCulture("")]
[assembly:ComVisible(false)]
[assembly:AssemblyVersion(PropHunt.AppVersion.Value)]
[assembly:AssemblyFileVersion(PropHunt.AppVersion.Value)]
[assembly:NeutralResourcesLanguage("en")]
[assembly:MelonInfo(
    typeof(PropHunt.Mod), PropHunt.BuildInfo.NAME,
    PropHunt.AppVersion.Value, PropHunt.BuildInfo.AUTHOR,
    "https://bonelab.thunderstore.io/package/jakzo/PropHunt/")]
[assembly:MelonGame(PropHunt.BuildInfo.DEVELOPER, PropHunt.BuildInfo.GAME)]

namespace PropHunt {
public static class BuildInfo {
  public const string NAME = "PropHunt";
  public const string DESCRIPTION = "Hide and seek while disguised as random items.";
  public const string AUTHOR = "jakzo";
  public const string COMPANY = null;
  public const string DEVELOPER = "Stress Level Zero";
  public const string GAME = "BONELAB";
}
}
