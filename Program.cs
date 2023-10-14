namespace Labb6MorganWestin
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Simba", 5, 15);
            Elephant elephant = new Elephant("Dumbo", 10, 8);
            Penguin penguin = new Penguin("Pingu", 3, true);

            lion.MakeSound();
            lion.Roar();
            elephant.MakeSound();
            elephant.Trumpet();
            penguin.MakeSound();
            penguin.SlideOnIce();
        }
    }
}