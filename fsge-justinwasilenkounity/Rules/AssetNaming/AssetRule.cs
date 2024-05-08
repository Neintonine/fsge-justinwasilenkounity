using FSGE.Framework.Rules;

namespace FSGE.Unity.JustinWasilenko.Rules.AssetNaming;

public abstract class AssetRule : Rule
{
    protected abstract string[] FileExtensions { get; }
    protected abstract string[] Prefixes { get; }

    protected virtual string? FileType { get; } = null;

    public override string GetInternalName()
    {
        return Constants.PREFIX + "/asset-";
    }

    public override string GetDisplayName()
    {
        return "Asset has an incorrect prefix";
    }

    public override string GetDescription()
    {
        string extensionString = String.Join(", ", this.FileExtensions);
        string prefixString = String.Join(", ", this.Prefixes);

        if (this.FileType != null)
        {
            return $"Files of type '{this.FileType}' needs to have one of the following prefixes: {prefixString}";
        }
        
        return $"Files with the extension of '{extensionString}' needs to have one of the following prefixes: {prefixString}";
    }

    public override bool AppliesTo(RuleCheckContext context)
    {
        string extension = Path.GetExtension(context.RelativePath);
        
        foreach (string fileExtension in this.FileExtensions)
        {
            if (extension == $".{fileExtension}")
            {
                return true;
            }
        }

        return false;
    }

    public override bool IsValid(RuleCheckContext context)
    {
        string fileName = Path.GetFileName(context.RelativePath);

        foreach (string prefix in this.Prefixes)
        {
            if (fileName.StartsWith(prefix))
            {
                return true;
            }
        }

        return false;
    }
}