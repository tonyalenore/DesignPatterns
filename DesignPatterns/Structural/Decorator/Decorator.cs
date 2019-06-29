using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class Decorator : Pizza
    {
        private readonly Pizza _pizza;

        public Decorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Display()
        {
            return _pizza.Display();
        }
    }
}