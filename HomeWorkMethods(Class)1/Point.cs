using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HomeWorkMethods_Class_1
{
    class Point
    {
        private double x;
        private double y;
        public double X
        {
            get
            {
                return x;
            }
            set
            {              
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Point()
        {
            x = 0;
            y = 0;
        }
        public double Point_x()
        {
            return x = tryparse(0);
        }
        public double Point_y()
        { 
            return y = tryparse(0);
        }
        public void Vivod()
        {
            Console.WriteLine($"x={x},y={y}");
        }
        public double Distanciya()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public void Vektor()
        {
            double x_1;
            double y_1;
            Console.Write("Set new X coordinate  -  ");
            x_1 = double.Parse(Console.ReadLine());
            Console.Write("Set new y coordinate  -  ");
            y_1 = double.Parse(Console.ReadLine());
            x = x_1;
            y = y_1;
            Console.WriteLine($"New coordinate point is {x},{y}");
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
