﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm {

    class Cow : ISpeak {

        ISpeak speak;

        public void Speak() {
            speak.Speak(); 
        }
        public Cow(ISpeak speak) {
            this.speak = speak;
        }
    }
}
