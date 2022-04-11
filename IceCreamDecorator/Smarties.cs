using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamDecorator
{
    internal class Smarties:Decorator
    {
        public Smarties(IceCreameSeller iceCreameSeller) : base(iceCreameSeller)
        {
        }

        public override string SellIceCream()
        {

            return $"Smarties IceCrame({base.SellIceCream()})";
        }
    }
}
