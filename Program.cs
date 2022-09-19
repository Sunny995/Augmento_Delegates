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
        public delegate string NewDelegate();
        public  string OnWord()
        {
            Console.WriteLine("OnWord Called");
            return "OnWord";
        }

        public  string OnNumber() 
        {
            Console.WriteLine("OnNumber Called");
            return "OnNumber";
        }

        public  string OnJunk()
        {
            Console.WriteLine("OnJunk Called");
            return "OnJunk";
        }

        public  string Checkinput()
        {
            NewDelegate d1 = new NewDelegate(OnWord);
            NewDelegate d2 = new NewDelegate(OnNumber);
            NewDelegate d3 = new NewDelegate(OnJunk);
            var result= Run(d1,d2,d3);
            return result;
        }
        public  string Run(NewDelegate d1, NewDelegate d2, NewDelegate d3) 
        {
            var input = GetNextName();

            if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
               var result =  d1();
                return result;
            }
            else if (Regex.IsMatch(input, @"^-?[0-9][0-9,\.]+$"))
            {
                var result = d2();
                return result;
            }
            else 
            {
                var result = d3();
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
