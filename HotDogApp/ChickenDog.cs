using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotDogApp
{
    class ChickenDog : HotDog
    {
        public ChickenDog()
            : base("Chicken Hot Dog")
        {
        }
        public override int GetCost()
        {
            return 12000;
        }
    }
}
