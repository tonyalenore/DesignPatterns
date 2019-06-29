using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.AbstractFactory
{
    public class KetoMenuFactory : IMenuFactory
    {
        public IBreakfastMenu CreateBreakfastMenu()
        {
            return new KetoBreakfast();
        }

        public ILunchMenu CreateLunchMenu()
        {
            return new KetoLunch();
        }
    }
}
