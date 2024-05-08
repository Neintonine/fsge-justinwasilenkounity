namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Audio;

public sealed class AudioClip : AssetRule
{
    protected override string[] FileExtensions { get; } = ["wav", "flac", "mp3"];
    protected override string[] Prefixes { get; } = ["A_"];
    
    protected override string? FileType { get; } = "Audio Clip";
}