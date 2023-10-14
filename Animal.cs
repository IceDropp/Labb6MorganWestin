using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6MorganWestin
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public bool IsCarnivore { get; set; }

        public Animal(string name, int age, string species, string habitat, bool isCarnivore)
        {
            this.Name = name;
            this.Age = age;
            this.Species = species;
            this.Habitat = habitat;
            this.IsCarnivore = isCarnivore;
        }

        public void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }

        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }

}
