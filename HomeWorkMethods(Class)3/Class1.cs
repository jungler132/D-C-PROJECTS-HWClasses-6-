using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkMethods_Class_3
{
    class PramoUgol
    {
        public double a;
        public double b;
        public struct koordinati
        {
            public double a;
            public double b;
        }
        public PramoUgol()
        {
            Console.WriteLine("Введите сторону а");
            a = tryparse(0);
            Console.WriteLine("Введите сторону b");
            b = tryparse(0);
        }
        public void DliniStoron()
        {
            Console.Write("Длины сторон прямоугольника - ");
            Console.WriteLine($"Сторона  \"a\"--{a}, cторона  \"b\"--{b} ");
        }
        public void PerimPram()
        {
            double perim = (a + b) * 2;
            Console.Write($"Периметр прямоугольника равен  --  {perim} .");
        }
        public void PloshadPram()
        {
            double ploshadpram = a * b;
            Console.Write($"Площадь прямоугольника равен  --  {ploshadpram} .");
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
