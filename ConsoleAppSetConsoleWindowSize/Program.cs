using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSetConsoleWindowSize
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 40; i++)
            {
                Console.SetWindowSize(i, i);
                System.Threading.Thread.Sleep(50);
            }

            Console.ReadLine();
        }
    }
}
