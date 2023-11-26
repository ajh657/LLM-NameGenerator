using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAINameGenerator.OpenAI;
using OpenAINameGenerator.Util;

namespace OpenAINameGenerator
{
    public partial class MainForm : Form
    {
        private readonly IOpenAIClient _openAIClient;

        public MainForm(IOpenAIClient openAIClient)
        {
            InitializeComponent();
            _openAIClient = openAIClient;
            outputDataGridView.RowHeadersWidth = 75;

            if (_openAIClient.IsKeyLoadedExternaly())
            {
                SetExternalKeyNotice();
            }
        }

        #region OpenAI

        private async void inputSubmitButton_Click(object sender, EventArgs e)
        {
            await Generate();
        }

        private async void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ActiveControl = null;
                await Generate();
            }
        }

        private void SetExternalKeyNotice()
        {
            inputAPIKeyTextBox.Text = Constants.KeyloadedMessage;
            inputAPIKeyTextBox.UseSystemPasswordChar = false;
            inputAPIKeyTextBox.PasswordChar = '\0';
            inputAPIKeyTextBox.Enabled = false;
        }

        private async Task Generate()
        {
            toolStripProgressBar.Visible = true;

            if (!_openAIClient.IsKeyLoadedExternaly() && !_openAIClient.IsAuthenticated())
            {
                _openAIClient.Authenticate(inputAPIKeyTextBox.Text);
            }

            if (_openAIClient.IsAuthenticated())
            {
                var result = await _openAIClient.GenerateNames(inputTextBox.Text);

                if (result != null)
                {

                    var rows = outputDataGridView.Rows;

                    rows.Clear();

                    foreach (var item in result)
                    {
                        var row = new DataGridViewRow();
                        row.CreateCells(outputDataGridView);
                        row.HeaderCell.Value = (rows.Count + 1).ToString();
                        row.Cells[0].Value = item;

                        rows.Add(row);
                    }
                }
            }
            else
            {
                toolStripProgressBar.Visible = false;
                Extensions.ShowError(Constants.AuthenticationFailTitle, Constants.AuthenticationFailBody);
            }

            toolStripProgressBar.Visible = false;
        }

        #endregion

        #region Favorites

        private void savedItemsClearButton_Click(object sender, EventArgs e)
        {
            if (Extensions.ConformationDialogueBox(Constants.FavoritesClearBody) == DialogResult.OK)
            {
                favoritesDataGridView.Rows.Clear();
            }
        }

        private void savedItemsSaveButton_Click(object sender, EventArgs e)
        {
            string? selectedName = null;

            if (outputDataGridView.SelectedRows.Count == 1)
            {
                selectedName = outputDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            }

            if (outputDataGridView.SelectedCells.Count == 1)
            {
                if (outputDataGridView.SelectedCells[0].ColumnIndex == 0)
                {
                    selectedName = outputDataGridView.SelectedCells[0].Value.ToString();
                }
            }

            if (selectedName != null)
            {
                var rows = favoritesDataGridView.Rows;

                var row = new DataGridViewRow();
                row.CreateCells(outputDataGridView);
                row.HeaderCell.Value = (rows.Count + 1).ToString();
                row.Cells[0].Value = selectedName;

                rows.Add(row);
            }
        }

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _openAIClient.Dispose();
        }
    }
}
