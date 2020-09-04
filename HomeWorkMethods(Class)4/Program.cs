using System;

namespace HomeWorkMethods_Class_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Money num = new Money();
            Money num_1 = new Money();
            num_1.NOMIN = num.Nomin_1();
            num_1.COUNT_NOMIN = num.Count_nomin_1();
            num_1.SUMM = num.Summ_Money();
            num.showBalance();
            num.Check_Price();
            num.Stuff_Count();
        }
    }
}
