using System.Linq;
using Newtonsoft.Json;
using OpenAI.ObjectModels.ResponseModels;

namespace OpenAINameGenerator.OpenAI
{
    public static class OpenAIExtensions
    {
        public static string[] GetResponce(this ChatCompletionCreateResponse? reponce)
        {
            if (reponce == null)
            {
                return [];
            }

            var responceString = reponce.Choices.First().Message.Content;

            var array = JsonConvert.DeserializeObject<string[]>(responceString);
            array ??= [];

            return array;
        }
    }
}
