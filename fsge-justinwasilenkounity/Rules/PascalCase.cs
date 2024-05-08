using System.Text.RegularExpressions;
using FSGE.Framework.Rules;

namespace FSGE.Unity.JustinWasilenko.Rules
{
    public sealed class PascalCase : Rule
    {
        private static string[] _delimiters =
        [
            "_", "\\\\", "\\/", " "
        ];

        private readonly Regex _regex;
        
        public PascalCase()
        {
            string delimiters = String.Join("", PascalCase._delimiters);
            this._regex = new Regex($"([{delimiters}][a-z])");
        }
        
        public override string GetInternalName()
        {
            return $"{Constants.PREFIX}/camel-case";
        }

        public override string GetDisplayName()
        {
            return "Filenames and Directories should be pascal case";
        }

        public override string GetDescription()
        {
            return "see: https://github.com/justinwasilenko/Unity-Style-Guide?tab=readme-ov-file#always-use-pascalcase";
        }

        public override bool AppliesTo(RuleCheckContext context)
        {
            return true;
        }

        public override bool IsValid(RuleCheckContext context)
        {
            return !this._regex.IsMatch(context.RelativePath);
        }
    }
}