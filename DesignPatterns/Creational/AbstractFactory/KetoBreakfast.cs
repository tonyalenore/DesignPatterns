using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.AbstractFactory
{
    public class KetoBreakfast : IBreakfastMenu
    {
        public string GetMenu()
        {
            return "Keto Breakfast: Bacon, eggs, coffee with cream and splenda";
        }
    }
}
