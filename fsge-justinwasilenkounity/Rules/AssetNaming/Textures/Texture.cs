namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Textures;

public class AssetTexture : AssetRule
{
    protected override string[] FileExtensions { get; } = ["png", "jpg", "jpeg", "bmp", "exr"];
    protected override string[] Prefixes { get; } = ["T"];
    
    protected override string? FileType { get; } = "Texture";
}