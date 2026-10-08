using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OperatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Increment & Decrement Operators(++--)

            //1.Evaluate the following expression and find the result and final value of a, if a = 10:|| (++a + a-- * a++ )
            //int a = 10;
            //int res1 = ++a + a-- * a++;
            //Console.WriteLine(res1);

            //2.Find the result and final value of num, if num = 8: ||(num++ * ++num - --n)
            //int num = 8;
            //int res2 = num++ * ++num - --num;
            //Console.WriteLine(res2);

            //3.Evaluate the following expression if x = 12: || (++x * x-- + --x - x++)
            //int x = 12;
            //int res3 = ++x * x-- + --x - x++;
            //Console.WriteLine(res3);


            //4.Find the result and final value of n, if n = 15: || (n-- + ++n * n++ - --)
            //int n = 15;
            //int res4 = n-- + ++n * n++ - --n;
            //Console.WriteLine(res4);

            //5.Evaluate the following expression if value = 20: || (++value - value++ * --value)
            //int value = 20;
            //int res5 = ++value - value++ * --value;
            //Console.WriteLine(res5);

            //6.Find the result and final value of p, if p = 7: || (p++ + ++p - p-- + --p)
            //int p = 7;
            //int res6 = p++ + ++p - p-- + --p;
            //Console.WriteLine(res6);

            //7.Evaluate the following expression and find the final value of count, if count = 10: || (++count * 2 - count-- + count++)
            //int count = 10;
            //int res7 = ++count * 2 - count-- + count++;
            //Console.WriteLine(res7);

            //2.Relational Operators(> < >= <= == !=)

            //1.Evaluate the following expression if a = 25, b = 15, and c = 25: || (a > b && a == c )
            //int a, b, c;
            //a = 25;
            //b = 15;
            //c = 25;
            //bool res8 = a > b && a == c;
            //Console.WriteLine(res8);


            //2.Find the result if x = 40, y = 25, and z = 40:||(x >= y && x == z )
            //int x, y, z;
            //x = 40;
            //y = 25;
            //z = 40;
            //bool res9 = x >= y && x == z;
            //Console.WriteLine(res9);

            //3.Evaluate the following expression if p = 50, q = 50, and r = 75:  || (p == q && q != r && p < r )
            //int p, q, r;
            //p = 50;
            //q = 50;
            //r = 75;
            //bool res10 = p == q && q != r && p < r;
            //Console.WriteLine(res10);

            //4.Find the result if a = 10, b = 20, and c = 30:  || (a < b && b < c && a != c )
            //int a, b, c;
            //a = 10;
            //b = 20;
            //c = 30;
            //bool res11 = a < b && b < c && a != c;
            //Console.WriteLine(res11);

            //5.Evaluate the following expression if marks = 65: ||(marks >= 40 && marks <= 100 )
            //int marks = 65;
            //bool res12 = marks >= 40 && marks <= 100;
            //Console.WriteLine(res12);


            //6.Find the result if x = 30, y = 20, and z = 30: || (x > y || x != z)
            //int x, y, z;
            //x = 30;
            //y = 20;
            //z= 30;
            //bool res13 = x > y || x != z;
            //Console.WriteLine(res13);

            //7.Evaluate the following expression if age = 18 and limit = 18: || (age >= limit && age == limit)
            //int age = 18;
            //int limit = 18;
            //bool res14 = age >= limit && age == limit;
            //Console.WriteLine(res14);



            //3. Assignment Operators (= += -= *= /= %=) 

            // 1.If a = 20, find the final value after executing: a += 10; a *= 2; a -= 15;
            //int a = 20;
            //a += 10;
            //a *= 2;
            //a -= 15;
            //Console.WriteLine(a);

            //2. If num = 100, find the final value: num /= 4; num += 15; num *= 2; 
            //int  num = 100;
            //num/= 4;
            //num += 15;
            //num *= 2;
            //Console.WriteLine(num);

            //3. If x = 50, find the final value: x -= 10; x %= 7; x *= 5; 
            //int x = 50;
            //x -= 10;
            //x %= 7;
            //x *= 5;
            //Console.WriteLine(x);


            //4.If value = 25, find the final value: value *= 4; value /= 5; value += 12; value %= 10
            //int value = 25;
            //value *= 4;
            //value /= 5;
            //value %= 3;
            //Console.WriteLine(value);

            //5.If number = 80, find the final value: number -= 20; number /= 2; number += 15; number *= 3;
            //int number = 80;
            //number -= 20;
            //number /= 2;
            //number += 15;
            //number *= 3;
            //Console.WriteLine(number);

            //6.If p = 45, find the final value: p += 15; p %= 10; p *= 4; p -= 5

            //int p = 45;
            //p += 15;
            //p %= 10;
            //p *= 4;
            //p -= 5;
            //Console.WriteLine(p);


            //7.If score = 100, find the final value after executing: score /= 5; score += 18; score *= 2; score -= 10; score %= 7
            //int score = 100;
            //score /= 5;
            //score += 18; 
            //score *= 2; 
            //score -= 10; 
            //score %= 7;
            //Console.WriteLine(score);


            //4.Arithmetic Operators(+-* / %)
            //1.Evaluate the following expression if a = 20, b = 6, and c = 4: 
            //int a, b, c;
            //a = 20;
            //b = 6;
            //c = 4;
            //int res = a + b * c - a / b + a % c;
            //Console.WriteLine(res);

            //2.Find the result if x = 25, y = 4, and z = 3: x* y +x % y - z * 2
            //int x, y, z;
            //x = 25;
            //y = 4;
            //z = 3;
            //int result = x * y + x % y - z * 2;
            //Console.WriteLine(result);


            //3.Evaluate the following expression: 100 / 5 + 25 % 4 * 3 - 6
            //int result1 = 100 / 5 + 25 % 4 * 3 - 6;
            //Console.WriteLine(result1);


            //4.Find the result of: 50 - 8 * 3 + 20 / 4 + 17 % 5
            //int reslt2 = 50 - 8 * 3 + 20 / 4 + 17 % 5;
            //Console.WriteLine(reslt2);

            //5.Evaluate the following expression if a = 15, b = 4, and c = 3: a* b -c + a % b * 2
            //int a, b, c;
            //a = 15;
            //b = 4;
            //c = 3;
            //int result3 = a * b - c + a % b * 2;
            //Console.WriteLine(result3);

            //6.Find the result of: 120 / 6 + 18 * 3 - 25 % 4 + 7
            //int reslut4 = 120 / 6 + 18 * 3 - 25 % 4 + 7;
            //Console.WriteLine(reslut4);

            //7.Evaluate the following expression if x = 30, y = 5, and z = 4:x / y * z + x % y - z * 2 
            //int x, y, z;
            //x = 30;
            //y = 5;
            //z = 4;
            //int result5 = x / y * z + x % y - z * 2;
            //Console.WriteLine(result5);

            //5.Conditional / Ternary Operator(?:)
            //1.Find the result if a = 25 and b = 40: a > b ? a : b
            //int a = 25;
            //int b = 40;

            //Console.WriteLine(a > b ? a : b);

            //2.Evaluate the following expression if marks = 82: marks >= 80 ? "Excellent" : marks >= 60 ? "Good" : "Average"
            //int marks = 82;

            //Console.WriteLine(
            //    marks >= 80 ? "Excellent" :
            //    marks >= 60 ? "Good" :
            //    "Average"
            //);


            //3.Find the result if age = 17 and marks = 75: age >= 18 && marks >= 60 ? "Eligible" : "Not Eligible"
            //int age = 17;
            //int marks = 75;

            //Console.WriteLine(age >= 18 && marks >= 60 ? "Eligible" : "Not Eligible");

            //4.Evaluate the following expression if a = 15, b = 25, and c = 20: a > b ? a : b > c ? b : c
            //int a = 15;
            //int b = 25;
            //int c = 20;
            //Console.WriteLine(a > b ? a : b > c ? b : c);

            //5. Find the result if num = 45: num > 0 ? (num % 2 == 0 ? "Positive Even" : "Positive Odd") : "Negative" 
            //int num = 45;
            //Console.WriteLine(num > 0 ? (num % 2 == 0 ? "Positive Even" : "Positive Odd") : "Negative");


            //6.Evaluate the following expression if salary = 45000: salary >= 50000 ? "High" : salary >= 30000 ? "Medium" : "Low"
            //int salary = 45000;
            //Console.WriteLine(salary >= 50000 ? "High" : salary >= 30000 ? "Medium" : "Low");

            //7.Find the result if a = 10, b = 20, and c = 15: a > b ? a : b > c ? b : c
            //int a = 10;
            //int b = 20;
            //int c = 15;
            //Console.WriteLine(a > b ? a : b > c ? b : c);




            //2*5*10*15*20
            //int mul = 1;
            //for (int i = 2; i <= 20;)
            //{
            //    mul *= i;
            //    if (i == 2)
            //        i += 3;
            //    else
            //        i += 5;

            //}
            //Console.WriteLine($"output={mul}");

            //x*(x+1)*(x+2).....(x+10)
            //int x;
            //Console.WriteLine("enter a number");
            //x=Convert.ToInt32(Console.ReadLine());
            //int multi = 1;
            //for (int i=1;i<=11;i++)
            //{
            //    multi *= x;
            //    x += i;
            //}
            //Console.WriteLine($"output= {multi}");


            //2+5+9+14+20
            //int n = 2;
            //int sum = 0;
            //for (int i = 2; i <= 20; i = i + n) ;
            //{
            //    sum += i;
            //    n = n + 1;

            //}
            //Console.WriteLine(sum);


            //2,3,5,8,13,21,34,55,
            //int a = 2;
            //int b = 3;
            //Console.WriteLine(a+"\n"+b);
            //for (int n = 5; n <= 55; n = a + b)
            //{ 
            //    Console.WriteLine(n);
            //    a = b;
            //    b = n;
            //}

            //fibonnaccci series

            string name;
            Console.WriteLine("Enter a vlaid Name : ");
            name= Console.ReadLine();
            bool flag = true;
            foreach (char n in name)
            {
                if (!((n >= 'A' && n <= 'Z') || (n >= 'a' && n <= 'z') || n == ' '))
                {

                    flag = false;
                    break;
                }
                if (flag) {
                    Console.WriteLine("Valid Name");
                }
                else
                {
                    Console.WriteLine("Invalid Name");
                }




            }

        }
    }
}

