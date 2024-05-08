namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Materials;

public class Material: AssetRule
{
    protected override string[] FileExtensions { get; } = ["mat"];
    protected override string[] Prefixes { get; } = ["M_", "MI_"];
    protected override string? FileType { get; } = "Material";
}