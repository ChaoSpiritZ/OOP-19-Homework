using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    public abstract class Human
    {
        public abstract string Name { get; set; }
        private int age;

        public Human(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {age}";
        }
    }
}
