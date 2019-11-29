using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    class SpiderMan : Human, IClimb
    {
        public override string Name { get; set; }
        public int WebLeft { get; private set; }

        public SpiderMan(string name, int age,int webLeft) : base(name, age)
        {
            WebLeft = webLeft;
        }

        public void ActivateSuperPowers()
        {
            Climb();
        }

        public void Climb()
        {
            Console.WriteLine("*Climbing noises*");
        }

        public override string ToString()
        {
            return base.ToString() + $"Web left: {WebLeft}";
        }
    }
}
