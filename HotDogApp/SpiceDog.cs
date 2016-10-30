using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotDogApp
{
    class SpiceDog : HotDogDecorator
    {
        private Spice spice;
        public SpiceDog(HotDog hotdog, Spice spice)
            : base(hotdog.Name +" "+ spice.ToString(), hotdog)
        {
            this.spice = spice;
        }
        public enum Spice { Catcup, Mayo, Mustard }
        public override int GetCost()
        {
            return hotdog.GetCost() + 1500;
        }
    }
}
