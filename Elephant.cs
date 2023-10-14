using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6MorganWestin
{
    public class Elephant : Animal
    {
        public int TrunkLength { get; set; }

        public Elephant(string name, int age, int trunkLength)
            : base(name, age, "Elephant", "Jungle", false)
        {
            this.TrunkLength = trunkLength;
        }

        public void Trumpet()
        {
            Console.WriteLine("The elephant trumpets with its long trunk!");
        }
    }

}
