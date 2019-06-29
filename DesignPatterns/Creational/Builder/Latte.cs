namespace DesignPatterns.Creational.Builder
{
    public class Latte : CoffeeBuilder
    {
        private readonly string _flavor;
        private readonly string _milk;
        private readonly string _size;
        private readonly string _sweetener;

        public Latte(string flavor, string milk, string size, string sweetener)
        {
            coffee = new Coffee();
            _flavor = flavor;
            _milk = milk;
            _size = size;
            _sweetener = sweetener;
        }

        public override void Flavor()
        {
            coffee["flavor"] = _flavor;
        }

        public override void Milk()
        {
            coffee["milk"] = _milk;
        }

        public override void Size()
        {
            coffee["size"] = _size;
        }

        public override void Sweetener()
        {
            coffee["sweetener"] = _sweetener;
        }
    }
}