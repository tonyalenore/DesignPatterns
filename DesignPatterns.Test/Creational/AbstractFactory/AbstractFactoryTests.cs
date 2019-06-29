using DesignPatterns.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Test.Creational.AbstractFactory
{
    public class AbstractFactoryTests
    {
        [Fact]
        public void BasicMenuFactory_CreatesBasicBreakfastMenu()
        {
            BasicMenuFactory menuFactory = new BasicMenuFactory();

            IBreakfastMenu breakfast = menuFactory.CreateBreakfastMenu();

            breakfast.GetMenu().Should().BeEquivalentTo("Basic Breakfast: Bacon, eggs, toast, orange juice");
        }

        [Fact]
        public void BasicMenuFactory_CreatesBasicLunchMenu()
        {
            BasicMenuFactory menuFactory = new BasicMenuFactory();

            ILunchMenu lunch = menuFactory.CreateLunchMenu();

            lunch.GetMenu().Should().BeEquivalentTo("Basic Lunch: Sandwich, soup, soda");
        }

        [Fact]
        public void KetoMenuFactory_CreatesKetoBreakfastMenu()
        {
            KetoMenuFactory menuFactory = new KetoMenuFactory();

            IBreakfastMenu breakfast = menuFactory.CreateBreakfastMenu();

            breakfast.GetMenu().Should().BeEquivalentTo("Keto Breakfast: Bacon, eggs, coffee with cream and splenda");
        }

        [Fact]
        public void KetoMenuFactory_CreatesKetoLunchMenu()
        {
            KetoMenuFactory menuFactory = new KetoMenuFactory();

            ILunchMenu lunch = menuFactory.CreateLunchMenu();

            lunch.GetMenu().Should().BeEquivalentTo("Keto Lunch: Caesar salad, diet soda");
        }
    }
}