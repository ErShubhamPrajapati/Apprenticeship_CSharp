using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingExercise
{
    internal class LoopingQuestion
    {
        static void Main(string[] args)
        {
            //Factorial of any number 
            //Console.WriteLine("Enter A Numbar");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //for(int i =1; i <= n; i++)
            //{
            //    factorial = factorial * i;
            //}
            //Console.WriteLine(factorial );


            //Fibonacci Series
            Console.WriteLine("Enter A Number");
            int n= Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            for (int i=1;i<=n;i++)
            {
                Console.WriteLine(a + " ");
                int c = a + b;
                a = b;
                b=c;
            }



        }
     }
}
