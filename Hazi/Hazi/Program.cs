using Hazi.AquaticAnimals;
using Hazi.MammalAnimals;
using Hazi.ReptilesAnimals;
using System;

namespace Hazi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mammal animals
            Cat dome = new Cat(5);
            Dog dio = new Dog(2);
            Lion leo = new Lion(8);
            Pig gigi = new Pig("pink",8);

            //Reptiles animals
            Aligator mimi = new Aligator(2);
            Snake rep = new Snake(1000, true, 1);

            mimi.wait();
            


            //Aquatic animals
            Carp carp = new Carp(100,5);
            Shark sshark = new Shark(8);

            sshark.Swim();
            carp.Swim();

            dome.eatAllMouse();
            dio.guardsTheHouse();
            
        }
    }
}
