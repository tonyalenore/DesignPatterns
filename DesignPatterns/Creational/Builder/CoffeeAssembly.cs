namespace DesignPatterns.Creational.Builder
{
    public class CoffeeAssembly
    {
        public void Assemble(CoffeeBuilder coffeeBuilder)
        {
            coffeeBuilder.Flavor();
            coffeeBuilder.Milk();
            coffeeBuilder.Size();
            coffeeBuilder.Sweetener();
        }
    }
}