namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Rendering;

public sealed class HdrpAsset: RenderingAsset
{
    protected override string ScriptLine { get; } =
        "m_Script: {fileID: 11500000, guid: 0cf1dab834d4ec34195b920ea7bbf9ec, type: 3}";
    
    protected override string[] Prefixes { get; } = ["HDRP_"];
    
    protected override string? FileType { get; } = "HDRP Asset";
}