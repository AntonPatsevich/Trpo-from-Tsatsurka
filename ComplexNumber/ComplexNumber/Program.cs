using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ComplexNumber
{
    class Program
    {
        public static Complex Sum(Complex a, Complex b)
        {
            return Complex.Add(a, b);
        }
        public static Complex Sub(Complex a, Complex b)
        {
            return Complex.Subtract(a, b);
        }
        public static Complex Mult(Complex a, Complex b)
        {
            return Complex.Multiply(a, b);
        }
        public static Complex Div(Complex a, Complex b)
        {
            return Complex.Divide(a, b);
        }
        public static Complex Invers(Complex a)
        {
            return Complex.Negate(a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Complex: "+new Complex(1, 0));
            Console.WriteLine("Sum: " + Sum(new Complex(12.3, -1.4), new Complex(-6.2, 3.1)));
            Console.WriteLine("Sub: " + Sub(new Complex(4.93, 6.87), new Complex(12.5, 9.6)));
            Console.WriteLine("Mult: " + Mult(new Complex(8.3, 17.5), new Complex(1.4, 6.3)));
            Console.WriteLine("Div: " + Div(new Complex(1.2, 2.3), new Complex(3, -5)));
            Console.WriteLine("Invers: " + Invers(new Complex(1, 0)));
            Console.ReadKey();
        }
    }
}
