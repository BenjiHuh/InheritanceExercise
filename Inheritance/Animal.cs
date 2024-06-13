using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        private int Age { get; set; }
        private int Legs { get; set; }
        private string Name { get; set; }
        private int Weight { get; set; }

        public Animal()
        {
            int Age = 0;
            int Legs = 0;
            string Name = "";
            int Weight = 0;
        }
        public Animal(string inputName)
        {
            Age = 0;
            Legs = 0;
            Name = inputName;
            Weight = 0;
        }
        public Animal(string inputName, int inputAge)
        {
            Age = inputAge;
            Legs = 0;
            Name = inputName;
            Weight = 0;
        }
        public Animal(string inputName, int inputAge, int inputWeight)
        {
            Age = inputAge;
            Legs = 0;
            Name = inputName;
            Weight = inputWeight;
        }
        public Animal(string inputName, int inputAge, int inputWeight, int inputLegs)
        {
            Age = inputAge;
            Legs = inputLegs;
            Name = inputName;
            Weight = inputWeight;
        }

        public void PresentAnimal()
        {
            Console.WriteLine($"Animal name: {Name}, Animal Age: {Age}, Animal: {Weight}, Number of legs: {Legs}");
        }

    }
}
