using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meowCat
{
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            this.Name = name;
        }
        public void Talk()
        {
            Console.WriteLine($"{this.Name}:человеческая речь - awfu214t");
        }
    }
}
