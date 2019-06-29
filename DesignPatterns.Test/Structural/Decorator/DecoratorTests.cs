using DesignPatterns.Structural.Decorator;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Test.Structural.Decorator
{
    public class DecoratorTests
    {
        [Fact]
        public void PizzaTest()
        {
            var whitePizzas = new Available(new WhitePizza(), 3);
            var meatPizzas = new Available(new MeatPizza(), 5);

            whitePizzas.OrderPizza("Luna");
            whitePizzas.OrderPizza("Mimi");
            whitePizzas.OrderPizza("Foma");
            whitePizzas.OrderPizza("Barley");

            meatPizzas.OrderPizza("Barley");
            meatPizzas.OrderPizza("Tonya");
            meatPizzas.OrderPizza("Anthony");
            meatPizzas.OrderPizza("Lindsay");
            meatPizzas.OrderPizza("Cameron");
            meatPizzas.OrderPizza("Linden");

            var whitePizzaOrders = whitePizzas.Display();
            var meatPizzaOrders = meatPizzas.Display();

            var expectedWhitePizzaOrders = new[] {
                "Luna ordered white pizza",
                "Mimi ordered white pizza",
                "Foma ordered white pizza",
                "Barley was unable to order white pizza"};

            var expectedMeatPizzaOrders = new[] {
                "Barley ordered meat pizza",
                "Tonya ordered meat pizza",
                "Anthony ordered meat pizza",
                "Lindsay ordered meat pizza",
                "Cameron ordered meat pizza",
                "Linden was unable to order meat pizza" };

            whitePizzaOrders.Should().ContainAll(expectedWhitePizzaOrders);
            meatPizzaOrders.Should().ContainAll(expectedMeatPizzaOrders);
        }
    }
}