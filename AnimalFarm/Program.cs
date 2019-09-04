using AnimalFarm.Sounds;
using System;

namespace AnimalFarm {
    class Program {

        static void Main(string[] args) {

            var cow = new Cow(new Moo());
            cow.Speak();

            var cat = new Cat(new Meow());
            cat.Speak();

            var catow = new Catow(new Meooooow());
            catow.Speak();
        }
    }
}
