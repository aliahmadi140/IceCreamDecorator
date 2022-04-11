using IceCreamDecorator.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamDecorator.Domain.Entities
{
    internal class NormalIceCream : IceCreameSeller
    {
        public override string SellIceCream()
        {
            return "Normal IceCream";
        }
    }
}
