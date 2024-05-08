namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming;

public class AssetMesh: AssetRule
{
    protected override string[] FileExtensions { get; } = ["obj", "glb", "fbx"];
    protected override string[] Prefixes { get; } = ["CH_", "VH_", "VP_", "SM_", "SK_", "SKEL_", "RIG_"];

    protected override string? FileType { get; } = "Mesh";

    public override string GetInternalName()
    {
        return base.GetInternalName() + "mesh";
    }
}