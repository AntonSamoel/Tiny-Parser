using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Parser_Final_Project
{
    public class Parser
    {
        private readonly List<Token> tokens;

        //private Node head;
        public SyntaxTree _SyntaxTree { get; set; }
        private int current;
        public Parser(List<Token> tokens)
        {
            this.tokens = tokens;
            current = 0;
            _SyntaxTree = new();
            // head = _SyntaxTree.Root;
        }

        public void Program()
        {
            _SyntaxTree.Root = StatementSequance();
        }
        private Node StatementSequance()
        {
            Node head, temp;

           head = Statement();

           while (current < tokens.Count && tokens[current].token_type == Token_Class.SEMICOLON)
           {
               Match(tokens[current].token_type);

               temp = head;

               while (temp.Next != null)
               {
                   temp = temp.Next;
               }

               temp.Next = Statement();
           }
           return head;
        }
        private Node Statement()
        {
            Node node = new();
            if (current < tokens.Count && tokens[current].token_type == Token_Class.IF)
            {
                node = If_Stmt(tokens[current]);
            }
            else if (current < tokens.Count && tokens[current].token_type == Token_Class.REPEAT)
            {
                node = Repeat(tokens[current]);
            }
            else if (current < tokens.Count && tokens[current].token_type == Token_Class.IDENTIFIER)
            {
                node = Assign(tokens[current]);
            }
            else if (current < tokens.Count && tokens[current].token_type == Token_Class.READ)
            {
                node = Read(tokens[current]);
            }
            else if (current < tokens.Count && tokens[current].token_type == Token_Class.WRITE)
            {
                node = Write(tokens[current]);
            }
            return node;
        }
        private Node If_Stmt(Token token)
        {
            Node node = new(token);
            Match(tokens[current].token_type);

            node.Children.Add(Exp());
            node.Children.Add(ThenIf());

            Match(tokens[current].token_type);
            //node.Children.Add(ElseIf());

            return node;
        }

        private Node Repeat(Token token)
        {
            Node node = new(token);
            Match(tokens[current].token_type);

            node.Children.Add(StatementSequance());

            Match(tokens[current].token_type);

            node.Children.Add(Exp());

            return node;
        }
        private Node Assign(Token token)
        {
            Node node = new(token);

            Match(tokens[current].token_type);
            Match(tokens[current].token_type);
            Node main = new Node(new Token() { token_type = Token_Class.ASSIGN ,lex= "assign" });
            //main.Children.Add(node);
            main.Token.lex2 = node.Token.lex;
			main.Children.Add(Exp());

            return (main);
        }
        private Node Read(Token token)
        {
            Node node = new(token);

            Match(tokens[current].token_type);

            //node.Children.Add(new Node(tokens[current]));
            node.Token.lex2 = tokens[current].lex;


			Match(tokens[current].token_type);

            return node;
        }
        private Node Write(Token token)
        {
            Node node = new(token);

            Match(tokens[current].token_type);

            node.Children.Add(Exp());

            return node;
        }

        private Node Exp()
        {
            Node node = SimpleExp();

            if (current < tokens.Count && IsComparison(tokens[current].token_type))
            {
                Node newNode = new(tokens[current]);

                Match(tokens[current].token_type);

                newNode.Children.Add(node);

                newNode.Children.Add(SimpleExp());

                node = newNode;
            }

            return node;
        }
        private Node ThenIf()
        {
            Match(tokens[current].token_type);

            return StatementSequance();
        }
       /* private Node ElseIf()
        {
            Match(tokens[current].token_type);

            return StatementSequance();
        }*/
        private Node SimpleExp()
        {
            Node temp = Term();

            while (current < tokens.Count && IsAddOp(tokens[current].token_type))
            {
                Node newNode = new(tokens[current]);
                Match(tokens[current].token_type);
                newNode.Children.Add(temp);
                newNode.Children.Add(Term());
                temp = newNode;
            }
            return temp;
        }
        private Node Term()
        {
            Node temp = Factor();

            while (current < tokens.Count && IsMulOp(tokens[current].token_type))
            {
                Node newNode = new(tokens[current]);
                Match(tokens[current].token_type);
                newNode.Children.Add(temp);
                newNode.Children.Add(Factor());
                temp = newNode;
            }
            return temp;
        }
        private Node Factor()
        {
            Node temp = new();

            if (current < tokens.Count && tokens[current].token_type == Token_Class.OPENBRACKET)
            {
                Match(tokens[current].token_type);

                temp = Exp();

                Match(tokens[current].token_type);
            }
            else if (current < tokens.Count && tokens[current].token_type == Token_Class.IDENTIFIER || tokens[current].token_type == Token_Class.NUMBER)
            {
                temp.Token = tokens[current];
                Match(tokens[current].token_type);
            }

            return temp;
        }
        private void Match(Token_Class token)
        {
            if (current < tokens.Count && tokens[current].token_type == token)
            {
                current++;
            }
        }
        private bool IsComparison(Token_Class token)
        {
            return token == Token_Class.EQUAL || token == Token_Class.LESSTHAN;
        }
        private bool IsAddOp(Token_Class token)
        {
            return token == Token_Class.PLUS || token == Token_Class.MINUS;
        }
        private bool IsMulOp(Token_Class token)
        {
            return token == Token_Class.MULT || token == Token_Class.DIV;
        }
    }
}
