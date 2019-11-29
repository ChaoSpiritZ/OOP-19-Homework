using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash barry = new Flash("Barry", 46, 100);
            SpiderMan peter = new SpiderMan("Peter", 21, 200);
            SuperMan clark = new SuperMan("Clark", 38, 5000);

            //ISuperHero[] superheroes = new ISuperHero[3] { barry, peter, clark };
            //foreach (ISuperHero item in superheroes)
            //{
            //    ActivateHero(item);
            //}
            //IdentifyHero(barry);
            //IdentifyHero(peter);
            //IdentifyHero(clark);

            //GetMoreHeroData(barry);
            //GetMoreHeroData(peter);
            //GetMoreHeroData(clark);

            CreateHero("parry");
            CreateHero("barry");
            CreateHero("peter griffin");
            CreateHero("peter");
            CreateHero("cloak");
            CreateHero("clark");
        }

        static void ActivateHero(ISuperHero superhero)
        {
            superhero.ActivateSuperPowers();
        }

        static void IdentifyHero(ISuperHero superhero)
        {
            ISuperHero sh = superhero;
            if(sh is Flash)
            {
                Console.WriteLine("Flash detected!");
            }
            if(sh is SpiderMan)
            {
                Console.WriteLine("SpiderMan detected!");

            }
            if (sh is SuperMan)
            {
                Console.WriteLine("SuperMan detected!");

            }
        }

        static void GetMoreHeroData(ISuperHero superhero)
        {
            ISuperHero sh = superhero as Flash;
            if(sh != null)
            {
                Flash fl = (Flash) sh;
                Console.WriteLine("Voltage: " + fl.Voltage);
            }

            sh = superhero as SpiderMan;
            if (sh != null)
            {
                SpiderMan sp = (SpiderMan)sh;
                Console.WriteLine("String left: " + sp.WebLeft);
            }

            sh = superhero as SuperMan;
            if(sh != null)
            {
                SuperMan su = (SuperMan)sh;
                Console.WriteLine("Speed: " + su.Speed);
            }
        }

        static ISuperHero CreateHero(string potentialHero)
        {
            Console.WriteLine($"checking if {potentialHero} can be a superhero... ");
            if(potentialHero.ToLower() == "barry")
            {
                Flash flash = new Flash("FLASH!", 30, 130);
                Console.WriteLine($"{potentialHero} is now running at lightning speed!");
                return flash;
            }
            if (potentialHero.ToLower() == "peter")
            {
                SpiderMan spiderman = new SpiderMan("SPIDERMAN!", 20, 250);
                Console.WriteLine($"{potentialHero} is now swinging across the city!");

                return spiderman;
            }
            if (potentialHero.ToLower() == "clark")
            {
                SuperMan superman = new SuperMan("SUPERMAN!", 40, 9001);
                Console.WriteLine($"{potentialHero} is now flying super fast!");

                return superman;
            }
            Console.WriteLine($"{potentialHero} is not good enough to be a superhero");
            return null;
        }
    }
}
