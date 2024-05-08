using System.Text.RegularExpressions;
using FSGE.Framework.Rules;

namespace FSGE.Unity.JustinWasilenko.Rules;

public sealed class NoUnicode : Rule
{
    private readonly Regex _regex = new($@"[A-Za-z.0-9\\ _]");

    public override string GetInternalName()
    {
        return Constants.PREFIX + "/no-unicode";
    }

    public override string GetDisplayName()
    {
        return "Unicode in file and folder names are prohibited";
    }

    public override string GetDescription()
    {
        return "see: https://github.com/justinwasilenko/Unity-Style-Guide?tab=readme-ov-file#never-use-unicode-characters-and-other-symbols";
    }

    public override bool AppliesTo(RuleCheckContext context)
    {
        return true;
    }

    public override bool IsValid(RuleCheckContext context)
    {
        return this._regex.Replace(context.RelativePath, "").Length < 1;
    }
}