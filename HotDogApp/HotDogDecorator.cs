using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotDogApp
{
    abstract class HotDogDecorator : HotDog
    {
        protected HotDog hotdog;
        public HotDogDecorator(string n, HotDog hotdog)
            : base(n)
        {
            this.hotdog = hotdog;
        }
    }
}
