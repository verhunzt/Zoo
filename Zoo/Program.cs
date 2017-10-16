using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.entities;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Terrain> t1 = new HashSet<Terrain>()
            {
                new Forest(),
                new Steppe()
            };
            HashSet<Terrain> t2 = new HashSet<Terrain>()
            {
                new Forest(),
                new Water()
            };
            HashSet<Terrain> t3 = new HashSet<Terrain>()
            {
                new Water(),
                new Steppe()
            };
            HashSet<Terrain> t4 = new HashSet<Terrain>()
            {
                new Forest(),
                new Steppe(),
                new Water()
                
            };



            List<Cage> cages = new List<Cage>()
            {
                new Cage(t1),
                new Cage(t2),
                new Cage(t3),
                new Cage(t4)
            };


            Keeper keepkeep = new Keeper();

            Console.WriteLine(keepkeep.AddAnimal(cages, new Boar()));
            


            Console.In.ReadLine();
        }
    }
}
