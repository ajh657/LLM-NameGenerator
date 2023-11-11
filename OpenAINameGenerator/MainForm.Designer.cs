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
            toolStripProgressBar = new ToolStripProgressBar();
            InputGroupBox = new GroupBox();
            button1 = new Button();
            inputTextBox = new TextBox();
            inputLabel = new Label();
            inputAPIKeyTextBox = new TextBox();
            inputAPIKeylabel = new Label();
            outputGroupBox = new GroupBox();
            outputDataGridView = new DataGridView();
            EntryColumn = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            InputGroupBox.SuspendLayout();
            outputGroupBox.SuspendLayout();
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
            InputGroupBox.Controls.Add(button1);
            InputGroupBox.Controls.Add(inputTextBox);
            InputGroupBox.Controls.Add(inputLabel);
            InputGroupBox.Controls.Add(inputAPIKeyTextBox);
            InputGroupBox.Controls.Add(inputAPIKeylabel);
            InputGroupBox.Location = new Point(12, 12);
            InputGroupBox.Name = "InputGroupBox";
            InputGroupBox.Size = new Size(305, 145);
            InputGroupBox.TabIndex = 0;
            InputGroupBox.TabStop = false;
            InputGroupBox.Text = "Input";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(6, 116);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 4;
            button1.Text = "Generate Names";
            button1.UseVisualStyleBackColor = true;
            button1.Click += inputSubmitButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputTextBox.Location = new Point(6, 81);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(293, 23);
            inputTextBox.TabIndex = 3;
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
            inputAPIKeyTextBox.Size = new Size(293, 23);
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
            outputGroupBox.Controls.Add(outputDataGridView);
            outputGroupBox.Location = new Point(12, 163);
            outputGroupBox.Name = "outputGroupBox";
            outputGroupBox.Size = new Size(305, 296);
            outputGroupBox.TabIndex = 1;
            outputGroupBox.TabStop = false;
            outputGroupBox.Text = "Output";
            // 
            // outputDataGridView
            // 
            outputDataGridView.AllowUserToAddRows = false;
            outputDataGridView.AllowUserToDeleteRows = false;
            outputDataGridView.AllowUserToResizeRows = false;
            outputDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            outputDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            outputDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            outputDataGridView.Columns.AddRange(new DataGridViewColumn[] { EntryColumn });
            outputDataGridView.Location = new Point(6, 22);
            outputDataGridView.Name = "outputDataGridView";
            outputDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            outputDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            outputDataGridView.RowTemplate.Height = 25;
            outputDataGridView.Size = new Size(293, 268);
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
            statusStrip1.Location = new Point(0, 462);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(329, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 484);
            Controls.Add(statusStrip1);
            Controls.Add(outputGroupBox);
            Controls.Add(InputGroupBox);
            Name = "MainForm";
            Text = "Open AI Namer";
            InputGroupBox.ResumeLayout(false);
            InputGroupBox.PerformLayout();
            outputGroupBox.ResumeLayout(false);
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
        private Button button1;
        private GroupBox outputGroupBox;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar;
        private DataGridView outputDataGridView;
        private DataGridViewTextBoxColumn EntryColumn;
    }
}