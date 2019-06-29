using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class DatabaseAdministrator : Employee
    {
        public DatabaseAdministrator(string name, string title) : base(name, title)
        {
        }
    }
}