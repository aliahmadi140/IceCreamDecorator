using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamDecorator
{
    internal class NormalIceCream : IceCreameSeller
    {
        public override string SellIceCream()
        {
            return "Normal IceCream";
        }
    }
}
