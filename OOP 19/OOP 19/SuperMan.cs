using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    class SuperMan : Human, IFly
    {
        public override string Name { get; set; }
        public int Speed { get; private set; }

        public SuperMan(string name, int age, int speed) : base(name, age)
        {
            Speed = speed;
        }

        public void ActivateSuperPowers()
        {
            Fly();
        }

        public void Fly()
        {
            Console.WriteLine("zooooooooooom!");
        }

        public override string ToString()
        {
            return base.ToString() + $"Speed: {Speed}";
        }
    }
}
