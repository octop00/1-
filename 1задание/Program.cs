using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            Random rnd = new Random();
            int d = rnd.Next(0,100);
            Console.WriteLine("Угадайте заданное число");

            do
            {
                int.TryParse(Console.ReadLine(), out int a);
                if (a > d)
                    Console.WriteLine("Много");
                if (a < d)
                    Console.WriteLine("Мало");
                c = a;
            }
            while (c != d);
            Console.WriteLine("Верно!");
        }
    }
}
