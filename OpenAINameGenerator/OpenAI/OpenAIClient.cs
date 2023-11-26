using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI;
using OpenAI.Managers;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels;
using OpenAINameGenerator.Util;
using OpenAINameGenerator.OPassowrd;

namespace OpenAINameGenerator.OpenAI
{
    public class OpenAIClient : IDisposable, IOpenAIClient
    {
        private OpenAIService? _openAIService;
        private string? _apiKey;
        private bool _authenticated = false;
        private bool _keyLoadedExternaly = false;

        public OpenAIClient(IOPIntegration OPIntegration)
        {
            var opAPIKey = OPIntegration.GetAPIKey();

            if (opAPIKey != null)
            {
                Authenticate(opAPIKey);
                _keyLoadedExternaly = true;
            }
        }

        public async Task<IEnumerable<string>> GenerateNames(string input)
        {
            if (_authenticated && _openAIService != null)
            {
                var generationResult = await _openAIService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest()
                {
                    Messages = new List<ChatMessage>()
                    {
                        ChatMessage.FromSystem(Constants.SystemPrompt),
                        ChatMessage.FromUser(input)
                    },
                    Model = Models.Gpt_4,
                    MaxTokens = 256
                });

                if (generationResult != null)
                {
                    if (generationResult.Successful)
                    {
                        return generationResult.GetResponce();
                    }
                    else
                    {
                        Extensions.ShowError(Constants.OpenAIGenerationErrorBody + generationResult.Error?.Message);
                    }
                }
            }

            return Array.Empty<string>();
        }

        public bool Authenticate(string newAPIKey)
        {

            if (_openAIService == null || newAPIKey != _apiKey)
            {
                if (!string.IsNullOrEmpty(newAPIKey))
                {
                    _openAIService = new OpenAIService(new OpenAiOptions()
                    {
                        ApiKey = newAPIKey
                    });
                    _apiKey = newAPIKey;
                    _authenticated = true;
                    return true;
                }
            }

            return false;
        }

        public bool IsAuthenticated()
        {
            return _authenticated;
        }

        public bool IsKeyLoadedExternaly()
        {
            return _keyLoadedExternaly;
        }

        public void Dispose()
        {
            if (_openAIService != null && _authenticated)
            {
                _openAIService.Dispose();
                GC.SuppressFinalize(this);
            }
        }
    }
}
