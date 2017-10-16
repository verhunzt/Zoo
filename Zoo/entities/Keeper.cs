using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.entities
{
    class Keeper
    {


        public bool AddAnimal(List<Cage> cages,Animal a)
        {
            foreach (var cage in cages)
            {
                if (cage.TakenBy != null) continue;

                HashSet<Type> temp = new HashSet<Type>();
                foreach (var terrain in cage.Terrains)
                {
                    temp.Add(terrain.GetType());
                }
                if (a.Type.IsSubsetOf(temp))
                {
                    cage.TakenBy = a;
                    Console.WriteLine("Gefangen!");
                    return true;


                }


            }




            return false;

        }

    }
}
