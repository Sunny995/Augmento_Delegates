using System;
using System.Text.RegularExpressions;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleReder c = new ConsoleReder();
            c.Checkinput();
        }
    }

    public class ConsoleReder
    {
        public delegate string NewDelegate(string word);
        NewDelegate d1 = new NewDelegate(InputHandler.OnWord);
        NewDelegate d2 = new NewDelegate(InputHandler.OnNumber);
        NewDelegate d3 = new NewDelegate(InputHandler.OnJunk);

        public  string Checkinput()
        {
            var result= Run(d1,d2,d3);
            return result;
        }
        public  string Run(NewDelegate d1, NewDelegate d2, NewDelegate d3) 
        {
            var input = GetNextName();

            if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                var result = d1("OnWord");
                return result;
            }
            else if (Regex.IsMatch(input, @"^-?[0-9][0-9,\.]+$"))
            {
                var result = d2("OnNumber");
                return result;
            }
            else 
            {
                var result = d3("OnJunk");
                return result;
            }

        }

        public virtual string GetNextName()
        {
            return Console.ReadLine();
        }
    }

    public class InputReader : ConsoleReder
    {
       
        private string[] inputs = new string[] { "Hello"};
        private int index = 0;
        public override string GetNextName()
        {
            return inputs[index++];
        }
    }
}
