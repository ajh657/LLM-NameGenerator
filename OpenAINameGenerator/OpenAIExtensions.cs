using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI.ObjectModels.ResponseModels;

namespace OpenAINameGenerator
{
    public static class OpenAIExtensions
    {
        public static string[] GetResponce(this ChatCompletionCreateResponse? reponce)
        {
            if (reponce == null)
            {
                return Array.Empty<string>();
            }

            var responceString = reponce.Choices.First().Message.Content;

            string removedEndingPeriod;
            if (responceString.EndsWith('.'))
            {
                removedEndingPeriod = responceString.Remove(responceString.Length - 1, 1);
            }
            else
            {
                removedEndingPeriod = responceString;
            }

            var splitString = removedEndingPeriod.Split('\n');
            var unNumberedstring = splitString.Select(x => Constants.IndexRegex.Replace(x, string.Empty));
            var unQuotedStrings = unNumberedstring.Select(x => x.StartsWith('"') && x.EndsWith('"') ? x.Trim('"'):x);
            return unQuotedStrings.ToArray();
        }
    }
}
