using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace meowCat
{

    public class Cat: IMeowable
    {

        public string Name { get; set; }
        private int Count;
        public Cat(string name)
        {
            this.Name = name;
            this.Count = 0;
        }
        public override string ToString() {
            return $"кот:{this.Name}";
        }
        public void Meow()
        {
            Console.WriteLine($"{ this.Name}:мяу!");
            Count++;
        }
        public int GetCount()
        {
            return this.Count;
        }
        public void Meow(int n)
        {
            Console.Write($"{this.Name}:");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("мяу-");
            }
            Console.WriteLine("мяу!");
            Count += n;
        }
    }
}
