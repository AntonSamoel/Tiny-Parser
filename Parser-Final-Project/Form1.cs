using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parser_Final_Project
{
	public partial class Form1 : Form
	{

		public string TokenOutput { get; set; }
		public SyntaxTree SyntaxTree { get; set; }
		public Form1()
		{
			InitializeComponent();

		}

		private void generateTokensBtn_Click(object sender, EventArgs e)
		{
			string input = inputRichBox.Text;
			Scanner scanner = new();
			scanner.StartScanning(input);
			TokenOutput = "";
			foreach (var item in scanner.Tokens)
			{
				TokenOutput += item.ToString() + "\n";
			}
			tokensRichBox.Text = TokenOutput;
			tokenPanel.BringToFront();
		}

		private void tokensBackBtn_Click(object sender, EventArgs e)
		{
			mainPanel.BringToFront();
		}

		private void makeParseTreeBtn_Click(object sender, EventArgs e)
		{
			string input = inputRichBox.Text;
			Scanner scanner = new();
			scanner.StartScanning(input);
			Parser parser = new(scanner.Tokens);
			parser.Program();
			SyntaxTree = parser._SyntaxTree;
			SyntaxTreeForm syntaxTreeForm = new SyntaxTreeForm(SyntaxTree);
			syntaxTreeForm.Show();
	
		}

		private void syntaxTreeBackBtn_Click(object sender, EventArgs e)
		{
			mainPanel.BringToFront();
		}


	
		
	}

}

