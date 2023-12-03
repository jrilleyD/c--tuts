using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float T_mo = 1, T_tu = 3, T_we = -1, T_th = 1, T_fr = -6, T_sa = 0, T_su = 7;
            int daysInWeek = 7;

            float T_avg = (T_mo + T_tu + T_we + T_th + T_th + T_fr + T_sa + T_su) / daysInWeek;

            Console.WriteLine(T_avg);
            Console.ReadKey();
        }
    }
}
