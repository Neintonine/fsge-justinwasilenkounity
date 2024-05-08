using FSGE.Framework.Rules;

namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming.Rendering;

public abstract class RenderingAsset: AssetRule
{
    protected override string[] FileExtensions { get; } = ["asset"];

    protected abstract string ScriptLine { get; }
    
    
    public override bool AppliesTo(RuleCheckContext context)
    {
        if (!base.AppliesTo(context))
        {
            return false;
        }

        bool isAsset = File.ReadLines(context.AbsolutePath).Any(line => line.Trim() == this.ScriptLine);
        return isAsset;
    }
}