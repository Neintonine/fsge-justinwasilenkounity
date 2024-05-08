namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Animations;

public sealed class AvatarMask: AssetRule
{
    protected override string[] FileExtensions { get; } = ["mask"];
    protected override string[] Prefixes { get; } = ["AM_"];
    protected override string? FileType { get; } = "Avatar Mask";
}