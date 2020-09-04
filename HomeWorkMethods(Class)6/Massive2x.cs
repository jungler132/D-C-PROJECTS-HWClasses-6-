using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkMethods_Class_6
{
    class Massive2x
    {
        private int n1 = 0;
        private int n2 = 0;
        int[,] massiv2;

        public int counter
        {
            get
            {
                return (n1 * n2);
            }
            set
            {

            }
        }
        public Massive2x(int gorizont, int vertikal )
        {
            n1 = gorizont;
            n2 = vertikal;
            massiv2 = new int[n1, n2];
        }
        public void vvod_v_massiv()
        {
            for (int i = 0; i < n1; i++)
            {
                for (int i_1 = 0; i_1 < n2; i_1++)
                {
                    massiv2[i, i_1] = tryparse();
                }
            }
        }
        public void Na_Ekran()
        {
            for (int i = 0; i < n1; i++)
            {
                for (int i_1 = 0; i_1 < n2; i_1++)
                {
                    Console.Write(massiv2[i, i_1] + " ");
                }
            }
        }
        public int tryparse()
        {
            int num1;
            bool triger = false;
            do
            {
                Console.WriteLine($"input number");
                if (int.TryParse(Console.ReadLine(), out num1))
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

        