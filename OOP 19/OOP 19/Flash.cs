using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    class Flash : Human, IFlash
    {
        public override string Name { get; set; }
        public int Voltage { get; private set; }

        public Flash(string name, int age, int voltage) : base(name, age)
        {
            Voltage = voltage;
        }

        public void ActivateSuperPowers()
        {
            FireLightnings();
        }

        public void FireLightnings()
        {
            Console.WriteLine("BZZZZZZZZZZZZZZT!!!!");
        }

        public override string ToString()
        {
            return base.ToString() + $"Voltage: {Voltage}";
        }
    }
}
