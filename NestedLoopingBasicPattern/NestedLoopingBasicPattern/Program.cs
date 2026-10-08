using System.Globalization;
using System.IO.Pipelines;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NestedLoopingBasicPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Section A – C# Number, Loop & Special Number Questions

            //Question 1.Print numbers from 1 to N
            //int n;
            // Console.WriteLine("Enter a number..");
            // n = Convert.ToInt32(Console.ReadLine());
            // for (int i=1;i<=n;i++)
            // {
            //     Console.WriteLine(i);
            // }

            //Question 2.Print all even numbers from 1 to N
            //int n;
            //Console.WriteLine("Enter a Number and see your Even Number...");
            //n=Convert.ToInt32(Console.ReadLine());
            //for (int i=1;i<=n;i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //Question 3.Print all odd numbers from 1 to N.
            //int n;
            //Console.WriteLine("Enter a Number and see your Odd Number...");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}


            //Question 4.Find the sum of numbers from 1 to N
            //int n;
            //Console.WriteLine("Enter a Number and find the sum of Numbers...");
            //n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i <=n; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine($"Sum = {sum}");


            //Question 5.Find the factorial of a given number
            //Console.WriteLine("Enter the AND Find the Factorial");
            //int n=Convert.ToInt32(Console.ReadLine());
            //int fact = 1;
            //for (int i = 1; i <= n; i++)
            //{ 
            //    fact=fact*i;
            //}
            //Console.WriteLine($"Factorial = {fact}");


            //Question 6.Count the number of digits in a given number.
            //Console.WriteLine("Enter a Number and Find the numbe rof digit..");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (; n != 0; n = n / 10)
            //{
            //    count++;
            //}
            //Console.WriteLine($"Total digit = {count}");


            //Question 7.Find the sum of digits of a given number.
            //Console.WriteLine("Enter a Number and Find the sum of digit of number..");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (; n != 0; n = n / 10)
            //{
            //    sum = sum + n % 10;
            //}
            //Console.WriteLine($"Total digit ka sum = {sum}");


            //Question 8.Reverse a given number.
            //Console.WriteLine("Enter a number:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int reverse = 0;
            //for (; n != 0; n = n / 10)
            //{
            //    int digit = n % 10;//last digit 
            //    reverse = reverse * 10;
            //    reverse = reverse + digit;
            //}
            //Console.WriteLine("Reverse Number is  = " + reverse);



            //Question 9.Check whether a given number is a palindrome
            //Console.WriteLine("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int original = n;
            //int reverse = 0;
            //for (; n != 0; n = n / 10)
            //{
            //    int digit = n % 10;
            //    reverse = reverse * 10;
            //    reverse = reverse + digit;
            //}
            //if (original == reverse)
            //{
            //    Console.WriteLine("Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Not Palindrome");
            //}



            //.Question 10.Find the largest digit in a given number.
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int largest = 0;
            //for (; n != 0; n = n / 10)
            //{
            //    int digit = n % 10;
            //    if (digit > largest)
            //    {
            //        largest = digit;
            //    }
            //}
            //Console.WriteLine("Largest digit = " + largest);



            //Question 11.Check whether a given number is prime
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        count++;
            //    }
            //}
            //if (count == 2)
            //{
            //    Console.WriteLine("Prime Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not Prime Number");
            //}





            //Section B – Easy Pattern Questions
            //Question 21.Print the above star pattern using nested loop.
            //*
            //**
            //***
            //****
            //*****
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Question 22.Print the above reverse star pattern using nested loop.

            //*****
            //****
            //***
            //**
            //*
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Question 23.Print the above  star square pattern using nested loop.

            //*****
            //*****
            //*****
            //*****
            //*****

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j= 1; j <= 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Question 24.Print the above  number  pattern using nested loop.

            //1
            //12
            //123
            //1234
            //12345
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //Question 25.Print the above reverse number  pattern using nested loop.

            //12345
            //1234
            //123
            //12
            //1

            //for (int i = 5; i >= 1; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}


            //Question 26.Print the above  number  pattern using nested loop.
            //1
            //22
            //333
            //4444
            //55555
            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j=1;j<=i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}


            //Question 27.Print the above  number  pattern using nested loop.
            //A
            //AB
            //ABC
            //ABCD
            //ABCDE

            //for(int i = 1; i <= 5; i++)
            //{
            //    for (int j=1;j <=i;j++)
            //    {
            //        Console.Write((char)(64+j));
            //    }
            //    Console.WriteLine();
            //}

            //Question 28.Print the above  number  pattern using nested loop.

            //A
            //BB
            //CCC
            //DDDD
            //EEEEE
            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write((char)(64+i));
            //    }
            //    Console.WriteLine();
            //}


            //Question 29.Print the above  number  pattern using nested loop.
            //1
            //22
            //333
            //4444
            //55555
            //666666
            //for (int i = 1; i <= 6; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}




            //Console.WriteLine("Enter numbber");
            //int n= Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (; n != 0; n = n / 10) 
            //{
            //   count++;

            //}
            //Console.WriteLine(count);


            //Console.WriteLine("Enter numbber");
            //int n= Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for(;n!=0 ;n=n/10)
            //{
            //    int Digit= n % 10;
            //    sum = sum + Digit;

            //}
            //Console.WriteLine(sum);



            Console.WriteLine("Enter number");

            int n = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            for (; n != 0; n = n / 10)
            {
                int digit = n % 10;
                reverse = reverse * 10 + digit;

            }

            Console.WriteLine("Final Reverse = " + reverse);

        }
    }
}
