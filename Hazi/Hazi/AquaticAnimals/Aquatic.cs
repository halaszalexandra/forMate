using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi
{
    class Aquatic : Animal
    {
        public Aquatic(int _age) : base(_age)
        {
        }

        public virtual void Swim()
        {
            // Swim in a ocean
        }
    }
}
