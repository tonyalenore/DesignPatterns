namespace DesignPatterns.Creational.AbstractFactory
{
    public class BasicLunch : LunchMenu
    {
        public override string GetMenu()
        {
            return "Basic Lunch: Sandwich, soup, soda";
        }
    }
}