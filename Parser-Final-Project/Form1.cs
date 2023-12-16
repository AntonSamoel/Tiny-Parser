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
			TokenOutput = "\tValue\t\tToken Type\n\t--------------------------\n";
			foreach (var item in scanner.Tokens)
			{
				TokenOutput += item.ToString() + "\n";
			}
			if (Errors.Error_List.Count > 0)
			{
				foreach (var item in Errors.Error_List)
				{
					TokenOutput += item;
				}
			}
				
			tokensRichBox.Text = TokenOutput;
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

			if(scanner.Tokens.Count == 0)
			{
				errorLabel.Text = "No Tokens Found To Parse";
			}

			else if (Errors.Error_List.Count > 0)
			{
				errorLabel.Text = "Can't Parse Unrecognized token !!";
			}
			else
			{
				errorLabel.Text = "";
				Parser parser = new(scanner.Tokens);
				parser.Program();
				SyntaxTree = parser._SyntaxTree;
				SyntaxTreeForm syntaxTreeForm = new SyntaxTreeForm(SyntaxTree);
				syntaxTreeForm.Show();
			}

			Errors.Error_List = new List<string>();
			


		}

		private void syntaxTreeBackBtn_Click(object sender, EventArgs e)
		{
			mainPanel.BringToFront();
		}

		
	}

}

