using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_In_C_
{
    internal class Calculator
    {
        public int a,b;
        public void Add()
        {
            Console.WriteLine($"Addition Result = {a+b}");
        }
        public void Subtract()
        {
            Console.WriteLine($"Subtract Result = {a - b}");

        }
    }
}
