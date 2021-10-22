using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[10];
            words = words.Select((word, index) =>
            {
                Console.Write(string.Format("Введите строку {0}: ", (index + 1)));
                return Console.ReadLine();
            }).ToArray();
            Console.WriteLine("Массив строк: ");
            int i = 0;
            Array.ForEach(words, x =>
            {
                Console.WriteLine((++i).ToString() + ": " + x);
            });
            Console.ReadKey(true);
        }
    }
}
