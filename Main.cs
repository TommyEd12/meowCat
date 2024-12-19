using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meowCat
{
    internal class program
    {
        public static void MakeMeows(IEnumerable<IMeowable> meowables)
        {
            foreach (var meowable in meowables)
            {
                meowable.Meow(10);
            }
        }

        static void Main (string [] args) {
            List<IMeowable> meowables = new List<IMeowable> {
                new Cat("Мурзик"),
                new Cat("Федор")
            };
            MakeMeows(meowables);
            meowables[1].Meow();
            Console.WriteLine($"{meowables[1]} промяукал {meowables[1].GetCount()} раз");
            Cat myCat = new Cat("Барсик");
            myCat.Meow();
            myCat.Meow(3);
            Console.WriteLine(myCat.ToString());
            Fraction first = new Fraction(5, 7);
            Fraction second = new Fraction(1, 8);
            Fraction third = new Fraction(1, 100);
            var clone1 = (Fraction)first.Clone();
            int num = 5;
            Console.WriteLine(clone1);
            Console.WriteLine("");
            Console.WriteLine(first.ToString());
            Console.WriteLine(first.ToDouble());
            Console.WriteLine(first.Equals(clone1));
            Console.WriteLine($"{first} + {num} = {first + num}");
            Console.WriteLine($"{first} - {num} = {first - num}");
            Console.WriteLine($"{first} * {num} = {first * num}");
            Console.WriteLine($"{first} / {num} = {first / num}");
            Console.WriteLine($"{first} + {second} = {first + second}");
            Console.WriteLine($"{first} - {second} = {first - second}");
            Console.WriteLine($"{first} * {second} = {first * second}");
            Console.WriteLine($"{first} / {second} = {first / second}");
            Console.WriteLine($"{first} + {second} / {third} - {num} = {first + (second / third) - num}");
        }
        
    }
}
