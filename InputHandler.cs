using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public static class InputHandler
    {
        public static string OnWord(string word)
        {
            Console.WriteLine("OnWord Called");
            return "OnWord";
        }

        public static string OnNumber(string num)
        {
            Console.WriteLine("OnNumber Called");
            return "OnNumber";
        }

        public static string OnJunk(string junk)
        {
            Console.WriteLine("OnJunk Called");
            return "OnJunk";
        }
    }
}
