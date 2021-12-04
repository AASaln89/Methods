using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_куб
{
    class Program
    {
        static void Main(string[] args)
        {
            // Площадь и объем куба по длине ребра
            Console.WriteLine("Площадь и объем куба по длине ребра");
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            CalcSV(a, out S, out V);
            Console.WriteLine("Площадь поверхности куба = {0}", S);
            Console.WriteLine("Объем куба = {0}", V);
            Console.ReadKey();
        }
        static void CalcSV(int a, out double S, out double V) 
        {
            V = a * a * a;
            S = a * a * 6;
        }
    }
}
