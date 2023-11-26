using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.ComponentModel;
using OpenAINameGenerator.Util;

namespace OpenAINameGenerator.OPassowrd
{
    public partial class OPIntegration : IOPIntegration
    {
        public string? GetAPIKey()
        {
            string? apiKey = null;

            var vaultID = Environment.GetEnvironmentVariable("OP_PERSONAL_VAULT");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "op",
                    Arguments = $"read \"op://{vaultID}/OpenAI API/Key\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            try
            {
                process.Start();
            }
            catch (Win32Exception)
            {
                return null;
            }

            apiKey = process.StandardOutput.ReadLine();

            if (apiKey == null)
            {
                return null;
            }

            if (!IsValidApiKeyFormat(apiKey))
            {
                return null;
            }

            return apiKey;
        }

        private static bool IsValidApiKeyFormat(string secretKey)
        {
            return Constants.OpenAIKeyRegex().IsMatch(secretKey);
        }
    }
}
