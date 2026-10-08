
namespace LoopingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. wap to print 1 to 10 number 
            //for (int i=1;i<=10;i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 2. wap to print all number from 1 to 100
            //for (int i= 1;i<=100;i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 3. wap to print all number from 100 to 1
            //for (int i=100;i>=1;i--)
            //{
            //    Console.WriteLine(i);  
            //}

            // 4. wap to print table of 2
            //for (int i=2;i<=20;i+=2)
            //{
            //    Console.WriteLine(i);
            //}


            // 5. wap to print all number form 1 to n
            //int n;
            //Console.WriteLine("Enter last value of range : ");
            //n=Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 6.wap to print table of n
            //int n;
            //Console.WriteLine("Enter a n rangeb of table number");
            //n=Convert.ToInt32(Console.ReadLine());
            //for (int i= 1;i<=10;i++)
            //{
            //    Console.WriteLine(i*n);
            //}

            // udation = dynamic
            //0,1,3,6,10,15
            //int n;
            //n = 0;
            //for (int i=0;i<=15;i=i+n)
            //{
            //    Console.WriteLine(i);
            //    n++;
            //}




            //int i;
            //Console.WriteLine("Enter a starting number .. ");
            //i=Convert.ToInt32(Console.ReadLine());
            //int n;
            //Console.WriteLine("Enter a last number ..");
            //n=Convert.ToInt32(Console.ReadLine());
            //for (;i<=n;i++)
            //{
            //    Console.WriteLine(i);
            //}


            //To find diffrent value form loop cycles
            //wap to add all number form 1 to 10
            // wap to multiply all number from 1 to 10
            // wap to fine factorial of 5
            //int mul = 1;
            //for (int i=1;i<=10;i++)
            //{
            //    Console.WriteLine(mul);
            //    mul *= i;

            //}



            //0,1,3,6,10,15,21,28,36,45
            //int n;
            //n = 0;
            //for (int i=0;i<=45;i=i+n)
            //{
            //    Console.WriteLine(i);
            //    n++;
            //}

            //1,3,6,10,15,21,28,36,45,55
            //int n;
            //n = 1;
            //for (int i = 1; i <= 55; i = i + n)
            //{
            //    Console.WriteLine(i);
            //    n++;
            //}

            //2,5,9,14,20,27,35,44,54,65
            //int n;
            //n = 2;
            //for (int i =2;i<=65;i=i+n)
            //{
            //    Console.WriteLine(i);
            //    n++;
            //}

            //1,2,4,7,11,16,22,29,37,46
            //int n = 1;

            //for (int i = 1; i <= 46; i = i + n)
            //{
            //    Console.WriteLine(i);
            //    n++;
            //}

            //5,7,10,14,19,25,32,40,49,59
            //int n = 1;
            //for (int i=5;i<=59;i=i+n)
            //{
            //    Console.WriteLine(i);
            //    n++;
            //}


            //1,4,9,16,25,36,49,64,81,100
            //int n = 3;

            //for (int i = 1; i <= 100; i = i + n)
            //{
            //    Console.WriteLine(i);
            //    n += 2;
            //}

            // wap to add all number from 1 to 10
            //int n = 0;
            //for(int i=1;i<=10;i++)
            //{
            //    n = n + i;
            //    Console.WriteLine(n);

            //}

            // wap to add all number from 1 to 50
            //int n = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    n = n + i;
            //    Console.WriteLine(n);

            //}

            // wap to add all even number from 1 to 100

            //int n = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        n = n + i;
            //    }
            //    Console.WriteLine(n);
            //}


            // wap to add all odd number from 1 to 100

            int n = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    n = n + i;
                }
                Console.WriteLine(n);
            }

        }
    }
}
