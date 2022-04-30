using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurlyBracesProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> st = new Stack<char>();
            string braces = Console.ReadLine();
            char[] array = braces.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]=='{'||array[i]=='['||array[i]=='(')
                {
                    st.Push(array[i]);
                }
                if (array[i]=='}'||array[i]==']'||array[i]==')')
                {
                    st.Pop();
                }
            }
            if (st.Count==0)
            {
                Console.WriteLine("Balanced");
            }
            else
            {
                Console.WriteLine("Not balaced");
            }
        }
    }
}
