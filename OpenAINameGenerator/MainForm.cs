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

        public MainForm()
        {
            InitializeComponent();
            outputDataGridView.RowHeadersWidth = 75;
        }

        private async void inputSubmitButton_Click(object sender, EventArgs e)
        {
            var Authenticated = Authenticate();

            if (Authenticated)
            {
                toolStripProgressBar.Visible = true;
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

            toolStripProgressBar.Visible = false;
        }

        private bool Authenticate()
        {
            var currentApiKey = inputAPIKeyTextBox.Text;

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
