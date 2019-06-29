using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class Available : Decorator
    {
        private int _amountAvailable { get; set; }
        private List<string> _orders { get; set; }

        public Available(Pizza pizza, int amountAvailable) : base(pizza)
        {
            _amountAvailable = amountAvailable;
            _orders = new List<string>();
        }

        public void OrderPizza(string name)
        {
            if (_amountAvailable > 0)
            {
                _orders.Add($"{name} ordered {base.Display()}");
                _amountAvailable--;
            }
            else
            {
                _orders.Add($"{name} was unable to order {base.Display()}");
            }
        }

        public override string Display()
        {
            var sb = new StringBuilder();

            foreach (var order in _orders)
            {
                sb.AppendLine(order);
            }

            return sb.ToString();
        }
    }
}