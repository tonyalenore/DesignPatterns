using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.AbstractFactory
{
    public class BasicMenuFactory : IMenuFactory
    {
        public IBreakfastMenu CreateBreakfastMenu()
        {
            return new BasicBreakfast();
        }

        public ILunchMenu CreateLunchMenu()
        {
            return new BasicLunch();
        }
    }
}
