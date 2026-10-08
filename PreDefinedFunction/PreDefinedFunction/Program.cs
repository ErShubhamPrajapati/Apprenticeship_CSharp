namespace PreDefinedFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to input yorr userid its valid or not

            //string userid;
            //Console.WriteLine("Enter Your UserId..");
            //userid= Console.ReadLine();
            //if (userid.ToLower() == "techpile")
            //{
            //    Console.WriteLine("Yes its valid id");
            //}
            //else
            //{
            //    Console.WriteLine("No its not valid id");
            //}

            //============================================================

            //string userid;
            //Console.WriteLine("Enter Your UserId..");
            //userid = Console.ReadLine();
            //if (userid.Trim().ToLower() == "techpile")
            //{
            //    Console.WriteLine("Yes its valid id");
            //}
            //else
            //{
            //    Console.WriteLine("No its not valid id");
            //}

            //=========================================================

            //bool result="techpile".Contains('t');
            //Console.WriteLine(result);

            //bool result="techpile".Contains("tec");
            //Console.WriteLine(result);

            //===============================================================

            //int i = "techpile".IndexOf('e');
            //Console.WriteLine(i);
            //int result="techpile".IndexOf("e",1);
            //Console.WriteLine(result);
            //int result = "techpile".IndexOf("tech",0);
            //Console.WriteLine(result);
            //int result = "techpile".IndexOf('t', 0, 3);
            //Console.WriteLine(result);

            //=========================================================

            //bool result="techpile".StartsWith("tech");
            //Console.WriteLine(result);

            //wap to input userid from student and check it is a valid id or not ,, 
            //every id contains techpile in starting

            //string userid;
            //Console.WriteLine("Enter your userid");
            //userid= Console.ReadLine();
            //if (userid.Trim().ToLower().StartsWith("techpile"))
            //{
            //    Console.WriteLine("Id is valid");
            //}
            //else
            //{
            //    Console.WriteLine("Id is not valid");
            //}

            //==============================================================

            //wap to input an email and check it is valid or not ,email ends with com,in,org,
            //string email;
            //Console.WriteLine("Enter Your EamilId");
            //email= Console.ReadLine();
            //if(email.ToLower().EndsWith("com") || email.ToLower().EndsWith("in") || email.ToLower().EndsWith("org"))
            //{
            //    Console.WriteLine("Email Id is Valid..");
            //}
            //else
            //{
            //    Console.WriteLine("Email Id is not valid..");
            //}

            //================================================================================

            //string result= "techpile".Substring(3,3);
            //Console.WriteLine(result);

            //Console.WriteLine("techpile".Remove(3));

            // string result="techpile".Replace('e','a');
            //Console.WriteLine(result);

            //string result = "techpile".Replace("e", null);
            //Console.WriteLine(result);

            //==================================================================

            //wap to input your fullname and print thr name without apace

            //string name;
            //Console.WriteLine("Enter your name");
            //name= Console.ReadLine();
            //string result = name.Replace(" ", null);
            //Console.WriteLine(result);

            //====================================================================

            //string[] result= "techpile".Split('e');
            // foreach (string s in result)
            // {
            //   Console.WriteLine(s);
            // }

            //============================================================

            //wap to input your full name and print only last name

            //string name;
            //Console.WriteLine("Enter your name..");
            //name= Console.ReadLine();
            //string[] result = name.Split(" ");
            //Console.WriteLine($"Last name = {result[result.Length-1]}");

            //=========================================================

            //Console.WriteLine("techpile".Length);


            //========================================================================================================

            //double result=Math.Cbrt(27);
            //Console.WriteLine(result);

            //double reslut= Math.Pow(2,5);
            //Console.WriteLine(reslut);

            //decimal result= Math.Abs((decimal)7.2222);
            //Console.WriteLine(result);

            //double result = Math.Ceiling(5.899);
            //Console.WriteLine(result);

            //double result = Math.Floor(5.899);
            //Console.WriteLine(result);

            //double result = Math.Round(5.599);
            //Console.WriteLine(result);

            //Console.WriteLine(Math.PI);

            //double reslut = Math.Sqrt(5);
            //Console.WriteLine(reslut);


            //===========================================================================================================

           // string[] fruits = { "Apple", "Mango", "Orange", "Banana","Guava" };

            //Console.WriteLine(fruits.Length);

            //Array.Sort(fruits);
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //foreach (string fruit in fruits.Reverse())
            //{
            //    Console.WriteLine(fruit);
            //}

            //Array.Reverse(fruits);
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}


            //int result= Array.IndexOf(fruits,"Mango");
            //Console.WriteLine(result);

            //string[] names = new string[10];
            //Array.Copy(fruits,names,5);
            //Console.WriteLine(names.Length);
            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //=================================================================================

            //Math , Array , string

            //Otp releted..
            Random random=new Random();
            int result= random.Next(1000,9999);
            Console.WriteLine(result);




        }
    }
}
