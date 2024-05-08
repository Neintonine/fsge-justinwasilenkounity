﻿using FSGE.Framework.Rules;

namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Textures;

public sealed class RenderTexture: AssetRule
{
    protected override string[] FileExtensions { get; } = ["asset", "renderTexture"];
    protected override string[] Prefixes { get; } = ["RT_"];
    
    protected override string? FileType { get; } = "Render Texture";

    private const string EXCEPT_DIMENSION = "4";

    public override bool AppliesTo(RuleCheckContext context)
    {
        if (!base.AppliesTo(context))
        {
            return false;
        }

        bool isRenderTexture = false;
        foreach (string line in File.ReadLines(context.AbsolutePath))
        {
            string trimmedLine = line.Trim();
            if (trimmedLine is "RenderTexture:" or "CustomRenderTexture:")
            {
                isRenderTexture = true;
            }

            if (!isRenderTexture)
            {
                continue;
            }
            
            if (!trimmedLine.StartsWith("m_Dimension"))
            {
                continue;
            }

            return !trimmedLine.EndsWith(RenderTexture.EXCEPT_DIMENSION);
        }

        return false;
    }
}