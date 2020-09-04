using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkMethods_Class_4
{
    class Money
    {
        private double nomin;
        private double count_nomin;
        private double stuff;
        private double summ;
        public double NOMIN
        {
            get
            {
                return nomin;
            }
            set
            {
                nomin = value;
            }
        }
        public Money()
        {
            nomin = 0;
            count_nomin = 0;
            stuff = 0;
        }
        public double COUNT_NOMIN
        {
            get
            {
                return count_nomin;
            }
            set
            {
                count_nomin = value;
            }
        }
        public double STUFF
        {
            get
            {
                return stuff;
            }
            set
            {
                stuff = value;
            }
        }
        public double SUMM
        {
            get
            {
                return summ;
            }
            set
            {
                summ = value;
            }
        }
        public double Nomin_1()
        {
            Console.WriteLine("Nominal");
            return NOMIN = tryparse(0);
        }
        public double Count_nomin_1()
        {
            Console.WriteLine("Count");
            return COUNT_NOMIN = tryparse(0);
        }
        public void showBalance()
        {
            Console.WriteLine($"nominal -- {nomin} AZN / count -- {count_nomin}. ");
        }
        public double Summ_Money()
        {
            SUMM = NOMIN * COUNT_NOMIN;
            Console.WriteLine($"SUMM = {SUMM}");
            return SUMM;
        }
        public double Check_Price()
        {
            Console.WriteLine("Input price for stuff");
            STUFF = tryparse(0);
            if(STUFF > (NOMIN * COUNT_NOMIN))
            {
                Console.WriteLine("You don't have enough money");
            }
            else
            {
                Console.WriteLine("You just bought it");
            }
            return stuff;
        }
        public double Stuff_Count()
        {
            Console.WriteLine("Input stuff price");
            double stuff_price = tryparse(0);
            double stuff_count = (NOMIN * COUNT_NOMIN) / stuff_price;
            stuff_count = Math.Floor(stuff_count);
            Console.WriteLine($"U can buy {stuff_count} pieces.");
            return stuff_count;
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
