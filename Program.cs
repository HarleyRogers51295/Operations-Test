using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace NewProj
{
    class Program
    {
        static void Main(string[] args)
        {


            int tern1 = int.Parse(Console.ReadLine());
            int tern2 = int.Parse(Console.ReadLine());
            int tern = Tern(tern1, tern2);
            Console.WriteLine(tern);
            
            Console.WriteLine("After entering in your numbers press ENTER.");
            Console.WriteLine("enter in your addition numbers.");
            int add2 = int.Parse(Console.ReadLine()); 
            int add3 = int.Parse(Console.ReadLine());
            int add4 = Add(add2, add3);
            Console.WriteLine($"the total of {add2} and {add3} equils {add4}.");

            Console.WriteLine("enter in your subtraction numbers.");
            int sub2 = int.Parse(Console.ReadLine());
            int sub3 = int.Parse(Console.ReadLine());
            int sub4 = Sub(sub2, sub3);
            Console.WriteLine($"the difference of {sub2} and {sub3} equils {sub4}.");

            Console.WriteLine("enter in your multiplication numbers.");
            int mul2 = int.Parse(Console.ReadLine());
            int mul3 = int.Parse(Console.ReadLine());
            int mul4 = Mul(mul2, mul3);
            Console.WriteLine($"the sum of {mul2} and {mul3} equils {mul4}.");

            Console.WriteLine("enter in your division numbers.");
            int div2 = int.Parse(Console.ReadLine());
            int div3 = int.Parse(Console.ReadLine());
            int div4 = Div(div2, div3);
            Console.WriteLine($"the quotent of {div2} and {div3} equils {div4}.");

            Console.WriteLine("enter in your modulos numbers.");
            int mod2 = int.Parse(Console.ReadLine());
            int mod3 = int.Parse(Console.ReadLine());
            int mod4 = Mod(mod2, mod3);
            Console.WriteLine($"the amount left over of {mod2} and {mod3} equils {mod4}.");

            var pi = 3.14;

            Console.WriteLine("Enter the Radius to find the area of the Circle.");
            double radius = double.Parse(Console.ReadLine());
            double areaOfCircle = AreaOfCircle(pi, radius);
            Console.WriteLine($"The area of the circle based of the " +
                $"radius entered is {areaOfCircle}.");

        }
        public static int Add(int x, int b)
        {
            int add1 = x + b;
            return add1;
        }
        public static int Sub(int x, int b)
        {
            int sub1 = x - b;
            return sub1;

        }
        public static int Mul(int x, int b)
        {
            int mul1 = x * b;
            return mul1;
        }
        public static int Div(int x, int b)
        {
            int div1 = x / b;
            return div1;
        }
        public static int Mod(int x, int b)
        {
            int mod1 = x % b;
            return mod1;
        }
        public static double AreaOfCircle(double pi, double r )
        {
            var POW = Math.Pow(r, 2);
            double area1 = pi * POW;
            return area1;
            
        }
        public static int Tern(int a, int b)
        {
            return (b == 0) ? -1 : a / b;
        }
    }
}
