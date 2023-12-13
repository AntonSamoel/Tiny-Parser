namespace Parser_Final_Project
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			mainPanel = new Panel();
			makeParseTreeBtn = new Button();
			generateTokensBtn = new Button();
			label1 = new Label();
			inputRichBox = new RichTextBox();
			tokenPanel = new Panel();
			tokensBackBtn = new Button();
			label2 = new Label();
			tokensRichBox = new RichTextBox();
			syntaxTreePanel = new Panel();
			syntaxTreeBackBtn = new Button();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			mainPanel.SuspendLayout();
			tokenPanel.SuspendLayout();
			syntaxTreePanel.SuspendLayout();
			SuspendLayout();
			// 
			// mainPanel
			// 
			mainPanel.Controls.Add(makeParseTreeBtn);
			mainPanel.Controls.Add(generateTokensBtn);
			mainPanel.Controls.Add(label1);
			mainPanel.Controls.Add(inputRichBox);
			mainPanel.Dock = DockStyle.Fill;
			mainPanel.Font = new Font("Ebrima", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			mainPanel.Location = new Point(0, 0);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new Size(1062, 673);
			mainPanel.TabIndex = 0;
			// 
			// makeParseTreeBtn
			// 
			makeParseTreeBtn.Location = new Point(28, 165);
			makeParseTreeBtn.Name = "makeParseTreeBtn";
			makeParseTreeBtn.Size = new Size(228, 42);
			makeParseTreeBtn.TabIndex = 3;
			makeParseTreeBtn.Text = "Make Parse Tree";
			makeParseTreeBtn.UseVisualStyleBackColor = true;
			makeParseTreeBtn.Click += makeParseTreeBtn_Click;
			// 
			// generateTokensBtn
			// 
			generateTokensBtn.Location = new Point(28, 87);
			generateTokensBtn.Name = "generateTokensBtn";
			generateTokensBtn.Size = new Size(228, 42);
			generateTokensBtn.TabIndex = 2;
			generateTokensBtn.Text = "Generate Tokens";
			generateTokensBtn.UseVisualStyleBackColor = true;
			generateTokensBtn.Click += generateTokensBtn_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(543, 47);
			label1.Name = "label1";
			label1.Size = new Size(215, 31);
			label1.TabIndex = 0;
			label1.Text = "Enter Source Code:";
			// 
			// inputRichBox
			// 
			inputRichBox.Location = new Point(310, 87);
			inputRichBox.Name = "inputRichBox";
			inputRichBox.Size = new Size(705, 545);
			inputRichBox.TabIndex = 1;
			inputRichBox.Text = "";
			// 
			// tokenPanel
			// 
			tokenPanel.Controls.Add(tokensBackBtn);
			tokenPanel.Controls.Add(label2);
			tokenPanel.Controls.Add(tokensRichBox);
			tokenPanel.Dock = DockStyle.Fill;
			tokenPanel.Font = new Font("Ebrima", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			tokenPanel.Location = new Point(0, 0);
			tokenPanel.Name = "tokenPanel";
			tokenPanel.Size = new Size(1062, 673);
			tokenPanel.TabIndex = 0;
			// 
			// tokensBackBtn
			// 
			tokensBackBtn.Location = new Point(50, 558);
			tokensBackBtn.Name = "tokensBackBtn";
			tokensBackBtn.Size = new Size(112, 38);
			tokensBackBtn.TabIndex = 2;
			tokensBackBtn.Text = "Back";
			tokensBackBtn.UseVisualStyleBackColor = true;
			tokensBackBtn.Click += tokensBackBtn_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(620, 68);
			label2.Name = "label2";
			label2.Size = new Size(78, 27);
			label2.TabIndex = 1;
			label2.Text = "Tokens";
			// 
			// tokensRichBox
			// 
			tokensRichBox.BackColor = Color.White;
			tokensRichBox.BorderStyle = BorderStyle.None;
			tokensRichBox.Font = new Font("Ebrima", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			tokensRichBox.Location = new Point(407, 109);
			tokensRichBox.Name = "tokensRichBox";
			tokensRichBox.ReadOnly = true;
			tokensRichBox.Size = new Size(511, 487);
			tokensRichBox.TabIndex = 0;
			tokensRichBox.Text = "";
			// 
			// syntaxTreePanel
			// 
			syntaxTreePanel.Controls.Add(syntaxTreeBackBtn);
			syntaxTreePanel.Dock = DockStyle.Fill;
			syntaxTreePanel.Location = new Point(0, 0);
			syntaxTreePanel.Name = "syntaxTreePanel";
			syntaxTreePanel.Size = new Size(1062, 673);
			syntaxTreePanel.TabIndex = 0;
			// 
			// syntaxTreeBackBtn
			// 
			syntaxTreeBackBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			syntaxTreeBackBtn.Location = new Point(12, 602);
			syntaxTreeBackBtn.Name = "syntaxTreeBackBtn";
			syntaxTreeBackBtn.Size = new Size(125, 47);
			syntaxTreeBackBtn.TabIndex = 0;
			syntaxTreeBackBtn.Text = "Back";
			syntaxTreeBackBtn.UseVisualStyleBackColor = true;
			syntaxTreeBackBtn.Click += syntaxTreeBackBtn_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1062, 673);
			Controls.Add(mainPanel);
			Controls.Add(tokenPanel);
			Controls.Add(syntaxTreePanel);
			Name = "Form1";
			Text = "Form1";
			mainPanel.ResumeLayout(false);
			mainPanel.PerformLayout();
			tokenPanel.ResumeLayout(false);
			tokenPanel.PerformLayout();
			syntaxTreePanel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel mainPanel;
		private Panel tokenPanel;
		private Panel syntaxTreePanel;
		private Label label1;
		private RichTextBox inputRichBox;
		private Button generateTokensBtn;
		private Label label2;
		private RichTextBox tokensRichBox;
		private Button tokensBackBtn;
		private Button makeParseTreeBtn;
		private Button syntaxTreeBackBtn;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}
