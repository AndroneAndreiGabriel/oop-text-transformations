using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTextTransformations.Library.Rules
{
    public class StringLowerCaseRule : TransformationRule
    {
        public override string Transform(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return input.ToLower();
        }
    }
}
