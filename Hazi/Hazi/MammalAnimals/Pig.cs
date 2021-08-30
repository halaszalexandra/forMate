using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi.MammalAnimals
{
    class Pig : Mammal
    {
        protected string color { get; set; }
        public Pig(string _color, int _age) : base(_age)
        {
            color = _color;
        }

        public override void sprint()
        {
            //run in mud
        }
    }
}
