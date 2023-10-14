using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6MorganWestin
{
    public class Penguin : Animal
    {
        public bool CanSwim { get; set; }

        public Penguin(string name, int age, bool canSwim)
            : base(name, age, "Penguin", "Polar", true)
        {
            this.CanSwim = canSwim;
        }

        public void SlideOnIce()
        {
            Console.WriteLine("The penguin slides on the ice with joy!");
        }
    }

}
