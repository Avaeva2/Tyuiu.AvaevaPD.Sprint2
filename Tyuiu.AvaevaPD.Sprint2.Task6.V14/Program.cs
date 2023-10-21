using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AvaevaPD.Sprint2.Task6.V14.Lib;

namespace Tyuiu.AvaevaPD.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите номер месяца: ");
            int numDay = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numDay < 1) || (numDay > 12))
            {
                res = "Введите неверное значение!";
            }
            else
            {
                res = "Этот месяц:" + ds.FindDayName(numDay);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
