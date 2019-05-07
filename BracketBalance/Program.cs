using System;
using System.Collections.Generic;
using System.Linq;

namespace BracketBalance
{
    public class Brackets
    {
        public static bool IsBracketBalanced(string s)
        {
            string brackets = "(){}[]<>";
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; ++i)
            {
                char c = s.ElementAt(i);
                int ind = brackets.IndexOf(c);
                if (ind >= 0)
                {
                    if (ind % 2 != 0)
                    {
                        if (st.Count == 0)
                            return false;
                        char last_bracket = st.Pop();
                        if (last_bracket != brackets[ind - 1])
                            return false;
                    }
                    else
                        st.Push(c);
                }
            }
            return st.Count == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a line with brackets:");
            string s = Console.ReadLine();
            if (IsBracketBalanced(s))
                Console.WriteLine("Brackets balanced - OK");
            else
                Console.WriteLine("Brackets not balanced");
            Console.Write("Press Enter ... ");
            Console.ReadKey();
        }
    }
}