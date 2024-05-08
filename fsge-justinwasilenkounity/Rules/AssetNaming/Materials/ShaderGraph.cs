﻿namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Materials;

public sealed class ShaderGraph: AssetRule
{
    protected override string[] FileExtensions { get; } = ["shadergraph"];
    protected override string[] Prefixes { get; } = ["MSG_"];
    
    protected override string? FileType { get; } = "Material Shader Graph";
}