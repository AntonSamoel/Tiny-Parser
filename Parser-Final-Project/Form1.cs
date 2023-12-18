using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parser_Final_Project
{
	public partial class Form1 : Form
	{
		private bool parse = true;
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

			if(Errors.Error_List.Count > 0)
			{
				errorLabel.Text = "Can't Parse Unrecognized token !!";
			}
			else if (scanner.Tokens.Count == 0)
			{
				errorLabel.Text = "No Tokens Found To Parse";
			}

			else
			{
				parse = true;
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

		private void makeParseTreeUsingTokensBtn_Click(object sender, EventArgs e)
		{
			//errorLabel.Text = "";
			List<Token> tokens = MakeTokens(inputTokensRichBox.Text);
			if (parse)
			{
				Parser parser = new(tokens);
				parser.Program();
				SyntaxTree = parser._SyntaxTree;
				SyntaxTreeForm syntaxTreeForm = new SyntaxTreeForm(SyntaxTree);
				syntaxTreeForm.Show();
			}
		}

		private List<Token> MakeTokens(string text)
		{

			List<Token> tokens = new List<Token>();
			string[] lines = text.Split('\n');
			foreach (string line in lines)
			{
				if (!line.Contains(','))
				{
					errorLabel.Text = "Invalid Input !!";
					parse = false;
					break;
				}
				else
				{
					string[] tokenValue = line.Split(',');
					Token_Class type = GetTokenClass(tokenValue[1].Trim(' '));

					if (type == Token_Class.ERROR)
					{
						errorLabel.Text = "Can't Parse Unrecognized token !!";
						parse = false;
						break;
					}
					else
					{
						Token token = new() { lex = tokenValue[0], token_type = type };
						tokens.Add(token);
						parse = true;

					}
					errorLabel.Text = "";
				}

			}

			return tokens;
		}

		private Token_Class GetTokenClass(string type)
		{
			switch (type)
			{
				case "SEMICOLON":
					return Token_Class.SEMICOLON;
				case "IF":
					return Token_Class.IF;
				case "THEN":
					return Token_Class.THEN;
				case "END":
					return Token_Class.END;
				case "REPEAT":
					return Token_Class.REPEAT;
				case "UNTIL":
					return Token_Class.UNTIL;
				case "IDENTIFIER":
					return Token_Class.IDENTIFIER;
				case "ASSIGN":
					return Token_Class.ASSIGN;
				case "READ":
					return Token_Class.READ;
				case "WRITE":
					return Token_Class.WRITE;
				case "LESSTHAN":
					return Token_Class.LESSTHAN;
				case "EQUAL":
					return Token_Class.EQUAL;
				case "PLUS":
					return Token_Class.PLUS;
				case "MINUS":
					return Token_Class.MINUS;
				case "MULT":
					return Token_Class.MULT;
				case "DIV":
					return Token_Class.DIV;
				case "OPENBRACKET":
					return Token_Class.OPENBRACKET;
				case "CLOSEDBRACKET":
					return Token_Class.CLOSEDBRACKET;
				case "NUMBER":
					return Token_Class.NUMBER;
				default:
					return Token_Class.ERROR;
			}


		}

		private void chooseSourceCode_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Text files (*.txt) | *.txt";
				var result = openFileDialog.ShowDialog();

				if (result == DialogResult.Cancel)
				{
					MessageBox.Show("No File was Choosen");
				}
				else
				{
					using (StreamReader reader = new StreamReader(openFileDialog.FileName))
					{
						inputRichBox.Text = reader.ReadToEnd();
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void chooseTokens_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Text files (*.txt) | *.txt";
				var result = openFileDialog.ShowDialog();

				if (result == DialogResult.Cancel)
				{
					MessageBox.Show("No File was Choosen");
				}
				else
				{
					using (StreamReader reader = new StreamReader(openFileDialog.FileName))
					{
						inputRichBox.Text = reader.ReadToEnd();
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}

