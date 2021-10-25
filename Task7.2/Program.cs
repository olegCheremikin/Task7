using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double V, S;
            GetParam(a, out V, out S);
            Console.WriteLine("Объем куба = {0}", V);
            Console.WriteLine("Площадь поверхности куба = {0}", S);
            Console.ReadKey();
        }
        static void GetParam(int a, out double V, out double S)
        {
            V = a * a * a;
            S = 6 * a * a;
        }
    }
}