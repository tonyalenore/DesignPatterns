using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class MeatPizza : Pizza
    {
        public override string Display()
        {
            return "meat pizza";
        }
    }
}