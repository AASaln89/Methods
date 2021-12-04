using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы
{
    class Program
    {
        static void Main(string[] args)
        {
            // Площадь треугольника по трем сторонам
            Console.WriteLine("Площадь треугольника");
            Console.WriteLine("angle 1. Введите длину стороны a");
            float a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("angle 1. Введите длину стороны b");
            float b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("angle 1. Введите длину стороны c");
            float c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("angle 2. Введите длину стороны a");
            float a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("angle 2. Введите длину стороны b");
            float b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("angle 2. Введите длину стороны c");
            float c2 = Convert.ToInt32(Console.ReadLine());
            double S1, S2;
            CalcSangle(a1, b1, c1, out S1);
            CalcSangle(a2, b2, c2, out S2);
            if (S1 > S2)
            {
                Console.WriteLine("Площадь angle 1 {0} БОЛЬШЕ angle 2 {1}", S1, S2);
            }
            else Console.WriteLine("Площадь angle 2 {1} БОЛЬШЕ angle 1 {0}", S1, S2);
            Console.ReadKey();
        }
        static void CalcSangle(float a, float b, float c, out double S)
        {
            double p = 0;
            p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
