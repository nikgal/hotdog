using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotDogApp
{
    abstract class HotDog
    {
        public HotDog(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }
}
