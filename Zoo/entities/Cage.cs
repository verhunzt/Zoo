using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.entities
{
    class Cage
    {

        public HashSet<Terrain> Terrains { get; set; }
        public Animal TakenBy { get; set; } = null;

        public Cage(HashSet<Terrain> terrains)
        {
            Terrains = terrains;
        }
    }
}
