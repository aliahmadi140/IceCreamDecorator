using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamDecorator
{
    internal class Chocolate_IceCream : Decorator
    {
        public Chocolate_IceCream(IceCreameSeller iceCreameSeller) : base(iceCreameSeller)
        {
        }

        public override string  SellIceCream()
        {
            return $"Chocolate IceCream({base.SellIceCream()})";
        }
    }
}
