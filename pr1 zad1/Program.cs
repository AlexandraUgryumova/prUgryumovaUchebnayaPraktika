using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_zad1
{
    class Program
    {
        static void Main (string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введи имя кота");
                string name = Console.ReadLine();
                Console.WriteLine("Введи вес кота");
                string ves = Console.ReadLine();
                Cat cat = new Cat(name, ves);
                if (cat.Check())
                {
                    cat.Meow();
                    Console.ReadKey();
                } 
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
