using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину окружности");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь круга,ограниченного этой окружности равна : {0}", (d * d) / (4 * Math.PI));
            Console.ReadKey();  
        }
    }
}
