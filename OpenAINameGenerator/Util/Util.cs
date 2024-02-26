using System;
using System.Linq;
using System.Reflection;
using OpenAI.ObjectModels;

namespace OpenAINameGenerator.Util
{
    public static class Util
    {
        public static string[] GetGPTModels()
        {
            var type = typeof(Models.Model);
            var values = Enum.GetValues(type).Cast<Models.Model>();
            var filteredValues = values.Where(x => type.GetField(x.ToString())?.GetCustomAttribute<ObsoleteAttribute>() == null);
            return filteredValues.Where(x => x.ToString().StartsWith("Gpt_")).Select(x => x.ToString().Replace('_', ' ')).ToArray();
        }
    }
}
