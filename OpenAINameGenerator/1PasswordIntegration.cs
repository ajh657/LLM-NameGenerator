using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace OpenAINameGenerator
{
    internal static class OPIntegration
    {
        internal static string? GetAPIKey()
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

            while (!process.StandardOutput.EndOfStream)
            {
                apiKey = process.StandardOutput.ReadLine();
            }

            if(apiKey == null)
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
            return Regex.IsMatch(secretKey, @"^sk-[a-zA-Z0-9]{32,}$");
        }
    }
}
