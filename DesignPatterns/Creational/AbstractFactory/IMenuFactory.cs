using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.AbstractFactory
{
    public interface IMenuFactory
    {
        IBreakfastMenu CreateBreakfastMenu();

        ILunchMenu CreateLunchMenu();
    }
}
