using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_In_C_
{
    internal class Maths
    {
        public int Add()
        {
            int n1,n2;
            Console.WriteLine("Enter 2 number");
            n1= Convert.ToInt32(Console.ReadLine());
            n2= Convert.ToInt32(Console.ReadLine());
            return n1 + n2;
        }

        public int Sub()
        {
            int n1, n2;
            Console.WriteLine("Enter 2 number");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            return n1 - n2;
        }

        //public int(int a, int b)
        //{
            
        //    return n1 +n2;
        //}
        //   public double(double a, double b)
        //{
            
        //    return n1 +n2;
        //}
    }
}
