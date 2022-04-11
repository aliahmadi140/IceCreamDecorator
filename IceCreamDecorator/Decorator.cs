using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamDecorator
{
    internal class Decorator : IceCreameSeller
    {
        protected IceCreameSeller iceCreameSeller;

        public Decorator(IceCreameSeller iceCreameSeller)
        {
            this.iceCreameSeller = iceCreameSeller;
        }

        public void SetIceCream(IceCreameSeller iceCreameSeller)
        {
            this.iceCreameSeller = iceCreameSeller;
        }

        public override string SellIceCream()
        {
            if (iceCreameSeller != null)
            {
                return iceCreameSeller.SellIceCream();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
