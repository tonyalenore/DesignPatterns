namespace DesignPatterns.Creational.Builder
{
    public abstract class CoffeeBuilder
    {
        protected Coffee coffee;

        public Coffee Coffee { get { return coffee; } }

        public abstract void Size();

        public abstract void Flavor();

        public abstract void Milk();

        public abstract void Sweetener();
    }
}