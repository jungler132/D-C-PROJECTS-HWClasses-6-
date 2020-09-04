using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkMethods_Class_5
{
    class Massiv5
    {
        private int point;
        private int n;
        int[] massiv;
        public int N
        {
            get
            {
                return n = tryparse();
            }
            private set { }
        }
        
        public int POINT
        {
            private get
            { 
                return point; 
            }
            set
            {
                
            }
        }
        public Massiv5()
        {
            n = N;
            massiv = new int[n];
        }
        public void vvod_Massiva()
        {
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = tryparse();
            }
        }
        public void vivodMassiva()
        {
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write(massiv[i] + "_");
            }
        }
        public void Sortirovka()
        {
            Array.Sort(massiv);
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write(massiv[i] + "_");
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
