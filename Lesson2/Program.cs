using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x = 1, y = 2;
            double result_1, result_2, result_3;


            result_1 = -6 * Math.Pow(x,3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
            result_2 = Math.Abs(x) * Math.Asin(x);
            result_3 = Math.Max(x,y);



            //завдання 2


            DateTime now = DateTime.Now;                                   // отримує дату
            int x1 = now.DayOfYear,                                        //кількість днів у році
            x2, 
            year = now.Year,                                               // отримує рік 
            days=0;

             for (int i = 1; i <=12; i++)                                 //рахує кількість днів в поточному році
             {
                 days+=DateTime.DaysInMonth(year, i);
             }
            x2 = days - x1;
            Console.WriteLine("Days left to New Year: " + x2, "\n");
            Console.WriteLine(": " + x2, "\n");
        }
    }
}
