using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotDogApp
{
    class BeefDog : HotDog
    {
        public BeefDog()
            : base("Beef Hot Dog")
        {
        }
        public override int GetCost()
        {
            return 15000;
        }
    }
}
