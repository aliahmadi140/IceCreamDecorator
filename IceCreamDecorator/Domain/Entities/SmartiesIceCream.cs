using IceCreamDecorator.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamDecorator.Domain.Entities
{
    internal class SmartiesIceCream:Decorator
    {
        public SmartiesIceCream(IceCreameSeller iceCreameSeller) : base(iceCreameSeller)
        {
        }

        public override string SellIceCream()
        {

            return $"Smarties IceCrame({base.SellIceCream()})";
        }
    }
}
