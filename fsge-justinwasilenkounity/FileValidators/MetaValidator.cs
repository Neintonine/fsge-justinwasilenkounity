using FSGE.Framework.FileValidator;
using FSGE.Framework.Rules;

namespace FSGE.Unity.JustinWasilenko.FileValidators;

public sealed class MetaValidator: IFileValidator
{
    public string GetInternalName()
    {
        return Constants.PREFIX + "/meta-validator";
    }

    public bool IsValid(RuleCheckContext ruleCheckContext)
    {
        return !ruleCheckContext.RelativePath.EndsWith(".meta");
    }
}