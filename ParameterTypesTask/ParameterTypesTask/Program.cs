using System;
using System.Drawing;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParameterTypesTask
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            // p.Add2Num();
            //p.Add2Number(20,30);

            // 1.
            //p.sum();
            //int sum = p.sum(10);
            //Console.WriteLine(sum);

            //int sum = p.sum();
            //Console.WriteLine(sum);

            //2.
            // p.Factorial()

            //3.
            //Console.WriteLine("Enter a digit number:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int result = p.sumdigit(n);

            //Console.WriteLine("Output = " + result);

            //p.sum();

            //p.sum(123);

            // int sum= p.sum();
            //Console.WriteLine(sum);

            //int sum = p.sumdigit(123);
            //Console.WriteLine(sum);

            //4.
            //p.LcmHcf();

            //p.LcmHcf(4, 10);

            int result = p.LcmHcf();
            Console.WriteLine(result);


            //5. 
            //Console.WriteLine("Enter the Radius of Circle");
            //double r = Convert.ToDouble(Console.ReadLine());
            //double result = p.CircleArea(r);
            //Console.WriteLine($"Output = {result}");

            //Console.WriteLine("Enter the length of Rectangle");
            //double l = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the width of Rectangle");
            //double w = Convert.ToDouble(Console.ReadLine());
            //double result = p.RectangleArea(l,w);
            //Console.WriteLine($"Output = {result}");

            //Console.WriteLine("Enter the Base of Triangle");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the height of triangle");
            //double h = Convert.ToDouble(Console.ReadLine());
            //double result = p.TriangleArea(b, h);
            //Console.WriteLine($"Output = {result}");


            //6.
            //Console.WriteLine("Enter a number.. ");
            //int n= Convert.ToInt32(Console.ReadLine());
            //bool result = p.evenodd(n);

            //if (result)
            //    Console.WriteLine("Number is Even");
            //else
            //    Console.WriteLine("Number is Odd");


            //Console.WriteLine("Enter a number.. ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //bool result = p.prime(n);

            //if (result)
            //    Console.WriteLine("Number is prime");
            //else
            //    Console.WriteLine("Number is Non-Prime");

        }

        //wap to add 2 number..
        //No return type No parameters..
        //void Add2Num()
        //{
        //    //input-> processing ->output
        //    Console.WriteLine("Enter 2 Number...");
        //    int n1=Convert.ToInt32(Console.ReadLine());
        //    int n2=Convert.ToInt32(Console.ReadLine());
        //    int result = n1 + n2;
        //    Console.WriteLine($"Output= {result}");
        //}

        //No return type with parameters...
        //void Add2Number(int a, int b)
        //{
        //    int res = a + b;
        //    Console.WriteLine($"Result={res}");

        //}

        //Q1.Create a function to calculate the sum of all numbers from 1 to N and display the result.

        //void sum()
        //{
        //    Console.WriteLine("Enter N Number...");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        sum = sum + i;
        //    }
        //    Console.WriteLine($"Output = {sum}");
        //}

        //void sum(int n)
        //{

        //    int sum = 0;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        sum = sum + i;
        //    }
        //    Console.WriteLine(sum);

        //int sum(int n)
        //{

        //    int sum = 0;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        sum = sum + i;
        //    }
        //   return sum;

        //int sum()
        //{
        //    Console.WriteLine("Enter a Number");
        //    int n= Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        sum = sum + i;
        //    }
        //    return sum;

        //Q2.Create a function to calculate the factorial of a given number and display the result.
        //void Factorial()
        //{
        //    Console.WriteLine("Enter A Number..");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int fact = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        fact = fact * i;

        //    }
        //    Console.WriteLine($"Factorial = {fact}");

        //}


        //Parameters & Return Values

        //Q3.Create a function that accepts a number and returns the sum of its digits.

        //int sumdigit(int n)
        //{
        //    int sum = 0;
        //    for (; n > 0; n = n / 10)
        //    {
        //        int digit = n % 10;
        //        sum = sum + digit;
        //    }
        //    return sum;  
        //}




        //void sum()
        //{
        //    Console.WriteLine("Enetr a Number");
        //    int n=Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for(int i= 1 ;n>0 ;n=n/10)
        //    {
        //         int digit = n % 10;
        //        sum = sum + digit;
        //    }
        //    Console.WriteLine($"Output = {sum}");
        //}

        //void sum(int n)
        //{
        //    int sum = 0;
        //    for (int i=1;n>0 ;n=n/10 )
        //    {
        //        int digit = n % 10;
        //        sum = sum + digit;
        //    }
        //    Console.WriteLine(sum);
        //}

        //int sum()
        //{
        //    Console.WriteLine("Enter a number");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for (int i = 1; n > 0; n = n / 10)
        //    {
        //        int digit = n % 10;
        //        sum = sum + digit;
        //    }
        //    return sum;
        //}


        //Q4.Create a function that accepts two numbers and returns their GCD and LCM.

        //No return type No parameters
        //void LcmHcf()
        //{
        //    Console.WriteLine("Enter all 2 numbers to calculate Lcm and Hcf..");
        //    int n1= Convert.ToInt32(Console.ReadLine());
        //    int n2= Convert.ToInt32(Console.ReadLine());
        //    int hcf = 1;
        //    for (int i=1 ; i<=n1 && i <= n2; i++)
        //    {
        //        if(n1%i==0 && n2 % i == 0)
        //        {
        //            hcf = i;
        //        }
        //    }
        //    Console.WriteLine($"HCF = {hcf} AND LCM = {n1*n2/hcf}")

        //}

        //No return type with parameters.
        //void LcmHcf(int n1 , int n2)
        //{
        //    int hcf = 1;
        //    for(int i=1; i<=n1 && i <= n2; i++)
        //    {
        //        if(n1%i==0 && n2 % i == 0)
        //        {
        //            hcf= i;
        //        }
        //    }
        //    Console.WriteLine($"HCF = {hcf} AND LCM = {n1*n2/hcf}");

        //}

        //return Type with no parameters..
        int LcmHcf()
        {
            Console.WriteLine("Enter all 2 numbers to calculate Lcm and Hcf..");
                int n1= Convert.ToInt32(Console.ReadLine());
                int n2= Convert.ToInt32(Console.ReadLine());
                int hcf = 1;
                for (int i=1 ; i<=n1 && i <= n2; i++)
                {
                    if(n1%i==0 && n2 % i == 0)
                   {
                        hcf = i;
                    }
                }
                     return hcf;
        }











        //Different Return Types 

        //Q5.Create separate functions to calculate the area of a circle, rectangle, and triangle using appropriate return types.
        // double CircleArea(double r)
        //{
        //    double area = 3.14 * r * r;
        //    return area;
        //}

        //double RectangleArea(double l, double h)
        //{
        //    double area = l*h;
        //    return area;
        //}

        //double TriangleArea(double b, double h)
        //{
        //    double area = (b * h)/2;
        //    return area;
        //}


        //Q6.Create functions that return bool values to check Even/Odd, Prime, and Perfect Number.
        //bool evenodd(int n)
        //{

        //    if (n % 2 == 0)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        //bool prime(int n)
        //{
        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            return false;
        //        }

        //    }
        //    return true;
        //}






    }
    }
