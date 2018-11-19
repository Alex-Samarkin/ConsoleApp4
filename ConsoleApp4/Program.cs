using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");
            PrintColor("Как дела?",ConsoleColor.DarkYellow);
            PrintColor("Сегодня неплохая погода, верно?");
            Console.ReadLine();

            double []x= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15,16,17,18,19,20 };
            
            foreach (double d in x)
            {
                StringBuilder stringBuilder = new StringBuilder();
                PrintColor( stringBuilder.AppendFormat("x = {0} x^2= {1} x^3= {2}", d, d * d,d * d * d).ToString());
            }

            Console.ReadLine();

            IEnumerable<double> query =
                x.Where(number => number*number>10*number);
            foreach (double d in query)
            {
                StringBuilder stringBuilder = new StringBuilder();
                PrintColor(stringBuilder.AppendFormat("x = {0} x^2= {1} x^3= {2}", d, d * d, d * d * d).ToString());
            }

            Console.ReadLine();

        }

        private static ConsoleColor PrintColor(string value, ConsoleColor color = ConsoleColor.Green)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = old;
            return old;
        }
    }
}
