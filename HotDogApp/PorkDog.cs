using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotDogApp
{
    class PorkDog : HotDog
    {
        public PorkDog()
            : base("Pork Hot Dog")
        {
        }
        public override int GetCost()
        {
            return 13000;
        }
    }
}
