using System;
using System.Security.Cryptography.X509Certificates;

namespace HomeWorkMethods_Class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Point num = new Point();
            Point num_1 = new Point();
            num_1.X = num.Point_x();  
            num_1.Y = num.Point_y(); 
            num.Vivod();
            Console.WriteLine(" Coordinate point is " + num.Distanciya());
            num.Vektor();
            Console.ReadKey();
        }   
    }
}
 
