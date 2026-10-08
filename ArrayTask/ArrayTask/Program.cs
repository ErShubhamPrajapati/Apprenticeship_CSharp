using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Print the first element of an array.
            //int[] arr = [1,2,3,4,5,6];
            //Console.WriteLine(arr[0]);

            //2.Print the last element of an array.
            //int[] arr2 = {1,2,3,4,5,6};
            //Console.WriteLine(arr2[5]);

            //3.Print all elements using a `for` loop
            //int[]arr3= {1,2,3,4,6,7,8,9};
            //for(int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}

            //4.Print all elements using a `foreach` loop.
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //foreach (int i in arr)
            //{ 
            //  Console.WriteLine(i);
            //}

            //5.Find the sum of only even elements.
            //    int[] arr = {4,1,2,3,4,5,6,7,8,9,10};
            //    int sum = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    { 
            //        if (arr[i] % 2 == 0)
            //        {
            //            sum = sum + arr[i];  
            //        } 
            //    }
            //    Console.WriteLine(sum);

            //6.Find the sum of only odd elements.
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        sum= sum + arr[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //7.Count numbers greater than 50.
            //int[] arr = { 14, 20, 39, 49, 50, 68, 99, 8, 89, 10 };
            //int count = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 50)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            //8.Count numbers less than 50.
            //int[] arr = { 14, 20, 39, 49, 50, 68, 99, 8, 89, 10 };
            //int count = 0;
            //for(int i= 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 50)
            //    {
            //        count++;   
            //    }
            //}
            //Console.WriteLine(count);

            //9.Print only positive numbers.
            //int[] arr = { 1, -7, 0, -7, 3, 7, -8, 66, 5, -6 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            //10.Print only negative numbers.
            //int[] arr = { 1, -7, 0, -7, 3, 7, -8, 66, 5, -6 };
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 0)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}


            //11.Create an integer array of 5 elements and print all elements.
            //int[] arr = { 1, 0, 20, 3, 4, };
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //  Console.WriteLine(arr[i]);
            //}

            //12.Take 5 numbers from the user and store them in a 1D array.Print all numbers.
            //Console.WriteLine("Enter the 5 Number");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int n3 = Convert.ToInt32(Console.ReadLine());
            //int n4 = Convert.ToInt32(Console.ReadLine());
            //int n5 = Convert.ToInt32(Console.ReadLine());
            //int[] arr = { n1, n2, n3, n4, n5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            //13.Find the sum of all elements of an array.
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for(int i= 0; i < arr.Length; i++)
            //{
            //    sum= sum + arr[i];
            //}

            //Console.WriteLine($"Sum = {sum}");


            //14.Find the average of all elements of an array.
            //int[] arr = { 1, 2, 3, 4, 5,6};
            //int avg = 0;
            //int sum = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    sum= sum + arr[i];
            //    avg= sum / arr.Length;
            //}
            //Console.WriteLine(avg);

            //15.Find the largest element in an array.
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int largest = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > largest)
            //    {
            //        largest = arr[i];
            //    }
            //}
            //Console.WriteLine(largest);

            //16.Find the smallest element in an array.
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int smallest = arr[0];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < smallest)
            //    {
            //        smallest = arr[i];
            //    }
            //}
            //Console.WriteLine(smallest);


            //17.Count how many even numbers are present in an array.
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int count = 0;
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Total Even Number{count}");

            //18.Count how many odd numbers are present in an array.
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int count = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Total Odd Number {count}");

            //19.Count positive and negative numbers in an array.
            //int[] arr = { -6, -4, 7, -6, 5, 7, 3, -2, 6 };
            //int Positivecount = 0;
            //int Negativecount = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        Positivecount++;    
            //    }
            //    else
            //    {
            //    Negativecount++;    
            //    }
            //}
            //Console.WriteLine($"Total Positive Number is = {Positivecount}, And Negative Number is = {Negativecount}");


            //20.Search for a given number in an array.
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Enter the number to search");
            //int n = Convert.ToInt32(Console.ReadLine());
            //bool search = false;
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //     if(arr[i] == n)
            //    {
            //        search= true;
            //        break;
            //    }
            //}
            //Console.WriteLine(search);

            //21.Ask the user for the size of an array and take elements from the user.
            //Console.WriteLine("Enter the number the size Array element");
            //int[] arr = [];


            //22.Take 5 student marks from the user and print all marks.
            //Console.WriteLine("Take the 5 student marks");
            //int m1= Convert.ToInt32(Console.ReadLine());
            //int m2= Convert.ToInt32(Console.ReadLine());
            //int m3= Convert.ToInt32(Console.ReadLine());
            //int m4= Convert.ToInt32(Console.ReadLine());
            //int m5= Convert.ToInt32(Console.ReadLine());
            //int[]arr= {m1,m2,m3,m4,m5};
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($" {arr[i]} ");
            //}

            //23.Take 5 numbers and find their total.
            //Console.WriteLine("Take the 5 student marks");
            //int m1 = Convert.ToInt32(Console.ReadLine());
            //int m2 = Convert.ToInt32(Console.ReadLine());
            //int m3 = Convert.ToInt32(Console.ReadLine());
            //int m4 = Convert.ToInt32(Console.ReadLine());
            //int m5 = Convert.ToInt32(Console.ReadLine());
            //int[] arr = { m1, m2, m3, m4, m5 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum=sum+arr[i];
            //}
            //Console.WriteLine($"Total = {sum}");

            //24.Take 5 numbers and find their average.
            //Console.WriteLine("Take the 5 student marks");
            //int m1 = Convert.ToInt32(Console.ReadLine());
            //int m2 = Convert.ToInt32(Console.ReadLine());
            //int m3 = Convert.ToInt32(Console.ReadLine());
            //int m4 = Convert.ToInt32(Console.ReadLine());
            //int m5 = Convert.ToInt32(Console.ReadLine());
            //int[] arr = { m1, m2, m3, m4, m5 };
            //int sum = 0;
            //int avg = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum = sum + arr[i];
            //    avg = sum/ arr[i];
            //}
            //Console.WriteLine($"Average = {avg}");

            //25.Take numbers from the user and count even numbers.
            //Console.WriteLine("Take the 5 student marks");
            //int m1 = Convert.ToInt32(Console.ReadLine());
            //int m2 = Convert.ToInt32(Console.ReadLine());
            //int m3 = Convert.ToInt32(Console.ReadLine());
            //int m4 = Convert.ToInt32(Console.ReadLine());
            //int m5 = Convert.ToInt32(Console.ReadLine());
            //int[] arr = { m1, m2, m3, m4, m5 };
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Total Even Number = {count}");

            //26.Take numbers from the user and count odd numbers.
            //Console.WriteLine("Take the 5 student marks");
            //int m1 = Convert.ToInt32(Console.ReadLine());
            //int m2 = Convert.ToInt32(Console.ReadLine());
            //int m3 = Convert.ToInt32(Console.ReadLine());
            //int m4 = Convert.ToInt32(Console.ReadLine());
            //int m5 = Convert.ToInt32(Console.ReadLine());
            //int[] arr = { m1, m2, m3, m4, m5 };
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Total Odd Number = {count}");

            //27.Take numbers from the user and find the largest number.
            //Console.WriteLine("Take the 5 student marks");
            //int m1 = Convert.ToInt32(Console.ReadLine());
            //int m2 = Convert.ToInt32(Console.ReadLine());
            //int m3 = Convert.ToInt32(Console.ReadLine());
            //int m4 = Convert.ToInt32(Console.ReadLine());
            //int m5 = Convert.ToInt32(Console.ReadLine());
            //int[] arr = { m1, m2, m3, m4, m5 };
            //int largest = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > largest)
            //    {
            //        largest = arr[i];
            //    }
            //}
            //Console.WriteLine($"Largest = {largest}");

            //28.Take numbers from the user and find the smallest number.

            //Console.WriteLine("Take the 5 student marks");
            //int m1 = Convert.ToInt32(Console.ReadLine());
            //int m2 = Convert.ToInt32(Console.ReadLine());
            //int m3 = Convert.ToInt32(Console.ReadLine());
            //int m4 = Convert.ToInt32(Console.ReadLine());
            //int m5 = Convert.ToInt32(Console.ReadLine());
            //int[] arr = { m1, m2, m3, m4, m5 };
            //int smallest = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < smallest)
            //    {
            //        smallest = arr[i];
            //    }
            //}
            //Console.WriteLine($"Largest = {smallest}");


            //29.Take numbers from the user and search for a given number.
            //Console.WriteLine("Take the 5 student marks");
            //int m1 = Convert.ToInt32(Console.ReadLine());
            //int m2 = Convert.ToInt32(Console.ReadLine());
            //int m3 = Convert.ToInt32(Console.ReadLine());
            //int m4 = Convert.ToInt32(Console.ReadLine());
            //int m5 = Convert.ToInt32(Console.ReadLine());
            //int[] arr = { m1, m2, m3, m4, m5 };
            //Console.WriteLine("Enter the number to search");
            //int seachnumber= Convert.ToInt32(Console.ReadLine());

            //bool search = false;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //     if(arr[i] == seachnumber)
            //    {
            //        search= true;
            //        break;
            //    }
            //}
            //if (search == true)
            //{
            //    Console.WriteLine("Number is found");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not found");
            //}

            //30.Take numbers from the user and print them in reverse order.
            Console.WriteLine("Take the 5 student marks");
            int m1 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            int m3 = Convert.ToInt32(Console.ReadLine());
            int m4 = Convert.ToInt32(Console.ReadLine());
            int m5 = Convert.ToInt32(Console.ReadLine());
            int[] arr = { m1, m2, m3, m4, m5 };
            Console.WriteLine("Reverse Order..");
            for(int i=arr.Length-1;i>=0;i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}