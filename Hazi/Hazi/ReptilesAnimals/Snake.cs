using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi.ReptilesAnimals
{
    class Snake : Reptiles
    {
        protected int length { get; set; }
        protected bool toxic { get; set; }
        public Snake(int _length,bool _toxic, int _age) : base(_age)
        {
            length = _length;
            toxic = _toxic;
        }
    }
}
