using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser_Final_Project
{
	public partial class SyntaxTreeForm : Form
	{
        public SyntaxTree SyntaxTree { get; set; }
        public SyntaxTreeForm(SyntaxTree syntaxTree)
		{
			this.SyntaxTree = syntaxTree;
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			DrawTree(e.Graphics, SyntaxTree.Root, 100, 100);

		}
		private void DrawNode(Graphics g, Node node, int x, int y)
		{
			//Pen pen = new Pen(Color.Red);
			//g.DrawRectangle(pen, 100, 100, 100, 100);
			int nodeWidth = 40;
			int nodeHeight = 20;
			g.FillEllipse(Brushes.LightBlue, x - nodeWidth / 2, y - nodeHeight / 2, nodeWidth, nodeHeight);
			g.DrawEllipse(Pens.Black, x - nodeWidth / 2, y - nodeHeight / 2, nodeWidth, nodeHeight);
			g.DrawString(node.Token.lex, Font, Brushes.Black, new PointF(x - g.MeasureString(node.Token.lex, Font).Width / 2, y - nodeHeight / 2));
		}
		private void DrawTree(Graphics g, Node node, int x, int y)
		{
			// Draw the current node
			int nodeWidth = 70;
			int nodeHeight = 40;
			g.FillEllipse(Brushes.LightBlue, x - nodeWidth / 2, y - nodeHeight / 2, nodeWidth, nodeHeight);
			g.DrawEllipse(Pens.Black, x - nodeWidth / 2, y - nodeHeight / 2, nodeWidth, nodeHeight);
			//string value = node.Token.token_type.ToString() + "\n" + "("+ node.Token.lex+")";
			g.DrawString(node.Token.lex, Font, Brushes.Black, new PointF(x - g.MeasureString(node.Token.lex, Font).Width / 2, y - nodeHeight/3 ));

			// Draw lines connecting to children
			int childY = y + 90;
			int childX = x - (node.Children.Count * 50)/2;

			foreach (var child in node.Children)
			{
				g.DrawLine(Pens.Black, x, y + nodeHeight / 2, childX, childY - nodeHeight / 2);
				DrawTree(g, child, childX, childY);
				childX += 90;
			}
			
			// Draw line connecting to the next node
			if (node.Next != null)
			{
				int nextX = x + 200; // Adjust the x-position for the next node line
				int nextY = y;
				g.DrawLine(Pens.Black, x+nodeWidth/2, y , nextX, nextY );
				DrawTree(g, node.Next, nextX, nextY);
			}
		}

	}
}
