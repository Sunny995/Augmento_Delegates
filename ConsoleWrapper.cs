using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class ConsoleWrapper : IConsole
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }

    public interface IConsole
    {
        void WriteLine(string message);
        string ReadLine();
    }
}
