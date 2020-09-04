using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkMethods_Class_2
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public struct storoniTreugolnika
        {
            public double a;
            public double b;
            public double c;
        }

        public Triangle()
        {
            Console.WriteLine("Введите сторону а");
            a = tryparse(0);
            Console.WriteLine("Введите сторону b");
            b = tryparse(0);
            Console.WriteLine("Введите сторону c");
            c = tryparse(0);
        }
        public void DliniStoron()
        {
            Console.Write("Длины сторон треугольника - ");
            Console.WriteLine($"Сторона  \"a\"--{a}, cторона  \"b\"--{b} cторона  \"c\"--{c}");
        }
        public void Perimetr()
        {
            double perimetr = a + b + c;
            Console.WriteLine($"Периметр треугольника равен -  {perimetr} ");
        }
        public void Ploshad()
        {
            double poluperim = (a + b + c) / 2;
            double ploshad = Math.Sqrt(poluperim * (poluperim - a) * (poluperim - b) * (poluperim - c));
            Console.WriteLine($"Площадь треугольника равна \"abc\" {ploshad} ");
        }
        public double tryparse(double num1)
        {
            bool triger = false;
            do
            {
                Console.WriteLine($"input number");
                if (double.TryParse(Console.ReadLine(), out num1) && num1 > 0)
                {
                    triger = true;
                }
                else
                {
                    Console.WriteLine("wrong number try again");
                    continue;
                }
            }
            while (triger == false);
            return num1;
        }
        
    }
}
