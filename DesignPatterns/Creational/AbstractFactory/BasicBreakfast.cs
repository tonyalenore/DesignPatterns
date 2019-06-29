namespace DesignPatterns.Creational.AbstractFactory
{
    public class BasicBreakfast : BreakfastMenu
    {
        public override string GetMenu()
        {
            return "Basic Breakfast: Bacon, eggs, toast, orange juice";
        }
    }
}