namespace OPP_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator c= new Calculator();  //   or  calaulator c;   c=new calculator();
            //c.a = 15900;
            //c.b = 14900;
            //c.Add();
            //c.Subtract();

            //Calculator c1 = new Calculator();
            //c1.a = 40;
            //c1.b = 50;
            //c1.Add();
            //c1.Subtract();
            //c.Add();
            //c.Subtract();

            Maths maths = new Maths();
            Console.WriteLine($"Result = " +maths.Add());
            Console.WriteLine($"Result = " +maths.Sub());
           

            
        }
    }

}
