using DesignPatterns.Structural.Composite;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Test.Structural.Composite
{
    public class CompositeTests
    {
        [Fact]
        public void Employee_ShowsReportingTree()
        {
            var director = new DirectorOfEngineering("Jonathan", "Director of Engineering");

            var teamLead1 = new SoftwareEngineer("Ryan", "Software Engineer Team Lead");
            var engineer1 = new SoftwareEngineer("Tonya", "Senior Software Engineer");
            var engineer2 = new SoftwareEngineer("Andrew", "Senior Software Engineer");
            var engineer3 = new SoftwareEngineer("Jason", "Software Engineer");

            teamLead1.DirectReports.Add(engineer1);
            teamLead1.DirectReports.Add(engineer2);
            teamLead1.DirectReports.Add(engineer3);

            var teamLead2 = new DatabaseAdministrator("Anthony", "Database Team Lead");
            var dba1 = new DatabaseAdministrator("Jyoti", "Database Developer");
            var dba2 = new DatabaseAdministrator("Robert", "Database Administrator");

            teamLead2.DirectReports.Add(dba1);
            teamLead2.DirectReports.Add(dba2);

            director.DirectReports.Add(teamLead1);
            director.DirectReports.Add(teamLead2);

            var test = director.GetEmployeeData();
        }
    }
}