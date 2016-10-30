using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotDogApp
{
    class BunDog : HotDogDecorator
    {
        private Bun bun;
        public enum Bun { Weat, Rye, Franch }
        public BunDog(HotDog hotdog, Bun bun)
            : base(hotdog.Name + " "+bun.ToString() , hotdog)
        {
            this.bun = bun;
        }
        public override int GetCost()
        {
            return hotdog.GetCost() + 2000;
        }
    }
}
