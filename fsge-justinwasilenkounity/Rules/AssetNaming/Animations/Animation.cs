namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Animations;

public sealed class Animation: AssetRule
{
    protected override string[] FileExtensions { get; } = ["anim"];
    protected override string[] Prefixes { get; } = ["A_"];

    protected override string? FileType { get; } = "Animation";
}