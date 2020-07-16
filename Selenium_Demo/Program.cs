using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Selenium_Demo
{
    class Program
    {
        bool isFlag = false;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.isFlag = true;

            if (p.isFlag)
            {
                Console.WriteLine("False");
            }
        }
    }
}
