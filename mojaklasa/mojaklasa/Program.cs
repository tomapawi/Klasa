using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using biblioteka;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadz bok a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wprowadz bok b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            prostokat p = new prostokat();
            Console.WriteLine("Pole prostokata = "+p.pole(a,b));
            Console.WriteLine("Obwod prostokata = "+p.obwod(a, b));
            Console.ReadKey();
        }
    }
}
