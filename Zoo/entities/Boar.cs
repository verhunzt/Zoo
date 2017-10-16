using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.entities
{
    class Boar : Animal
    {
        public override HashSet<Type> Type { get; }

        public Boar()
        {
            Type = new HashSet<Type>()
            {
                typeof(Steppe),
                typeof(Water)
            };

        }
    }
}
