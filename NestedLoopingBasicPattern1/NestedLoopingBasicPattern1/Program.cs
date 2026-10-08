namespace NestedLoopingBasicPattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Enter a number");
            //int n= Convert.ToInt32(Console.ReadLine());
            //int digit;
            //int c=0;
            ////for (;n>0;n=n/10) 
            //for(int i=n;i>0;i=i/10)
            //{
            //    digit = i % 10;
            //    c++;
            //}
            //Console.WriteLine(c);

            //Console.WriteLine("Enter a number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int digit;
            //int sum = 0;
            ////for (;n>0;n=n/10) 
            //for (int i = n; i > 0; i = i / 10)
            //{
            //    digit = i % 10;
            //    sum = sum + digit;
            //}
            //Console.WriteLine($"sum of Digit = { sum}");


            //wap to find sum of cube of digit of a number

            //Console.WriteLine("Enter a number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int digit;
            //int sum = 0;
            //int cube;
            ////for (;n>0;n=n/10) 
            //for (int i = n; i > 0; i = i / 10)
            //{
            //    digit = i % 10;
            //    cube = digit * digit * digit;
            //    sum = sum + cube;
            //}
            //Console.WriteLine($"sum of Digit = {sum}");

            //Armstrong value
            //Console.WriteLine("Enter a number");
            //int n = Convert.ToInt32(Console.ReadLine());
            ////find number of digit in n

            //int count = 0;
            //for (int i = n; i > 0; i = i / 10)
            //{
            // count++;
            //}
            ////find sum of each digit^count of n
            //int digit;
            //int mul;
            //int sum = 0;
            //for(int i = n; i > 0;i = i / 10)
            //{
            //    digit=i % 10;
            //    //find digit^count
            //    mul = 1;
            //    for(int j = 1; j <= count; j++)
            //    {
            //        mul = mul * digit;
            //        //find sum of mul

            //    }
            //    sum = sum + mul;
            //}
            //if (n == sum)
            //{
            //    Console.WriteLine($"{n} is a Armstrong number");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} is not a Armstrong number");
            //}


            //wap to find of a reverse number 
            //int n, digit;
            //Console.WriteLine("Enter a number");
            //n =Convert.ToInt32(Console.ReadLine());
            //int rev = 0;
            //for(int i=n;i>0 ;i=i/10 )
            //{
            //    digit = i % 10;
            //    rev = rev * 10 + digit;
            //}
            //Console.WriteLine($"Revers of {n} = {rev}");


            //wap a to print a palindrome number.
            //int n, digit;
            //Console.WriteLine("Enter a number");
            //n = Convert.ToInt32(Console.ReadLine());
            //int rev = 0;
            //for (int i = n; i > 0; i = i / 10)
            //{
            //    digit = i % 10;
            //    rev = rev * 10 + digit;
            //}
            //if (n == rev)
            //{
            //    Console.WriteLine($"{n} is a Palindrome Number");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} is not  a Palindrome Number");

            //}





            //*
            //**
            //***
            //****
            //*****
            //****
            //***
            //**
            //*


            int n;
            for(int i = 1; i <= 9; i++)
            {
                if (i <= 5)
                    n = i;
                else
                    n = 10 - i;
                for (int j=1;j<=n ;j++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



          













        }
    }
}
