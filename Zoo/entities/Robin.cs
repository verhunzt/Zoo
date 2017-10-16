using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.entities
{
     class Robin : Animal
    {
        public override HashSet<Type> Type { get; }

        public Robin()
        {
            Type = new HashSet<Type>
            {
                typeof(Steppe)
            };
        }
    }
}
