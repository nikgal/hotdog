using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotDogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HotDog hotdog = new PorkDog();
            hotdog = new SpiceDog(hotdog, SpiceDog.Spice.Catcup);
            hotdog = new BunDog(hotdog, BunDog.Bun.Franch);
            Console.WriteLine("Name: {0} price: {1}", hotdog.Name, hotdog.GetCost());
            Console.Read();
        }
    }
}
