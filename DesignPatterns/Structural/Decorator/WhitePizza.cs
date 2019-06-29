using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class WhitePizza : Pizza
    {
        public override string Display()
        {
            return "white pizza";
        }
    }
}