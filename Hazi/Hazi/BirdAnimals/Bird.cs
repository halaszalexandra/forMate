using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi
{
    class Bird : Animal
    {
        private int legsNumber;

        public Bird(int _age) : base(_age)
        {
        }

        public virtual void Fly()
        {
            //Fly in the sky
        }
    }
}
