using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblems
{
    class BalancedParentheses
    {
        string expresion = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
        public void CheckBalancedParentheses()
        {
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i] == '(')
                {
                    stack.Push("(");
                }
                if (expresion[i] == ')')
                {
                    stack.Pop();
                }
            }
            Console.WriteLine("Stack data is :");
            stack.ShowStack();
            if (stack.IsEmpty())
                Console.WriteLine("Arithmetic expression is balanced");
            else
                Console.WriteLine("Arithmetic expression is not balanced");
        }
    }
}
