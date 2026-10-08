using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParameterTypeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 01 
            Program p = new Program();
            //Task 01 
            // p.checkdivisible();
            //p.chekdivisible(12, 2);
            //bool result= p.checkdivisible();
            //Console.WriteLine(result);
            //bool result = p.CheckDivisible(12, 2);
            //Console.WriteLine(result);

            //Task 02
            //p.Greatest();
            //p.Greatest(3, 5, 2);
            //int result = p.Greatest();
            //Console.WriteLine(result);
            //int result = p.Greatest(10,25,15);
            //Console.WriteLine(result);

            //Task 03
            //p.LeapYear()
            //p.LeapYear(2024);
            //bool result = p.LeapYear();
            //Console.WriteLine(result);
            //bool result = p.LeapYear(2024);
            //Console.WriteLine(result);

            //Task 04
            //p.Percentage();
            //p.Percentage(80, 75, 90, 85, 70);
            //double result = p.Percentage();
            //Console.WriteLine("Percentage = " + result);
            //double result = p.Percentage(80, 75, 90, 85, 70);
            //Console.WriteLine("Percentage = " + result);

            //Task 05
            //p.Table();
            //p.Table(5);
            //string result = p.Table()
            //Console.WriteLine(result);
            //string result = p.Table(7);
            //Console.WriteLine(result);

            //Task 06
            //p.Factorial();
            //p.Factorial(5);
            //int result = p.Factorial();
            //Console.WriteLine(result);
            //int result = p.Factorial(4);
            //Console.WriteLine(result);

            //Task 07
            //p.Prime();
            //p.Prime(5);
            //bool result = p.Prime();
            //Console.WriteLine(result);
            // bool result = p.Prime(5);
            //Console.WriteLine(result);

            //Task 08
            //p.reverse();
            //p.reverse(12345);
            //int result = p.reverse();
            //Console.WriteLine(result);
            //int result = p.reverse(12345);
            //Console.WriteLine(result);

            //Task 09
            //p.sumdigit();
            //p.sumdigit(123);
            // int result = p.sumdigit();
            //Console.WriteLine(result);
            //int result = p.sumdigit(123);
            //Console.WriteLine(result);

            //Task 10
            //p.Totalnumber();
            //p.Totalnumber(123423);
            //int result = p.Totalnumber();
            //Console.WriteLine(result);
            //int result = p.Totalnumber(12321);
            //Console.WriteLine(result);

            //Task 11
            //p.palindrome();
            //p.palindrome(121);
            //bool result = p.palindrome();
            //Console.WriteLine(result);
            //bool result = p.palindrome(121);
            //Console.WriteLine(result);

            //Task 12
            //p.GCD();
            //p.GCD(12, 18);
            //int result = p.GCD();
            //Console.WriteLine(result);
            //int resule = p.GCD(12,18);
            //Console.WriteLine(resule);

            //Task 13
            //p.LCM();
            //p.LCM(12,18);
            //int result = p.LCM();
            //Console.WriteLine(result);
            //int result = p.LCM(12,18);
            //Console.WriteLine(result);

            //Task 14
            //p.Armstrong();
            //p.Armstrong(153);
            //bool result = p.Armstrong();
            //Console.WriteLine(result);
            //bool result= p.Armstrong(153);
            //Console.WriteLine(result);

            //Task 15
            //p.PerfectNumber();
            //p.PerfectNumber(6);
            //bool result = p.PerfectNumber();
            //Console.WriteLine(result);
            //bool result = p.PerfectNumber(6);
            //Console.WriteLine(result);

            //Task 16
            //p.Evendigit();
            //p.Evendigit(23166);
            //int result = p.Evendigit();
            //Console.WriteLine(result);
            //int result = p.Evendigit(23166);
            //Console.WriteLine(result);

            //Task 17
            //p.Odddigit();
            //p.Odddigit(13582);
            //int result = p.Odddigit();
            //Console.WriteLine(result);
            //int result =p.Odddigit(13582);
            //Console.WriteLine(result);

            //Task 18
            //p.EvenOdd();
            //p.EvenOdd(1254895);
            //string result = p.EvenOdd();
            //Console.WriteLine(result);
            //string result = p.EvenOdd(1254895);
            //Console.WriteLine(result);


            //Task 19
            //p.Largestdigit();
            //p.Largestdigit(17394556);
            //int result = p.Largestdigit();
            //Console.WriteLine(result);
            //int result = p.Largestdigit(17394556);
            //Console.WriteLine(result);

            //Task 20
            //p.Smallestdigit();
            //p.Smallestdigit(1963627);
            //int result = p.Smallestdigit();
            //Console.WriteLine(result);
            //int result = p.Smallestdigit(1963627);
            //Console.WriteLine(result);

        }

        //Task 01 
        //Create a UDF that accepts two numbers and checks whether the first number is completely divisible by the second number.
        //No return type No parameter
        //void checkdivisible()
        //{
        //    Console.WriteLine("Enter First Number");
        //    int n1= Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Second Number");
        //    int  n2= Convert.ToInt32(Console.ReadLine());
        //    if (n1 % n2 ==0)
        //    {
        //        Console.WriteLine("First number is completely divisible by second number.");

        //    }
        //    else
        //    {
        //        Console.WriteLine("First number is not completely divisible by second number.");

        //    }
        //}


        //No return type with parameter
        //void chekdivisible( int n1, int n2)
        //{
        //    if (n1 % n2 == 0)
        //    {
        //        Console.WriteLine("First Number is divisible by second number. ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("First Number is not completely divisible by second number. ");

        //    }
        //}

        //Return Type with No Parameter
        //bool checkdivisible()
        //{
        //    Console.WriteLine("Enter First Number");
        //    int n1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Second Number");
        //    int n2 = Convert.ToInt32(Console.ReadLine());
        //    if (n1 % n2 ==0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //return type with parameter

        //bool CheckDivisible(int n1, int n2)
        //{
        //    if (n1 % n2 == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //Task 02 ..
        //Create a UDF that accepts three integers and returns the greatest number.
        //No return Type  no parameter
        //void Greatest()
        //{
        //    Console.WriteLine("Enter 1st number");
        //    int n1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter 1st number");
        //    int n2 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter 1st number");
        //    int n3 = Convert.ToInt32(Console.ReadLine());
        //    if (n1 > n2 && n1 > n3)
        //    {
        //        Console.WriteLine("Greatest number = " + n1);

        //    }
        //    else if (n2 > n1 && n2 > n3)
        //    {
        //        Console.WriteLine("Greatest number = " + n2);

        //    }
        //    else
        //    {
        //        Console.WriteLine("Greatest number = " + n3);

        //    }
        //}

        //no return with parameter
        //void Greatest(int n1,int n2,int n3)
        //{
        //    if (n1 > n2 && n1 > n3)
        //    {
        //        Console.WriteLine("Greatest number = " + n1);

        //    }
        //    else if (n2 > n1 && n2 > n3)
        //    {
        //        Console.WriteLine("Greatest number = " + n2);

        //    }
        //    else
        //    {
        //        Console.WriteLine("Greatest number = " + n3);

        //    }
        //}

        //Return Type no parameter
        //int Greatest()
        //{
        //    Console.WriteLine("Enter 1st number");
        //    int n1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter 1st number");
        //    int n2 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter 1st number");
        //    int n3 = Convert.ToInt32(Console.ReadLine());
        //    if (n1 > n2 && n1 > n3)
        //    {
        //        return n1;

        //    }
        //    else if (n2 > n1 && n2 > n3)
        //    {
        //        return n2;
        //    }
        //    else
        //    {
        //        return n3;
        //       }
        //}

        //Return Type with parameter
        //int Greatest(int n1, int n2, int n3)
        //{
        //    if (n1 > n2 && n1 > n3)
        //    {
        //        return n1;
        //    }
        //    else if (n2 > n1 && n2 > n3)
        //    {
        //        return n2;
        //    }
        //    else
        //    {
        //        return n3;
        //    }
        //}

        //Task 03 
        //Create a UDF that accepts a year and returns whether it is a leap year or not.

        //no return no paramete
        //void LeapYear()
        //{
        //    Console.WriteLine("Enter year:");
        //    int year = Convert.ToInt32(Console.ReadLine());

        //    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        //    {
        //        Console.WriteLine("Leap Year");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not a Leap Year");
        //    }
        //}

        //no  return Type with parameter
        //void LeapYear(int year)
        //{
        //    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        //    {
        //        Console.WriteLine("Leap Year");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not a Leap Year");
        //    }
        //}

        //ReturnType no paramete
        //bool LeapYear()
        //{
        //    Console.WriteLine("Enter year:");
        //    int year = Convert.ToInt32(Console.ReadLine());

        //    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //bool LeapYear(int year)
        //{
        //    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //Task 04
        //Create a UDF that accepts marks of 5 subjects and returns the total percentage.

        //no return no parameter
        //void Percentage()
        //{
        //    Console.WriteLine("Enter marks of 5 subjects:");

        //    int m1 = Convert.ToInt32(Console.ReadLine());
        //    int m2 = Convert.ToInt32(Console.ReadLine());
        //    int m3 = Convert.ToInt32(Console.ReadLine());
        //    int m4 = Convert.ToInt32(Console.ReadLine());
        //    int m5 = Convert.ToInt32(Console.ReadLine());

        //    int total = m1 + m2 + m3 + m4 + m5;

        //    double percentage = (total / 500.0) * 100;

        //    Console.WriteLine("Total = " + total);
        //    Console.WriteLine("Percentage = " + percentage);
        //}

        //no return no with parameter
        //void Percentage(int m1, int m2, int m3, int m4, int m5)
        //{
        //    int total = m1 + m2 + m3 + m4 + m5;

        //    double percentage = (total / 500.0) * 100;

        //    Console.WriteLine("Total = " + total);
        //    Console.WriteLine("Percentage = " + percentage);
        //}

        //return type no parameter
        //double Percentage()
        //{
        //    Console.WriteLine("Enter marks of 5 subjects:");

        //    int m1 = Convert.ToInt32(Console.ReadLine());
        //    int m2 = Convert.ToInt32(Console.ReadLine());
        //    int m3 = Convert.ToInt32(Console.ReadLine());
        //    int m4 = Convert.ToInt32(Console.ReadLine());
        //    int m5 = Convert.ToInt32(Console.ReadLine());

        //    int total = m1 + m2 + m3 + m4 + m5;

        //    double percentage = (total / 500.0) * 100;

        //    return percentage;
        //}

        //return type with parameter
        //double Percentage(int m1, int m2, int m3, int m4, int m5)
        //{
        //    int total = m1 + m2 + m3 + m4 + m5;

        //    double percentage = (total / 500.0) * 100;

        //    return percentage;
        //}

        //Task 05
        //Create a UDF that accepts a number and prints its multiplication table from 1 to 10.

        //no return no paraeter
        //void Table()
        //{
        //    Console.WriteLine("Enter number:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(n + " x " + i + " = " + (n * i));
        //    }
        //}

        //no return with parameter
        //void Table(int n)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(n + " x " + i + " = " + (n * i));
        //    }
        //}

        //return type no parameter
        //string Table()
        //{
        //    Console.WriteLine("Enter number:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    string result = "";

        //    for (int i = 1; i <= 10; i++)
        //    {
        //        result += n + " x " + i + " = " + (n * i) + "\n";
        //    }

        //    return result;
        //}

        //return type with parameter
        //string Table(int n)
        //{
        //    string result = "";

        //    for (int i = 1; i <= 10; i++)
        //    {
        //        result += n + " x " + i + " = " + (n * i) + "\n";
        //    }

        //    return result;
        //}


        //Task 06
        //Create a UDF that accepts a number and returns its factorial.

        //no return no parameter
        //void Factorial()
        //{
        //    Console.WriteLine("Enter number:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int fact = 1;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        fact = fact * i;
        //    }

        //    Console.WriteLine("Factorial = " + fact);
        //}

        //no return with parameter
        //void Factorial(int n)
        //{
        //    int fact = 1;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        fact = fact * i;
        //    }

        //    Console.WriteLine("Factorial = " + fact);
        //}

        //return Type and no parameter
        //int Factorial()
        //{
        //    Console.WriteLine("Enter number:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int fact = 1;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        fact = fact * i;
        //    }

        //    return fact;
        //}

        //Return Type with parmeter
        //int Factorial(int n)
        //{
        //    int fact = 1;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        fact = fact * i;
        //    }

        //    return fact;
        //}


        // Task 07 
        //Create a UDF that accepts a number and returns whether it is prime or not.
        //not return no parameter
        //void Prime()
        //{
        //    Console.WriteLine("Enter a number:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            Console.WriteLine("Number is not prime");
        //        }
        //    }

        //    Console.WriteLine("Number is prime");
        //}

        //no return with parameter
        //void Prime(int n)
        //{
        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            Console.WriteLine("Number is not prime");
        //        }
        //    }

        //    Console.WriteLine("Number is prime");
        //}

        //return type no parameter
        //bool Prime()
        //{
        //    Console.WriteLine("Enter a number:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        //return type with parameter
        //bool Prime(int n)
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


        //Task 08
        //Create a UDF that accepts an integer and returns its reverse.
        //no  return no  parameter
        //void reverse()
        //{
        //    Console.WriteLine("Enter a number..");
        //    int n= Convert.ToInt32(Console.ReadLine());
        //    int rev = 0;    
        //    for(int i= n; i > 0 ;i = i/10 )
        //    {
        //        int digit = i % 10;
        //        rev = rev * 10 + digit;
        //    }
        //    Console.WriteLine(rev);


        //}

        //no return with parameter
        //void reverse( int n)
        //{    
        //    int rev = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        rev = rev * 10 + digit;
        //    }
        //    Console.WriteLine(rev);
        //}

        //return type no parameter
        //int reverse()
        //{
        //    Console.WriteLine("Enter a number");
        //    int n=Convert.ToInt32(Console.ReadLine());
        //    int rev = 0;
        //    for(int i = 0; i > n; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        rev = rev * 10 + digit;
        //    }
        //    return rev;
        //}

        //Return type with parameter
        //int reverse(int n)
        //{ 
        //    int rev = 0;
        //    for (int i = 0; i > n; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        rev = rev * 10 + digit;
        //    }
        //    return rev;
        //}


        //Task 09
        //Create a UDF that accepts a number and returns the sum of its digits.

        //no return type no parameter
        //void sumdigit()
        //{
        //    Console.WriteLine("Enter a number");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        sum = sum + digit;
        //    }
        //    Console.WriteLine(sum);

        //}

        //no return type with parameter
        //void sumdigit( int n)
        //{

        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        sum = sum + digit;
        //    }
        //    Console.WriteLine(sum);

        //}

        //return type with parameter
        //int sumdigit()
        //{
        //    Console.WriteLine("Enter a number");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        sum = sum + digit;
        //    }
        //        return sum;
        //}

        //return type with parameter
        //int sumdigit(int n)
        //{

        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        sum = sum + digit;
        //    }
        //    return sum;
        //}


        //Task 10
        // Create a UDF that accepts a number and returns the total number of digits.

        //no return type no parameter
        //void Totalnumber()
        //{
        //    Console.WriteLine("Enter a digit");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int digit = 0;
        //    for(int i = n; i > 0; i = i / 10)
        //    {
        //        digit = digit + 1;
        //    }
        //    Console.WriteLine(digit);
        //}

        //no return with parameter
        //void Totalnumber(int n)
        //{
        //    int digit = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        digit = digit + 1;
        //    }
        //    Console.WriteLine(digit);
        //}

        // return type no parameter
        //int Totalnumber()
        //{
        //    Console.WriteLine("Enter a digit");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int digit = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        digit = digit + 1;
        //    }
        //    return digit;
        //}

        //return type with parameter
        //int Totalnumber( int n)
        //{
        //    int digit = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        digit = digit + 1;
        //    }
        //    return digit;
        //}


        //Task 11
        // Create a UDF that accepts a number and returns whether it is a palindrome or not.

        //no return type no parameter
        //void palindrome()
        //{
        //    Console.WriteLine("Enter a number.");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int original = n;
        //    int reverse = 0;
        //    for(int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //         reverse = reverse * 10 + digit;
        //    }
        //    if (original == reverse)
        //    {
        //        Console.WriteLine($"{reverse} Number is pailndrome.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{reverse} Number is not pailndrome");
        //    }
        //}

        //no return type with parameter
        //void palindrome(int n)
        //{
        //    int original = n;
        //    int reverse = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        reverse = reverse * 10 + digit;
        //    }
        //    if (original == reverse)
        //    {
        //        Console.WriteLine($"{reverse} Number is pailndrome.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{reverse} Number is not pailndrome");
        //    }
        //}


        //return type no parameter

        //bool palindrome()
        //{
        //    Console.WriteLine("Enter a number.");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int original = n;
        //    int reverse = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        reverse = reverse * 10 + digit;
        //    }
        //    if (original == reverse)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //return type with parameter
        //bool palindrome( int n)
        //{
        //    int original = n;
        //    int reverse = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        reverse = reverse * 10 + digit;
        //    }
        //    if (original == reverse)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //Task 12
        // Create a UDF that accepts two integers and returns their GCD.

        //no return no parameter
        //void GCD()
        //{
        //    Console.WriteLine("Enter 1st nuber");
        //    int n1= Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter 2nd number");
        //    int n2= Convert.ToInt32(Console.ReadLine());

        //    int gcd = 1;
        //    for(int i = 1; i <= n1 && i <= n2; i++)
        //    {
        //        if (n1 % i == 0 && n2 % i == 0)
        //        {
        //            gcd = i;
        //        }
        //    }
        //    Console.WriteLine($"GCD = {gcd}");
        //}

        //no return with parameter
        //void GCD(int n1, int n2)
        //{
        //     int gcd = 1;
        //    for (int i = 1; i <= n1 && i <= n2; i++)
        //    {
        //        if (n1 % i == 0 && n2 % i == 0)
        //        {
        //            gcd = i;
        //        }
        //    }
        //    Console.WriteLine($"GCD = {gcd}");
        //}

        //return type no parameter
        //int GCD()
        //{
        //    Console.WriteLine("Enter 1st nuber");
        //    int n1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter 2nd number");
        //    int n2 = Convert.ToInt32(Console.ReadLine());

        //    int gcd = 1;
        //    for (int i = 1; i <= n1 && i <= n2; i++)
        //    {
        //        if (n1 % i == 0 && n2 % i == 0)
        //        {
        //            gcd = i;
        //        }
        //    }
        //    return gcd;
        //}

        //return type with parameter
        //int GCD( int n1, int n2)
        //{ 
        //    int gcd = 1;
        //    for (int i = 1; i <= n1 && i <= n2; i++)
        //    {
        //        if (n1 % i == 0 && n2 % i == 0)
        //        {
        //            gcd = i;
        //        }
        //    }

        //    return gcd;
        //}


        //Task13
        // Create a UDF that accepts two integers and returns their LCM.

        //no return no parameter
        //void LCM()
        //{
        //      Console.WriteLine("Enter 1st nuber");
        //        int n1 = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Enter 2nd number");
        //        int n2 = Convert.ToInt32(Console.ReadLine());
        //    int gcd = 1;
        //    for(int i =1; i <= n1 && i <= n2; i++)
        //    {
        //        if (n1 % i == 0 && n2 % i == 0)
        //        {
        //            gcd = i;
        //        }
        //    }
        //    int lcm = (n1 * n2) / gcd;
        //    Console.WriteLine(lcm);
        //}

        //no return with parameter
        //void LCM( int n1,int n2)
        //{
        //    int gcd = 1;
        //    for (int i = 1; i <= n1 && i <= n2; i++)
        //    {
        //        if (n1 % i == 0 && n2 % i == 0)
        //        {
        //            gcd = i;
        //        }
        //    }
        //    int lcm = (n1 * n2) / gcd;
        //    Console.WriteLine(lcm);
        //}


        //return type no parmaeter
        //int LCM()
        //{
        //    Console.WriteLine("Enter 1st nuber");
        //    int n1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter 2nd number");
        //    int n2 = Convert.ToInt32(Console.ReadLine());
        //    int gcd = 1;
        //    for (int i = 1; i <= n1 && i <= n2; i++)
        //    {
        //        if (n1 % i == 0 && n2 % i == 0)
        //        {
        //            gcd = i;
        //        }
        //    }
        //    int lcm = (n1 * n2) / gcd;
        //    return lcm;
        //}


        //return type with parameter
        //int LCM( int n1, int n2)
        //{
        //    int gcd = 1;
        //    for (int i = 1; i <= n1 && i <= n2; i++)
        //    {
        //        if (n1 % i == 0 && n2 % i == 0)
        //        {
        //            gcd = i;
        //        }
        //    }
        //    int lcm = (n1 * n2) / gcd;
        //    return lcm;
        //}


        //Task 14
        //Create a UDF that accepts a number and returns whether it is an Armstrong number or not.

        //no return no parameter
        //void Armstrong()
        //{
        //    Console.WriteLine("Enetr a number");
        //    int n= Convert.ToInt32(Console.ReadLine());
        //    int original = n;
        //    int sum = 0;
        //    for(int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        sum = sum + (digit*digit*digit);
        //    }
        //    if (sum == original)
        //    {
        //        Console.WriteLine("Number is Armostrong");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Number is not Armostrong");
        //    }
        //}


        //no return with parameter
        //void Armstrong( int n)
        //{
        //    int original = n;
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        sum = sum + (digit * digit * digit);
        //    }
        //    if (sum == original)
        //    {
        //        Console.WriteLine("Number is Armostrong");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Number is not Armostrong");
        //    }
        //}


        //return with no parameter
        //bool Armstrong()
        //{
        //    Console.WriteLine("Enetr a number");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int original = n;
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        sum = sum + (digit * digit * digit);
        //    }
        //    if (sum == original)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //return with parameter
        //bool Armstrong( int n)
        //{
        //    int original = n;
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        sum = sum + (digit * digit * digit);
        //    }
        //    if (sum == original)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //Task 15
        //Create a UDF that accepts a number and returns whether it is a perfect number or not.

        //no return no parameter
        //void PerfectNumber()
        //{
        //    Console.WriteLine("Enter a number:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int sum = 0;

        //    for (int i = 1; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            sum = sum + i;
        //        }
        //    }
        //    if (sum == n)
        //    {
        //        Console.WriteLine("Perfect Number");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not a Perfect Number");
        //    }
        //}


        //no return parameter
        //void PerfectNumber( int n)
        //{
        //    int sum = 0;

        //    for (int i = 1; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            sum = sum + i;
        //        }
        //    }
        //    if (sum == n)
        //    {
        //        Console.WriteLine("Perfect Number");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not a Perfect Number");
        //    }
        //}

        //return with no parameter
        //bool PerfectNumber()
        //{
        //    Console.WriteLine("Enter a number:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int sum = 0;

        //    for (int i = 1; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            sum = sum + i;
        //        }
        //    }
        //    if (sum == n)
        //    {
        //       return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //return with parameter
        //bool PerfectNumber( int n)
        //{

        //    int sum = 0;

        //    for (int i = 1; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            sum = sum + i;
        //        }
        //    }
        //    if (sum == n)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //Task 16
        //Create a UDF that accepts a number and returns the sum of only its even digits.

        //no return no parameter
        //void Evendigit()
        //{
        //    Console.WriteLine("Enter the Number..");
        //    int n= Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for(int i = n; i > 0; i=i/10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 == 0)
        //        {
        //            sum= sum + digit;
        //        }
        //    }
        //    Console.WriteLine(sum);


        //}


        //no return with parameter
        //void Evendigit( int n)
        //{
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 == 0)
        //        {
        //            sum = sum + digit;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}

        //return with no parameter
        //int Evendigit()
        //{
        //    Console.WriteLine("Enter the Number..");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 == 0)
        //        {
        //            sum = sum + digit;
        //        }
        //    }
        //   return sum;
        //}


        //return with parameter
        //int Evendigit( int n)
        //{
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 == 0)
        //        {
        //            sum = sum + digit;
        //        }
        //    }
        //    return sum;
        //}


        //Task 17
        //Create a UDF that accepts a number and returns the sum of only its odd digits.

        //no return no parameter
        //void Odddigit()
        //{
        //    Console.WriteLine("Enter a Number");
        //    int n= Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for(int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 !=0)
        //        {
        //            sum= sum + digit;
        //        }

        //    }
        //    Console.WriteLine(sum);
        //}

        //no return with parameter
        //void Odddigit(int n)
        //{
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 != 0)
        //        {
        //            sum = sum + digit;
        //        }

        //    }
        //    Console.WriteLine(sum);
        //}

        //return with no parameter
        //int Odddigit()
        //{
        //    Console.WriteLine("Enter a Number");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 != 0)
        //        {
        //            sum = sum + digit;
        //        }
        //    }
        //    return sum;
        //}

        //return with parameter
        //int Odddigit( int n)
        //{
        //    int sum = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 != 0)
        //        {
        //            sum = sum + digit;
        //        }

        //    }
        //    return sum;
        //}


        //Task 18
        //Create a UDF that accepts a number and displays the count of even and odd digits.

        //no return no parameter
        //void EvenOdd()
        //{
        //    Console.WriteLine("Enter a Number");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int even = 0;
        //    int odd= 0;
        //    for(int i=n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 == 0)
        //        {
        //            even = even + 1;
        //        }
        //        else
        //        {
        //            odd = odd + 1;
        //        }
        //    }
        //    Console.WriteLine("Even digits = " + even);
        //    Console.WriteLine("Odd digits = " + odd);
        //}

        //no return with parameter
        //void EvenOdd(int n)
        //{
        //    int even = 0;
        //    int odd = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 == 0)
        //        {
        //            even = even + 1;
        //        }
        //        else
        //        {
        //            odd = odd + 1;
        //        }
        //    }
        //    Console.WriteLine("Even digits = " + even);
        //    Console.WriteLine("Odd digits = " + odd);
        //}

        //return with no parameter
        //string EvenOdd()
        //{
        //    Console.WriteLine("Enter a Number");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int even = 0;
        //    int odd = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 == 0)
        //        {
        //            even = even + 1;
        //        }
        //        else
        //        {
        //            odd = odd + 1;
        //        }
        //    }
        //    return "Even digits = " + even + ", Odd digits = " + odd;
        //}

        // return with parameter
        //string EvenOdd(int n)
        //{
        //    int even = 0;
        //    int odd = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit % 2 == 0)
        //        {
        //            even = even + 1;
        //        }
        //        else
        //        {
        //            odd = odd + 1;
        //        }
        //    }
        //    return "Even digits = " + even + ", Odd digits = " + odd;
        //}


        //Task 19
        //Create a UDF that accepts a number and returns its largest digit.

        //no return no parameter
        //void Largestdigit()
        //{
        //    Console.WriteLine("Enter a Number");
        //    int n= Convert.ToInt32(Console.ReadLine());
        //    int largest = 0;
        //    for(int i= n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit > largest)
        //        {
        //            largest=digit;
        //        }
        //    }
        //    Console.WriteLine(largest);
        //}

        //no return with parameter
        //void Largestdigit(int n)
        //{
        //    int largest = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit > largest)
        //        {
        //            largest = digit;
        //        }
        //    }
        //    Console.WriteLine(largest);
        //}

        //return with no parameter
        //int Largestdigit()
        //{
        //    Console.WriteLine("Enter a Number");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int largest = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit > largest)
        //        {
        //            largest = digit;
        //        }
        //    }
        //    return largest;
        //}

        //return with parameter
        //int Largestdigit(int n)
        //{
        //    int largest = 0;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit > largest)
        //        {
        //            largest = digit;
        //        }
        //    }
        //    return largest;
        //}


        //Task 20
        //Create a UDF that accepts a number and returns its smallest digit.
        //void Smallestdigit()
        //{
        //    Console.WriteLine("Enter a Number");
        //    int n= Convert.ToInt32(Console.ReadLine());
        //    int smallest = 9;
        //    for(int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit < smallest)
        //        {
        //            smallest=digit;
        //        }
        //    }
        //    Console.WriteLine(smallest);
        //}

        // no return with parameter
        //void Smallestdigit(int n)
        //{
        //    int smallest = 9;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit < smallest)
        //        {
        //            smallest = digit;
        //        }
        //    }
        //    Console.WriteLine(smallest);
        //}

        //return with no parameter
        //int Smallestdigit()
        //{
        //    Console.WriteLine("Eneter a number");
        //    int n=Convert.ToInt32(Console.ReadLine());
        //    int smallest = 9;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit < smallest)
        //        {
        //            smallest = digit;
        //        }
        //    }
        //    return smallest;
        //}

        //rteurn with parameter
        //int Smallestdigit(int n)
        //{
        //    int smallest = 9;
        //    for (int i = n; i > 0; i = i / 10)
        //    {
        //        int digit = i % 10;
        //        if (digit < smallest)
        //        {
        //            smallest = digit;
        //        }
        //    }
        //    return smallest;
        //}


    }
}
