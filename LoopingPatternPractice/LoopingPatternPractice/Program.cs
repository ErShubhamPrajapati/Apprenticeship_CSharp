using System.Buffers.Text;
using System.Numerics;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoopingPatternPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1.Print the above pattern using nested loops. 
            //*
            //**
            //***
            //****
            //*****

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Question 2.Print the above reverse star pattern using nested loops.
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



            //Question 3.Print the above star square using nested loops. 
            //*****
            //*****
            //*****
            //*****
            //*****

            //for(int i = 1; i <= 5; i++)
            // {
            //for(int j = 1; j<=5; j++)
            //{
            //    Console.Write("*");
            //}
            //Console.WriteLine();
            // }


            //Question 4.Print the above star pattern using nested loops.
            //*
            //**
            //***
            //****
            //*****
            //****
            //***
            //**
            //*

            //int n;
            //for (int i = 1; i <= 9; i++)
            //{
            //    if (i <= 5)
            //        n = i;
            //    else
            //        n = 10 - i;
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Question 5.Print the above increasing star pattern.Take N from the user.

            //*
            //**
            //***
            //****
            //*****
            //******

            //Console.WriteLine("Enter N number");
            //int n= Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= n;i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            //Easy – Number Patterns
            //Question 6.Print the above number pattern using nested loops.
            //1
            //12
            //123
            //1234
            //12345

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}


            //Question 7.Print the above reverse number pattern.
            //12345
            //1234
            //123
            //12
            //1

            //for(int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}


            //Question 8.Print the above repeated - number pattern.
            //1
            //22
            //333
            //4444
            //55555

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            //Question 9.Print the above number pattern using nested loops.
            //5
            //54
            //543
            //5432
            //54321

            //for(int i = 5; i >= 1; i--)
            //{
            //    for(int j = 5; j >= i; j--)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //Question 10.Print the above reverse - number pattern using nested loops. 
            //1
            //21
            //321
            //4321
            //54321
            //for(int i = 1; i <= 5; i++)
            //{
            // for(int j = i; j >= 1; j--)
            // {
            //     Console.Write(j);
            // }
            // Console.WriteLine();
            //}


            //Medium – Number & Alphabet Patterns

            //Question 11.Print the above continuous number pattern using nested loops.

            //1
            //23
            //456
            //789

            //int num = 1;
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(num);
            //        num++;
            //    }
            //    Console.WriteLine();
            //}



            //Question 12.Print the above continuous number pattern.Use a variable to generate the numbers.
            //1
            //23
            //456
            //789
            //1011121314  
            //int num = 1;
            //for (int i = 1; i <= 5; i++)  //mistakes
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(num);
            //        num++;
            //    }
            //    Console.WriteLine();
            //}



            //Question 13.Print the above decreasing alphabet pattern.
            //ABCDE
            // ABCD
            // ABC
            // AB
            // A

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write((char)(64 + j));
            //    }
            //    Console.WriteLine();
            //}


            //Question 14.Print the above alphabet pattern using nested loops. 
            //A
            //AB
            //ABC
            //ABCD 

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write((char)(64 + j));
            //    }
            //    Console.WriteLine();
            //}


            //Question 15.Print the above repeated - alphabet pattern.
            //A
            //BB
            //CCC
            //DDDD
            //EEEEE

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write((char)(64 + i));
            //    }
            //    Console.WriteLine();
            //}

            //Question 16.Print the above reverse alphabet pattern.
            //A
            //BA
            //CBA
            //DCBA
            //EDCBA

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write((char)(64 + j));
            //    }
            //    Console.WriteLine();
            //}


            //Question 17.Print the above continuous alphabet pattern.
            //A
            //BC
            //DEF
            //GHIJ
            //KLMNO

            //int n;
            //for(int i = 1; i <= 6; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(n);
            //        n++;
            //    }
            //    Console.WriteLine();
            //}


            //Question 18.Print the above number pattern for N = 6.
            //1
            //12
            //123
            //1234
            //12345
            //123456
            //    for(int i = 1; i <= 6; i++)
            //{
            //    for(int j=1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //Question 19. Print the above repeated-number pattern for N = 6
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


            //Tough – Logic - Based Patterns
            //Question 20.Print the above palindromic number pattern using nested loops.
            //1
            //121
            //12321
            //1234321
            //123454321

            //for (int i = 1; i <= 5; i++)
            //{
            //    // Increasing numbers
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    // Decreasing numbers
            //    for (int j = i; j > 1; j--)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //Question 21.Print the above palindromic alphabet pattern using nested loops.
            //A
            //ABA
            //ABCBA
            //ABCDCBA
            //ABCDEDCBA

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write((char)(64 + j));
            //    }

            //    for (int j = i; j > 1; j--)
            //    {
            //        Console.Write((char)(63 + j));
            //    }

            //    Console.WriteLine();
            //}


            //Question 22.Print the above increasing and decreasing star pattern.

            //*
            //**
            //***
            //****
            //*****
            //****
            //***
            //**
            //*

            //int n;
            //for (int i = 1; i <= 9; i++)
            //{
            //    if (i <= 5)
            //        n = i;
            //    else
            //        n = 10 - i;
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Class Work======================================

            //A
            //BC
            //DEF
            //GHIJ
            //KLMNO
            //PQRSTU

            //for(int i = 1; i <= 6; i++)
            //{
            //    for(int j= 1; j <= i; j++)
            //    {
            //        Console.Write((char)(64 + j));
            //    }
            //    Console.WriteLine();
            //}


            //1
            //121
            //12321
            //1234321
            //123454321

            //for(int i = 1; i <= 9; i++)
            //{
            //    for(int j= 1; j <= i; j++)
            //    {
            //        if (j<=(i+1)/2)
            //        Console.Write(j);
            //        else
            //            Console.Write(i-j+1);
            //    }
            //    Console.WriteLine();
            //}

            //OR
            // for(int i = 1; i <= 5; i++)
            //{
            //    for(int j=1;j<= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for(int j = i - 1; j >= 1; j--)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}




            //A
            //ABA
            //ABCBA
            //ABCDCBA
            //ABCDEDCBA
            //    for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write((char)(64+j));
            //    }
            //    for(int j = i-1; j >= 1; j--)
            //    {
            //        Console.Write((char)(64 + j));

            //    }
            //    Console.WriteLine();
            //}


            /*           *
             *          * *
             *         * * *
             *        * * * *
             *       * * * * *
             *      * * * * * *
             */

            //for (int i = 1; i <= 6; i++)
            //{
            //    //Print the space
            //    for (int j = 1; j <= 6 - i; j++)
            //        Console.Write(" ");
            //    //print the elements
            //    for (int k = 1; k <= i; k++)
            //        Console.Write("* ");
            //    //print the new line character
            //}
            //Console.WriteLine();



            //wap to print a pyramid pattren with n rows
            //Console.WriteLine("Enter a star number");
            //int n= Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 6; i++)
            //{
            //    for (int j = 1; j <= 6 - i; j++) 
            //        Console.Write(" ");
            //    for (int k = 1; k <= i; k++)
            //        Console.Write("* ");
            //}
            //Console.WriteLine();




            /*  
             *  
             */


        }
    }
}
