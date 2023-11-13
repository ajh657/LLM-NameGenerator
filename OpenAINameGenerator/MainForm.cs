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
using OpenAI.ObjectModels;

namespace OpenAINameGenerator
{
    public partial class MainForm : Form
    {
        private static OpenAIService? _openAIService;
        private static string? _apiKey;
        private static string? _opAPIKey;

        public MainForm()
        {
            InitializeComponent();
            outputDataGridView.RowHeadersWidth = 75;

            GetOPAPIKey();

        }

        private void GetOPAPIKey()
        {
            var opAPIKey = OPIntegration.GetAPIKey();

            if (opAPIKey != null)
            {
                _opAPIKey = opAPIKey;
                inputAPIKeyTextBox.Text = "Key Loaded From 1Password";
                inputAPIKeyTextBox.UseSystemPasswordChar = false;
                inputAPIKeyTextBox.PasswordChar = '\0';
                inputAPIKeyTextBox.Enabled = false;
            }
        }

        private async void inputSubmitButton_Click(object sender, EventArgs e)
        {
            var Authenticated = Authenticate();

            toolStripProgressBar.Visible = true;

            await GenerateNames(Authenticated);

            toolStripProgressBar.Visible = false;
        }

        private async Task GenerateNames(bool Authenticated)
        {
            if (Authenticated)
            {
                var generationResult = await _openAIService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest()
                {
                    Messages = new List<ChatMessage>()
                    {
                        ChatMessage.FromSystem(Constants.SystemPrompt),
                        ChatMessage.FromUser(inputTextBox.Text)
                    },
                    Model = Models.Gpt_4,
                    MaxTokens = 256
                });

                if (generationResult != null)
                {
                    if (generationResult.Successful)
                    {
                        var names = generationResult.GetResponce();
                        var dataTableRows = outputDataGridView.Rows;

                        dataTableRows.Clear();

                        foreach (var item in names)
                        {
                            var row = new DataGridViewRow();
                            row.CreateCells(outputDataGridView);
                            row.HeaderCell.Value = (dataTableRows.Count + 1).ToString();
                            row.Cells[0].Value = item;

                            outputDataGridView.Rows.Add(row);
                        }
                    }
                    else
                    {
                        if (generationResult.Error != null)
                        {
                            ShowError("Generation failed!", generationResult.Error.ToString());
                        }
                        else
                        {
                            ShowError("Generation failed!", "Unknown error");
                        }
                    }
                }
                else
                {
                    ShowError("Generation failed!", "Unknown error");
                }
            }
        }

        private bool Authenticate()
        {

            if (_openAIService != null)
            {
                return true;
            }

            string currentApiKey;
            if (_opAPIKey != null)
            {
                currentApiKey = _opAPIKey;
            }
            else
            {
                currentApiKey = inputAPIKeyTextBox.Text;
            }

            if (_openAIService == null || currentApiKey != _apiKey)
            {
                if (!string.IsNullOrEmpty(currentApiKey))
                {
                    _openAIService = new OpenAIService(new OpenAiOptions()
                    {
                        ApiKey = currentApiKey
                    });
                    _apiKey = currentApiKey;
                    return true;
                }
            }

            ShowError("API Key authentication failed!", "Please chek the api key");
            return false;
        }

        private static void ShowError(string title, string? body)
        {
            if (body != null)
            {
                MessageBox.Show(body, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
