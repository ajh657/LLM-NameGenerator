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
            ToolStripProgressBar toolStripProgressBar1;
            InputGroupBox = new GroupBox();
            button1 = new Button();
            inputTextBox = new TextBox();
            inputLabel = new Label();
            inputAPIKeyTextBox = new TextBox();
            inputAPIKeylabel = new Label();
            outputGroupBox = new GroupBox();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            InputGroupBox.SuspendLayout();
            outputGroupBox.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.MarqueeAnimationSpeed = 75;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar1.Visible = false;
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
            InputGroupBox.Size = new Size(280, 145);
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
            // 
            // inputTextBox
            // 
            inputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputTextBox.Location = new Point(6, 81);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(268, 23);
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
            inputAPIKeyTextBox.Location = new Point(6, 37);
            inputAPIKeyTextBox.Name = "inputAPIKeyTextBox";
            inputAPIKeyTextBox.Size = new Size(268, 23);
            inputAPIKeyTextBox.TabIndex = 1;
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
            outputGroupBox.Controls.Add(richTextBox1);
            outputGroupBox.Location = new Point(18, 163);
            outputGroupBox.Name = "outputGroupBox";
            outputGroupBox.Size = new Size(274, 263);
            outputGroupBox.TabIndex = 1;
            outputGroupBox.TabStop = false;
            outputGroupBox.Text = "Output";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(262, 235);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 429);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(304, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 451);
            Controls.Add(statusStrip1);
            Controls.Add(outputGroupBox);
            Controls.Add(InputGroupBox);
            Name = "MainForm";
            Text = "Open AI Namer";
            InputGroupBox.ResumeLayout(false);
            InputGroupBox.PerformLayout();
            outputGroupBox.ResumeLayout(false);
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
        private RichTextBox richTextBox1;
        private StatusStrip statusStrip1;
    }
}