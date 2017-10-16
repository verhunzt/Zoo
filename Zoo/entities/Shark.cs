using System;
using System.Collections.Generic;

namespace Zoo.entities
{
    class Shark : Animal
    {


        public override HashSet<Type> Type { get; }


        public Shark()
        {
            Type = new HashSet<Type>()
            {
                typeof(Water)
            };
        }

    }
}
