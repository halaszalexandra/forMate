using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi.AquaticAnimals
{
    class Carp : Aquatic
    {
        public int weight { get; set; }
        
        public Carp(int _weigth, int _age) : base(_age)
        {
            weight = _weigth;    
        }

        public override void Swim()
        {
            // Swim in a water
        }


        
    }
}
