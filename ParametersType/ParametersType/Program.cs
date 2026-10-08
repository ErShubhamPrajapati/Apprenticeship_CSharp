namespace ParametersType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1D Array

            //int[] arr;
            //arr=new int[10];  or

            //int[]arr=new int[10];   //or
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] arr = {1, 2, 3, 4, 5};
            //Console.WriteLine(arr[2]);

            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            //Console.WriteLine(arr[3]);

            //foreach (int i in arr) 
            //{
            // Console.WriteLine(i);
            //}

            //wap to access onl even index element 
            //for (int i = 0; i < arr.Length; i=i+2)
            //{ 
            //  Console.WriteLine(arr[i]);
            //}



            //2 wap to input  elemet of array and find sum of all element
            //int[]arr= new int[10];
            //Console.WriteLine("Enter 10 element of array..");
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + arr[i];

            //}
            //Console.WriteLine($" Total Element = {sum}");


            //2D Array...

            //int[,] arr;
            //arr = new int[5, 6];

            //int[,] arr = { { 0, 3, 5 }, {56,34,34 } };

            //int[,] arr = new int[3, 4] { {1,2,3,4 },{1,5,4,2 },{4,5,6,7 } };
            //foreach (int a in arr)
            //{
            //    Console.WriteLine(a);
            //}


            //wap to store 5 subject marks of 3 student in an 2D array and fine sum of all atudent marks..
            int[,] marks = new int[3, 5];
            for (int i = 0; i <= 2; i++) 
            {
                Console.WriteLine("Enter 5 subject marks..");
                for (int j = 0; j <= 4; j++)
                {
                 
                    marks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Sum of marks all student = ");
            int sum;
            for(int i = 0;i <= 2; i++)
            {
                sum = 0;
                
             for(int j = 0;j <= 4; j++)
                {
                    sum= sum + marks[i, j];
                }
                Console.WriteLine("Sum = "+sum);
            }



        }
        //Program p=new Program();
        //int a, b, c, d;
        //int n1, n2;
        //n1=50;
        //n2=60;
        //p.Calculate(n1,n2,out a,out b, out c ,out d)
        //    p.Add(n1,n2);
    }
    //void Add(int a,int b)
    //    {
    //        int res= a + b;
    //        Console.WriteLine($"Ouput = {res}");
    //    }
    //    void Calculate
}

