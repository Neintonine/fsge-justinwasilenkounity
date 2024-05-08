﻿using FSGE.Framework.Rules;

namespace FSGE.Unity.JustinWasilenko.Rules;

public sealed class NoSpaces: Rule
{
    public override string GetInternalName()
    {
        return Constants.PREFIX + "/no-spaces";
    }

    public override string GetDisplayName()
    {
        return "Folders and files should not contain spaces";
    }

    public override string GetDescription()
    {
        return "see: https://github.com/justinwasilenko/Unity-Style-Guide?tab=readme-ov-file#never-use-spaces";
    }

    public override bool AppliesTo(RuleCheckContext context)
    {
        return true;
    }

    public override bool IsValid(RuleCheckContext context)
    {
        return !context.RelativePath.Contains(' ');
    }
}