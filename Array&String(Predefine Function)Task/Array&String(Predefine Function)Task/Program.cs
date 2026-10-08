using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array_String_Predefine_Function_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //============================ Array Pre - defined Functions ============================

            //1.Create an integer array of 5 elements and print its `Length`. 
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arr.Length);

            //2.Create an array of 5 numbers and sort it using Sort(). 
            //int[] arr = {4,2,6,3,1 };
            //Array.Sort(arr);
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //3.Create an array of 5 numbers and reverse it using Reverse(). 
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Array.Reverse(arr);
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //4.Find the index of a given number using IndexOf(). 
            //int[] arr = { 11, 20, 33, 41, 54, 65, 71, 81 };
            //int index = Array.IndexOf(arr, 41);
            //Console.WriteLine(index);

            //5.Find the last index of a given number using LastIndexOf(). 
            //int[] arr = { 11, 20, 33, 41, 54, 65, 71, 81 };
            //int index = Array.LastIndexOf(arr, 71);
            //Console.WriteLine(index);

            ////6.Copy all elements of one array into another array using Copy().
            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arr2 = new int[10];
            //Array.Copy(arr1, arr2);
            //foreach (int i in arr2)                  //Mistakes
            //{
            //    Console.WriteLine(i);
            //}

            //7.Use Find() to find the first even number from an integer array.
            //int[] arr = {23,45,24,78,54,67,33,67,21};
            //int result = Array.Find(arr, Number => Number % 2 == 0);
            //Console.WriteLine(result);

            //8.Use Find() to find the first number greater than 50 from an array.
            //int[]arr= { 23, 45, 24, 78, 54, 67, 33, 67, 21 };
            //int result = Array.Find(arr, number => number > 50);
            //Console.WriteLine(result);

            //9.Use FindAll() to find all even numbers from an array. 
            //int[] arr = { 23, 45, 24, 78, 54, 67, 33, 67, 21 };
            //int[] result = Array.FindAll(arr,number=> number%2==0);
            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //10.Use FindAll() to find all numbers greater than 50 from an array.
            //int[] arr = { 23, 45, 24, 78, 54, 67, 33, 67, 21 };
            //int[] result = Array.FindAll(arr, number => number>50);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //11.Use ForEach() to print all elements of an integer array. 
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Array.ForEach(arr, number =>
            //{
            //    Console.WriteLine(number);
            //});

            //12.Use ForEach() to print the square of every element in an array. 
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Array.ForEach(arr, number =>
            //{
            //    Console.WriteLine(number*number);
            //});

            //13.Sort an array and print all elements using ForEach(). 
            //int[]arr = { 23, 45, 24, 78, 54, 67, 33, 67, 21 };
            //Array.Sort(arr);
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            //14.Reverse an array and print all elements using ForEach(). 
            //int[]arr= { 23, 45, 24, 78, 54, 67, 33, 67, 21 };
            //Array.Reverse(arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //15.Create an array with duplicate values and find the first and last index of a given number. 
            //int[] arr = { 10, 20, 30, 20, 40, 20, 50 };
            //int first=Array.IndexOf(arr, 20);
            //int last=Array.LastIndexOf(arr, 20);
            //Console.WriteLine("First = " + first);
            //Console.WriteLine("Last = " + last);



            //============================= String Pre - defined Functions ============================

            //16.Create a string and print its Length.
            //string name = "Shubham";
            //Console.WriteLine(name.Length);

            //17.Take a string from the user and convert it into uppercase using ToUpper(). 
            //string name = "shubham";
            //Console.WriteLine(name.ToUpper());

            //18.Take a string from the user and convert it into lowercase using ToLower(). 
            //string name = "SHUBHAM";
            //Console.WriteLine(name.ToLower());

            //19.Take a string with spaces at the beginning and end and remove them using Trim(). 
            //string name = "  shubham      ";
            //Console.WriteLine(name.Trim());

            //20.Remove spaces only from the beginning of a string using TrimStart(). 
            //string name = "   shubham";
            //Console.WriteLine(name.TrimStart());

            //21.Remove spaces only from the end of a string using TrimEnd(). 
            //string name = "shubham       ";
            //Console.WriteLine(name.TrimEnd());

            //22.Take a string from the user and check whether it contains "CSharp" using Contains(). 
            //Console.WriteLine("Enter a text..");
            //string text= Console.ReadLine();
            //bool result = text.Contains("CSharp");
            //Console.WriteLine(result);

            //23.Check whether a given string starts with "Hello" using StartsWith(). 
            //Console.WriteLine("Enter a text..");
            //string text = Console.ReadLine();
            //bool result = text.StartsWith("Hello");
            //Console.WriteLine(result);

            //24.Check whether a given string ends with "World" using EndsWith(). 
            //Console.WriteLine("Enter a text..");
            //string text= Console.ReadLine();
            //bool result = text.EndsWith("World");
            //Console.WriteLine(result);

            //25.Find the first occurrence of a character entered by the user using IndexOf(). 
            //Console.WriteLine("Enter a text..");
            //string text = Console.ReadLine();
            //Char ch = Convert.ToChar(Console.ReadLine());
            //int index = text.IndexOf(ch);
            //Console.WriteLine(index);

            //26.Find the last occurrence of a character entered by the user using LastIndexOf().
            //Console.WriteLine("Enter a text..");
            //string text= Console.ReadLine();
            //Char ch = Convert.ToChar(Console.ReadLine());
            //int index = text.LastIndexOf(ch);
            //Console.WriteLine(index);

            //27.Take a string from the user and extract the first 5 characters using Substring(). 
            //Console.WriteLine("Enter the text ...");
            //string text = Console.ReadLine();
            //string result = text.Substring(0, 5);
            //Console.WriteLine(result);

            //28.Replace all spaces in a string with `-` using Replace(). 
            //Console.WriteLine("Enter a text..");
            //string text = Console.ReadLine();
            //string result = text.Replace(" ", "-");
            //Console.WriteLine(result);

            //29.Remove the first 3 characters from a string using Remove(). 
            //Console.WriteLine("Enter the text ...");
            //string text = Console.ReadLine();
            //string result = text.Remove(0, 3);
            //Console.WriteLine(result);

            //30.Take a sentence from the user, split it into words using Split(), and print each word separately. 
            Console.WriteLine("Enter a sentence..");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
              Console.WriteLine($"{word}");
            }
        }
    }
}
