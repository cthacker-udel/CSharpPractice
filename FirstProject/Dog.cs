using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Dog
    {

        public string name;
        public string furColor;
        public string breed;
        public bool isSitting;
        public bool isWalking;

        public Dog(string newName, string newFurColor, string newBreed) {
            this.name = newName;
            this.furColor = newFurColor;
            this.breed = newBreed;

        }

        public void bark() {
            Console.WriteLine("WOOF");
        }



    }
}
