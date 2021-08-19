using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Cat
    {

        private string name;
        private string breed;
        private string color;
        int age;
        int weight;
        int height;

        public Cat(string theName, string theBreed, string theColor, int theAge, int theWeight, int theHeight) {
            this.name = theName;
            this.breed = theBreed;
            this.color = theColor;
            this.age = theAge;
            this.weight = theWeight;
            this.height = theHeight;
        }

        public string GetName() {
            return this.name;
        }

        public string GetBreed() {
            return this.breed;
        }

        public string GetColor() {
            return this.color;
        }

        public int GetAge() {
            return this.age;
        }

        public int GetWeight() {
            return this.weight;
        }

        public int GetHeight() {
            return this.height;
        }

    }
}
