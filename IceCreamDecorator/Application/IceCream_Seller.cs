using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceCreamDecorator.Domain.Entities;

namespace IceCreamDecorator.Application
{
    public class IceCream_Seller
    {

        public void Sell_Smarties_IceCream()
        {
            NormalIceCream NormalIceCream = new NormalIceCream();
            Chocolate_IceCream Chocolate_IceCream = new Chocolate_IceCream(NormalIceCream);
            SmartiesIceCream Smarties = new SmartiesIceCream(Chocolate_IceCream);

            Console.WriteLine("Sell " + Smarties.SellIceCream());
        }


        public void Sell_Chocolate_IceCream()
        {
            NormalIceCream NormalIceCream = new NormalIceCream();
            Chocolate_IceCream Chocolate_IceCream = new Chocolate_IceCream(NormalIceCream);

            Console.WriteLine("Sell " + Chocolate_IceCream.SellIceCream());

        }

        public void Sell_Normal_IceCream()
        {
            NormalIceCream NormalIceCream = new NormalIceCream();

            Console.WriteLine("Sell " + NormalIceCream.SellIceCream());
        }
    }
}
