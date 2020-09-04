using System;

namespace HomeWorkMethods_Class_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int x_1 = int.Parse(Console.ReadLine());
            Massive2x mass = new Massive2x(x,x_1);
            mass.vvod_v_massiv();
            mass.Na_Ekran();
            Console.Out.WriteLine($"Element count" + " ", mass.counter);
        }
    }
}
