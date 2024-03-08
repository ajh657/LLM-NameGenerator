using System;
using System.Text.RegularExpressions;
using OpenAI.ObjectModels;

namespace OpenAINameGenerator.Util
{
    public static partial class Constants
    {
        public const string SystemPrompt = "You provide list of titles for the user inputs. Generated names must be in a Json formatted string array with no newlines. no formatting guides.";
        public const string AuthenticationFailBody = "Failed to authenticate with OpenAI. Please check your API key and try again.";
        public const string AuthenticationFailTitle = "Authentication Error";
        public const string KeyloadedMessage = "Key loaded externally";
        public const string FavoritesClearBody = "Are you sure you want to clear your favorites?";
        public static readonly string OpenAIGenerationErrorBody = $"Failed to generate names.{Environment.NewLine + Environment.NewLine}OpenAI error:";
        public static readonly string[] AvailableGPT4Models = [Models.Gpt_4, Models.Gpt_4_0314, Models.Gpt_4_0613, Models.Gpt_4_32k, Models.Gpt_4_0125_preview, Models.Gpt_4_1106_preview, Models.Gpt_4_32k, Models.Gpt_4_turbo_preview];
        public static readonly string[] AvailableGPT3Models = [Models.Gpt_3_5_Turbo, Models.Gpt_3_5_Turbo_0125, Models.Gpt_3_5_Turbo_1106, Models.Gpt_3_5_Turbo_16k];
        public static readonly string[] AvailableModels = [.. AvailableGPT4Models, .. AvailableGPT3Models];
        [GeneratedRegex("^sk-[a-zA-Z0-9]{32,}$", RegexOptions.Compiled)]
        public static partial Regex OpenAIKeyRegex();
        [GeneratedRegex(@"[0-9]+_[0-9]")]
        public static partial Regex UnderscoreBetweenNumbers();
    }
}
