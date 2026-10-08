namespace NestedLoopPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to print follwing pattren
            /* 11111
             * 22222
             * 33333
             * 44444
             * 55555
             */
            //for (int i=2;i<=6;i++)
            //{
            //    for (int j=2;j<=6;j++)
            //    {
            //        Console.Write(i+"\t");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 3; i <= 8; i++)
            //{
            //    for (int j=3;j<=8;j++)
            //    {
            //        Console.Write(i+"\t");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 4; i <= 8; i++)
            //{
            //    for(int j=4;j<=8; j++)
            //    {
            //        Console.Write(i+"\t");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 5; i <= 9; i++)
            //{
            //    for(int j = 5; j <= 9; j++)
            //    {
            //        Console.Write(i+"\t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(i + "\t ");
            //    }
            //    Console.WriteLine();
            //}


            /* 55555
             * 44444
             * 33333
             * 22222
             * 11111
             */

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= 1; j--)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }




            //for (int i = 1; i <= 10; i++)
            //{

            //    for (int j=1;j<=10;j++)
            //    {
            //        Console.Write(i*j+" ");
            //    }
            //    Console.WriteLine();
            //}


            //All Prime number print ...
            //Console.WriteLine("1,2");
            //int count;
            //int n;
            //Console.WriteLine("Enter number ");
            //n=Convert.ToInt32(Console.ReadLine());
            //for (int i = 3; i < n; i++)
            //{
            //    const
            //for(int j = 2; j < i; j++)
            //    {

            //    }
            //}




            //wap to enter a number and check number is a perfect number or not 
            //1 to n print all perfect number & how many number...

            //int n;
            //Console.WriteLine("Enter a perfect nuber");
            //n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //if (sum == n)
            //{
            //    Console.WriteLine($"{n} is the is perfect number");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} is not  perfect number");
            //}







            //wap to print all perfect number  between 1 to 1000\

            //    int n;
            //    Console.WriteLine("Enter a perfect nuber");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    int sum = 0;
            //    for (int i = 1; i < n; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            sum += i;
            //        }
            //    }
            //    if (sum == n)
            //    {
            //        Console.WriteLine($"{n} is the is perfect number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{n} is not  perfect number");
            //    }

        }
    }
}
