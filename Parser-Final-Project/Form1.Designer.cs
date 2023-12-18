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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			mainPanel = new Panel();
			chooseTokens = new Button();
			chooseSourceCode = new Button();
			makeParseTreeUsingTokensBtn = new Button();
			label5 = new Label();
			label4 = new Label();
			inputTokensRichBox = new RichTextBox();
			errorLabel = new Label();
			label3 = new Label();
			tokensRichBox = new RichTextBox();
			label2 = new Label();
			makeParseTreeBtn = new Button();
			generateTokensBtn = new Button();
			label1 = new Label();
			inputRichBox = new RichTextBox();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			mainPanel.SuspendLayout();
			SuspendLayout();
			// 
			// mainPanel
			// 
			mainPanel.BackColor = Color.WhiteSmoke;
			mainPanel.BackgroundImageLayout = ImageLayout.Stretch;
			mainPanel.Controls.Add(chooseTokens);
			mainPanel.Controls.Add(chooseSourceCode);
			mainPanel.Controls.Add(makeParseTreeUsingTokensBtn);
			mainPanel.Controls.Add(label5);
			mainPanel.Controls.Add(label4);
			mainPanel.Controls.Add(inputTokensRichBox);
			mainPanel.Controls.Add(errorLabel);
			mainPanel.Controls.Add(label3);
			mainPanel.Controls.Add(tokensRichBox);
			mainPanel.Controls.Add(label2);
			mainPanel.Controls.Add(makeParseTreeBtn);
			mainPanel.Controls.Add(generateTokensBtn);
			mainPanel.Controls.Add(label1);
			mainPanel.Controls.Add(inputRichBox);
			mainPanel.Dock = DockStyle.Fill;
			mainPanel.Font = new Font("Ebrima", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			mainPanel.Location = new Point(0, 0);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new Size(1527, 673);
			mainPanel.TabIndex = 0;
			// 
			// chooseTokens
			// 
			chooseTokens.Location = new Point(1241, 552);
			chooseTokens.Name = "chooseTokens";
			chooseTokens.Size = new Size(182, 46);
			chooseTokens.TabIndex = 13;
			chooseTokens.Text = "Choose File ";
			chooseTokens.UseVisualStyleBackColor = true;
			chooseTokens.Click += chooseTokens_Click;
			// 
			// chooseSourceCode
			// 
			chooseSourceCode.Location = new Point(277, 550);
			chooseSourceCode.Name = "chooseSourceCode";
			chooseSourceCode.Size = new Size(196, 46);
			chooseSourceCode.TabIndex = 12;
			chooseSourceCode.Text = "Choose File ";
			chooseSourceCode.UseVisualStyleBackColor = true;
			chooseSourceCode.Click += chooseSourceCode_Click;
			// 
			// makeParseTreeUsingTokensBtn
			// 
			makeParseTreeUsingTokensBtn.Location = new Point(1018, 552);
			makeParseTreeUsingTokensBtn.Name = "makeParseTreeUsingTokensBtn";
			makeParseTreeUsingTokensBtn.Size = new Size(199, 44);
			makeParseTreeUsingTokensBtn.TabIndex = 11;
			makeParseTreeUsingTokensBtn.Text = "Make Parse Tree";
			makeParseTreeUsingTokensBtn.UseVisualStyleBackColor = true;
			makeParseTreeUsingTokensBtn.Click += makeParseTreeUsingTokensBtn_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = SystemColors.ControlDarkDark;
			label5.Location = new Point(1018, 91);
			label5.Name = "label5";
			label5.Size = new Size(405, 31);
			label5.TabIndex = 10;
			label5.Text = "Enter List of (tokenvalue, tokentype)";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = SystemColors.GrayText;
			label4.Location = new Point(951, 271);
			label4.Name = "label4";
			label4.Size = new Size(56, 38);
			label4.TabIndex = 9;
			label4.Text = "OR";
			// 
			// inputTokensRichBox
			// 
			inputTokensRichBox.Location = new Point(1018, 125);
			inputTokensRichBox.Name = "inputTokensRichBox";
			inputTokensRichBox.Size = new Size(405, 395);
			inputTokensRichBox.TabIndex = 8;
			inputTokensRichBox.Text = "";
			// 
			// errorLabel
			// 
			errorLabel.AutoSize = true;
			errorLabel.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			errorLabel.ForeColor = Color.Red;
			errorLabel.Location = new Point(593, 607);
			errorLabel.Name = "errorLabel";
			errorLabel.Size = new Size(0, 33);
			errorLabel.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = SystemColors.ControlDarkDark;
			label3.Location = new Point(684, 91);
			label3.Name = "label3";
			label3.Size = new Size(90, 31);
			label3.TabIndex = 6;
			label3.Text = "Tokens";
			// 
			// tokensRichBox
			// 
			tokensRichBox.Location = new Point(542, 125);
			tokensRichBox.Name = "tokensRichBox";
			tokensRichBox.Size = new Size(388, 395);
			tokensRichBox.TabIndex = 5;
			tokensRichBox.Text = "";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Ebrima", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.ButtonShadow;
			label2.Location = new Point(593, 9);
			label2.Name = "label2";
			label2.Size = new Size(316, 50);
			label2.TabIndex = 4;
			label2.Text = "Compiler Project";
			// 
			// makeParseTreeBtn
			// 
			makeParseTreeBtn.Location = new Point(643, 550);
			makeParseTreeBtn.Name = "makeParseTreeBtn";
			makeParseTreeBtn.Size = new Size(228, 42);
			makeParseTreeBtn.TabIndex = 3;
			makeParseTreeBtn.Text = "Make Parse Tree";
			makeParseTreeBtn.UseVisualStyleBackColor = true;
			makeParseTreeBtn.Click += makeParseTreeBtn_Click;
			// 
			// generateTokensBtn
			// 
			generateTokensBtn.Location = new Point(28, 552);
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
			label1.ForeColor = SystemColors.ControlDarkDark;
			label1.Location = new Point(156, 91);
			label1.Name = "label1";
			label1.Size = new Size(215, 31);
			label1.TabIndex = 0;
			label1.Text = "Enter Source Code:";
			// 
			// inputRichBox
			// 
			inputRichBox.Location = new Point(28, 125);
			inputRichBox.Name = "inputRichBox";
			inputRichBox.Size = new Size(489, 395);
			inputRichBox.TabIndex = 1;
			inputRichBox.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1527, 673);
			Controls.Add(mainPanel);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "Tiny Language Compiler";
			mainPanel.ResumeLayout(false);
			mainPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel mainPanel;
		private Label label1;
		private RichTextBox inputRichBox;
		private Button generateTokensBtn;
		private Button makeParseTreeBtn;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Label label2;
		private Label label3;
		private RichTextBox tokensRichBox;
		private Label errorLabel;
		private RichTextBox inputTokensRichBox;
		private Button makeParseTreeUsingTokensBtn;
		private Label label5;
		private Label label4;
		private Button chooseSourceCode;
		private Button chooseTokens;
	}
}
