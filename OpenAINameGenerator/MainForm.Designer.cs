using System.Drawing;
using System.Windows.Forms;

namespace OpenAINameGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            var dataGridViewCellStyle3 = new DataGridViewCellStyle();
            var dataGridViewCellStyle4 = new DataGridViewCellStyle();
            toolStripProgressBar = new ToolStripProgressBar();
            InputGroupBox = new GroupBox();
            InputModelLabel = new Label();
            InputModelComboBox = new ComboBox();
            inputSubmitButton = new Button();
            inputTextBox = new TextBox();
            inputLabel = new Label();
            inputAPIKeyTextBox = new TextBox();
            inputAPIKeylabel = new Label();
            outputGroupBox = new GroupBox();
            savedItemsGroupBox = new GroupBox();
            savedItemsButtonsGroupBox = new GroupBox();
            savedItemsClearButton = new Button();
            savedItemsSaveButton = new Button();
            favoritesDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            outputDataGridView = new DataGridView();
            EntryColumn = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            InputGroupBox.SuspendLayout();
            outputGroupBox.SuspendLayout();
            savedItemsGroupBox.SuspendLayout();
            savedItemsButtonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)favoritesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outputDataGridView).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.MarqueeAnimationSpeed = 75;
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(100, 16);
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.Visible = false;
            // 
            // InputGroupBox
            // 
            InputGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InputGroupBox.Controls.Add(InputModelLabel);
            InputGroupBox.Controls.Add(InputModelComboBox);
            InputGroupBox.Controls.Add(inputSubmitButton);
            InputGroupBox.Controls.Add(inputTextBox);
            InputGroupBox.Controls.Add(inputLabel);
            InputGroupBox.Controls.Add(inputAPIKeyTextBox);
            InputGroupBox.Controls.Add(inputAPIKeylabel);
            InputGroupBox.Location = new Point(12, 12);
            InputGroupBox.Name = "InputGroupBox";
            InputGroupBox.Size = new Size(645, 213);
            InputGroupBox.TabIndex = 0;
            InputGroupBox.TabStop = false;
            InputGroupBox.Text = "Input";
            // 
            // InputModelLabel
            // 
            InputModelLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            InputModelLabel.AutoSize = true;
            InputModelLabel.Location = new Point(6, 137);
            InputModelLabel.Name = "InputModelLabel";
            InputModelLabel.Size = new Size(49, 15);
            InputModelLabel.TabIndex = 6;
            InputModelLabel.Text = "Models:";
            // 
            // InputModelComboBox
            // 
            InputModelComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            InputModelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InputModelComboBox.FormattingEnabled = true;
            InputModelComboBox.Location = new Point(6, 155);
            InputModelComboBox.Name = "InputModelComboBox";
            InputModelComboBox.Size = new Size(120, 23);
            InputModelComboBox.TabIndex = 5;
            InputModelComboBox.SelectedIndexChanged += InputModelComboBox_SelectedIndexChanged;
            // 
            // inputSubmitButton
            // 
            inputSubmitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inputSubmitButton.Location = new Point(6, 184);
            inputSubmitButton.Name = "inputSubmitButton";
            inputSubmitButton.Size = new Size(120, 23);
            inputSubmitButton.TabIndex = 4;
            inputSubmitButton.Text = "Generate Names";
            inputSubmitButton.UseVisualStyleBackColor = true;
            inputSubmitButton.Click += inputSubmitButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputTextBox.Location = new Point(6, 81);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(633, 23);
            inputTextBox.TabIndex = 3;
            inputTextBox.KeyPress += inputTextBox_KeyPress;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(6, 63);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(80, 15);
            inputLabel.TabIndex = 2;
            inputLabel.Text = "To Be Named:";
            // 
            // inputAPIKeyTextBox
            // 
            inputAPIKeyTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputAPIKeyTextBox.Location = new Point(6, 37);
            inputAPIKeyTextBox.Name = "inputAPIKeyTextBox";
            inputAPIKeyTextBox.PasswordChar = '*';
            inputAPIKeyTextBox.Size = new Size(633, 23);
            inputAPIKeyTextBox.TabIndex = 1;
            inputAPIKeyTextBox.UseSystemPasswordChar = true;
            // 
            // inputAPIKeylabel
            // 
            inputAPIKeylabel.AutoSize = true;
            inputAPIKeylabel.Location = new Point(6, 19);
            inputAPIKeylabel.Name = "inputAPIKeylabel";
            inputAPIKeylabel.Size = new Size(93, 15);
            inputAPIKeylabel.TabIndex = 0;
            inputAPIKeylabel.Text = "OpenAI API Key:";
            // 
            // outputGroupBox
            // 
            outputGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outputGroupBox.Controls.Add(savedItemsGroupBox);
            outputGroupBox.Controls.Add(outputDataGridView);
            outputGroupBox.Location = new Point(12, 231);
            outputGroupBox.Name = "outputGroupBox";
            outputGroupBox.Size = new Size(645, 294);
            outputGroupBox.TabIndex = 1;
            outputGroupBox.TabStop = false;
            outputGroupBox.Text = "Output";
            // 
            // savedItemsGroupBox
            // 
            savedItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            savedItemsGroupBox.Controls.Add(savedItemsButtonsGroupBox);
            savedItemsGroupBox.Controls.Add(favoritesDataGridView);
            savedItemsGroupBox.Location = new Point(305, 22);
            savedItemsGroupBox.Name = "savedItemsGroupBox";
            savedItemsGroupBox.Size = new Size(334, 266);
            savedItemsGroupBox.TabIndex = 1;
            savedItemsGroupBox.TabStop = false;
            savedItemsGroupBox.Text = "Saved generations";
            // 
            // savedItemsButtonsGroupBox
            // 
            savedItemsButtonsGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            savedItemsButtonsGroupBox.Controls.Add(savedItemsClearButton);
            savedItemsButtonsGroupBox.Controls.Add(savedItemsSaveButton);
            savedItemsButtonsGroupBox.Location = new Point(6, 213);
            savedItemsButtonsGroupBox.Name = "savedItemsButtonsGroupBox";
            savedItemsButtonsGroupBox.Size = new Size(322, 47);
            savedItemsButtonsGroupBox.TabIndex = 2;
            savedItemsButtonsGroupBox.TabStop = false;
            // 
            // savedItemsClearButton
            // 
            savedItemsClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            savedItemsClearButton.Location = new Point(241, 18);
            savedItemsClearButton.Name = "savedItemsClearButton";
            savedItemsClearButton.Size = new Size(75, 23);
            savedItemsClearButton.TabIndex = 1;
            savedItemsClearButton.Text = "Clear";
            savedItemsClearButton.UseVisualStyleBackColor = true;
            savedItemsClearButton.Click += savedItemsClearButton_Click;
            // 
            // savedItemsSaveButton
            // 
            savedItemsSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            savedItemsSaveButton.Location = new Point(6, 18);
            savedItemsSaveButton.Name = "savedItemsSaveButton";
            savedItemsSaveButton.Size = new Size(95, 23);
            savedItemsSaveButton.TabIndex = 0;
            savedItemsSaveButton.Text = "Save selected";
            savedItemsSaveButton.UseVisualStyleBackColor = true;
            savedItemsSaveButton.Click += savedItemsSaveButton_Click;
            // 
            // favoritesDataGridView
            // 
            favoritesDataGridView.AllowUserToAddRows = false;
            favoritesDataGridView.AllowUserToDeleteRows = false;
            favoritesDataGridView.AllowUserToResizeRows = false;
            favoritesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            favoritesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            favoritesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            favoritesDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            favoritesDataGridView.Location = new Point(6, 22);
            favoritesDataGridView.Name = "favoritesDataGridView";
            favoritesDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            favoritesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            favoritesDataGridView.Size = new Size(322, 185);
            favoritesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // outputDataGridView
            // 
            outputDataGridView.AllowUserToAddRows = false;
            outputDataGridView.AllowUserToDeleteRows = false;
            outputDataGridView.AllowUserToResizeRows = false;
            outputDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            outputDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            outputDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            outputDataGridView.Columns.AddRange(new DataGridViewColumn[] { EntryColumn });
            outputDataGridView.Location = new Point(6, 22);
            outputDataGridView.Name = "outputDataGridView";
            outputDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            outputDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            outputDataGridView.Size = new Size(293, 266);
            outputDataGridView.TabIndex = 0;
            // 
            // EntryColumn
            // 
            EntryColumn.HeaderText = "Name";
            EntryColumn.Name = "EntryColumn";
            EntryColumn.ReadOnly = true;
            EntryColumn.Width = 200;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar });
            statusStrip1.Location = new Point(0, 528);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(669, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 550);
            Controls.Add(statusStrip1);
            Controls.Add(outputGroupBox);
            Controls.Add(InputGroupBox);
            Name = "MainForm";
            Text = "Open AI Namer";
            FormClosing += MainForm_FormClosing;
            InputGroupBox.ResumeLayout(false);
            InputGroupBox.PerformLayout();
            outputGroupBox.ResumeLayout(false);
            savedItemsGroupBox.ResumeLayout(false);
            savedItemsButtonsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)favoritesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)outputDataGridView).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox InputGroupBox;
        private TextBox inputAPIKeyTextBox;
        private Label inputAPIKeylabel;
        private TextBox inputTextBox;
        private Label inputLabel;
        private Button inputSubmitButton;
        private GroupBox outputGroupBox;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar;
        private DataGridView outputDataGridView;
        private DataGridViewTextBoxColumn EntryColumn;
        private GroupBox savedItemsGroupBox;
        private GroupBox savedItemsButtonsGroupBox;
        private Button savedItemsClearButton;
        private Button savedItemsSaveButton;
        private DataGridView favoritesDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ComboBox InputModelComboBox;
        private Label InputModelLabel;
    }
}
