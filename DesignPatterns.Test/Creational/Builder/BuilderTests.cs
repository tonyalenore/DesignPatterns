using DesignPatterns.Creational.Builder;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Test.Creational.Builder
{
    public class BuilderTests
    {
        [Theory]
        [InlineData("vanilla", "whole", "medium", "sugar")]
        [InlineData("mocha", "2%", "small", "none")]
        public void LatteTest(string flavor, string milk, string size, string sweetener)
        {
            var expected = new StringBuilder();
            expected.AppendLine($"flavor - {flavor}");
            expected.AppendLine($"milk - {milk}");
            expected.AppendLine($"size - {size}");
            expected.AppendLine($"sweetener - {sweetener}");

            var starbucks = new CoffeeAssembly();

            var latte = new Latte(flavor, milk, size, sweetener);

            starbucks.Assemble(latte);

            var coffeeDescription = latte.Coffee.ShowOptions();

            coffeeDescription.Should().BeEquivalentTo(expected.ToString());
        }
    }
}