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
			// errorLabel
			// 
			errorLabel.AutoSize = true;
			errorLabel.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			errorLabel.ForeColor = Color.Red;
			errorLabel.Location = new Point(335, 581);
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
			makeParseTreeBtn.Location = new Point(542, 572);
			makeParseTreeBtn.Name = "makeParseTreeBtn";
			makeParseTreeBtn.Size = new Size(228, 42);
			makeParseTreeBtn.TabIndex = 3;
			makeParseTreeBtn.Text = "Make Parse Tree";
			makeParseTreeBtn.UseVisualStyleBackColor = true;
			makeParseTreeBtn.Click += makeParseTreeBtn_Click;
			// 
			// generateTokensBtn
			// 
			generateTokensBtn.Location = new Point(28, 572);
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
	}
}
