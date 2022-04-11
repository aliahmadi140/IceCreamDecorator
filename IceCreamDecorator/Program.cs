using IceCreamDecorator;

NormalIceCream NormalIceCream =new NormalIceCream();
Chocolate_IceCream Chocolate_IceCream =new Chocolate_IceCream(NormalIceCream);
Smarties Smarties =new Smarties(Chocolate_IceCream);
 
Console.WriteLine("Sell "+Smarties.SellIceCream());
