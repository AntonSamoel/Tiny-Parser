using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Parser_Final_Project
{
   public class SyntaxTree
    {
        public Node Root { get; set; }
        public SyntaxTree()
        {
            Root = new();
        }
    }
    public class Node
    {
        public Token? Token { get; set; }
        public Node? Next { get; set; }
        public List<Node> Children { get; set; }

        public Node(Token token)
        {
            Token = token;
            Next = null;
            Children = new();
        }
        public Node()
        {
            Token = null;
            Next = null;
            Children = new();
        }
    }
}
