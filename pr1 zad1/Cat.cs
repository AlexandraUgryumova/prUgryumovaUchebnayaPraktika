using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_zad1
{
    class Cat
    {
        private double ves;
        public bool check = true;
        public bool check2 = true;
        public bool Check ()
        {
            if(check&&check2)
            return true;
            else
            {
                return false;
            }
        }
        public string Ves
        {
            get
            {
                return ves.ToString();
            }
            set
            {
                try
                {
                    double hh = Convert.ToDouble(value);
                    if (hh < 0)
                    {
                        Console.WriteLine($"{value} - не может быть весом!!!");
                        check = false;
                    } 
                    else
                    {
                        this.ves = Convert.ToDouble(value);
                    }
                }
                catch
                {
                    Console.WriteLine($"{value} - не может быть весом!!!");
                    check = false;
                }
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    check2 = true;
                    name = value;
                } else
                {
                    check2 = false;
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        public Cat (string CatName, string ves)
        {
            Name = CatName;
            Ves = ves;
        }
        public void Meow ()
        {
            if (check&&check2)
                Console.WriteLine($"{name} весит {ves} кг. и говорит: МЯЯЯЯУ!!!!");
        }
    }
}
