using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj ciąg liczb rozdzielając je spacją");

            var numbers = CreatingList.CreateList(Console.ReadLine());

            var min = numbers.Min();
            var max = numbers.Max();

            Console.WriteLine($"{max.ToString()} {min.ToString()}");

            Console.ReadLine();

        }
    }
}
