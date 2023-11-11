using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI.Managers;
using OpenAI.ObjectModels.RequestModels;
using OpenAI;

namespace OpenAINameGenerator
{
    public partial class MainForm : Form
    {
        private static OpenAIService? _openAIService;
        private static string? _apiKey;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void inputSubmitButton_Click(object sender, EventArgs e)
        {
            Authenticate();

            var generationResult = await _openAIService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest()
            {
                Messages = new List<ChatMessage>()
                {
                }
            });
        }

        private void Authenticate()
        {
            var currentApiKey = inputAPIKeyTextBox.Text;

            if (_openAIService != null || currentApiKey != _apiKey)
            {
                _openAIService = new OpenAIService(new OpenAiOptions()
                {
                    ApiKey = currentApiKey
                });
                _apiKey = currentApiKey;
            }
        }
    }
}
