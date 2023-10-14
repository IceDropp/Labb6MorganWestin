using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6MorganWestin
{
    public class Lion : Animal
    {
        public int ManeLength { get; set; }

        public Lion(string name, int age, int maneLength)
            : base(name, age, "Lion", "Savannah", true)
        {
            ManeLength = maneLength;
        }

        public void Roar()
        {
            Console.WriteLine("The lion roars loudly!");
        }
    }
}
