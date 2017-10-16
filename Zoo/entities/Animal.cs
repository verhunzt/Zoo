using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.entities
{
    abstract class Animal
    {

        public abstract HashSet<Type> Type { get; }
        
    }
}
