using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public List<Employee> DirectReports { get; set; }

        public Employee(string name, string title)
        {
            Name = name;
            Title = title;
            DirectReports = new List<Employee>();
        }

        public string GetEmployeeData()
        {
            // improve formatting

            var sb = new StringBuilder();

            sb.AppendLine($"Name: {Name} - Title: {Title}");

            if (DirectReports.Any())
            {
                sb.AppendLine($"Direct Reports:");
            }

            foreach (var employee in DirectReports)
            {
                sb.AppendLine($"{employee.GetEmployeeData()}");
            }

            return sb.ToString();
        }
    }
}