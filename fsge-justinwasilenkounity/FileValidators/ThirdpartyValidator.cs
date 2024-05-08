using FSGE.Framework.FileValidator;
using FSGE.Framework.Rules;

namespace FSGE.Unity.JustinWasilenko.FileValidators;

public sealed class ThirdpartyValidator: IFileValidator
{
    public string GetInternalName()
    {
        return Constants.PREFIX + "/ignore-thirdparty";
    }

    public bool IsValid(RuleCheckContext ruleCheckContext)
    {
        return !ruleCheckContext.RelativePath.Contains("Thirdparty");
    }
}