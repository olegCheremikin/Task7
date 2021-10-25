using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double c1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double c2 = double.Parse(Console.ReadLine());
            if ((S(a1, b1, c1) > S(a2, b2, c2)))
            {
                Console.WriteLine("Площадь первого треуголька больше");
            }
            else
            {
                Console.WriteLine("Площадь второго треуголька больше");
            }
            Console.Read();
        }
        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(Math.Abs(p * (p - a) * (p - b) * (p - c)));
            return S;
        }
    }
}
