using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm {
    class Catow : ISpeak {

        ISpeak speak;

        public void Speak() {
            speak.Speak();
        }

        public Catow(ISpeak speak) {
            this.speak = speak;
        }
    }
}
