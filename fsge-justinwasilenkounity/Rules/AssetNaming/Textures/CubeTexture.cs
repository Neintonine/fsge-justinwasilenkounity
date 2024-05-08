namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Textures;

public sealed class CubeTexture: AssetRule
{
    protected override string[] FileExtensions { get; } = ["cubemap"];
    protected override string[] Prefixes { get; } = ["TC_"];
    protected override string? FileType { get; } = "Cube Texture";
}