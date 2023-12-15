using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Parser_Final_Project
{
	public partial class SyntaxTreeForm : Form
	{
		public SyntaxTree SyntaxTree { get; set; }
		public SyntaxTreeForm(SyntaxTree syntaxTree)
		{
			this.SyntaxTree = syntaxTree;
			InitializeComponent();
			panel1.AutoScrollMinSize = new Size(10000, 5000);
		

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			//DrawTree(e.Graphics, SyntaxTree.Root, 100, 50);
			

		}


		private int DrawTree(Graphics g, Node node, int x, int y)
		{
			// Draw the current node
			int nodeWidth = 70;
			int nodeHeight = 40;
			g.FillEllipse(Brushes.LightBlue, x - nodeWidth / 2, y - nodeHeight / 2, nodeWidth, nodeHeight);
			g.DrawEllipse(Pens.Black, x - nodeWidth / 2, y - nodeHeight / 2, nodeWidth, nodeHeight);
			g.DrawString(node.Token?.lex, Font, Brushes.Black, new PointF(x - g.MeasureString(node.Token?.lex, Font).Width / 2, y - nodeHeight / 3));

			int maxX = x; // Initialize maxX with the current X position
						  // Draw lines connecting to children
			int childY = y + 70;
			int childX = x - (node.Children.Count * 50) / 2;


			foreach (var child in node.Children)
			{
				g.DrawLine(Pens.Black, x, y + nodeHeight / 2, childX, childY - nodeHeight / 2);
				int childMaxX = DrawTree(g, child, childX, childY);
				childX = childMaxX + 90;
				maxX = Math.Max(maxX, childX); // Update maxX based on the child's maxX
			}

			// Draw line connecting to the next node
			if (node.Next != null)
			{
				int nextX = maxX + 50 ; // Use the updated maxX for the next node line
				int nextY = y;
				g.DrawLine(Pens.Black, x + nodeWidth / 2, y, nextX, nextY);
				maxX = DrawTree(g, node.Next, nextX, nextY);
			}

			return maxX; // Return the updated maxX for the current level
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			DrawTree(e.Graphics, SyntaxTree.Root, 100, 50);
		}

		private void SyntaxTreeForm_Load(object sender, EventArgs e)
		{
			pictureBox1.BackColor = Color.White;
			// Connect the Paint event of the PictureBox to the event handler method.
			pictureBox1.Paint += new PaintEventHandler(this.pictureBox1_Paint);

		

		}

		
	}
}


/*
 * 	private void DrawTree(Graphics g, Node node, int x, int y)
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
*/