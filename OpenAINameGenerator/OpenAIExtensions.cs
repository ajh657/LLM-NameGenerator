using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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

            var array = JsonConvert.DeserializeObject<string[]>(responceString);
            array ??= Array.Empty<string>();

            return array;
        }
    }
}
