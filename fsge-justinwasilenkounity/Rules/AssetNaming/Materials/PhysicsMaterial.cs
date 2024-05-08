namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Materials;

public sealed class PhysicsMaterial: AssetRule
{
    protected override string[] FileExtensions { get; } = ["physicMaterial"];
    protected override string[] Prefixes { get; } = ["PM_"];
    
    protected override string? FileType { get; } = "Physics Material";
}