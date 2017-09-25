using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToDoubleTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_Double()
        {
            var input = "123";

            var result = input.ToDouble();

            result.Should()
                .BeOfType(typeof(double))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Double()
        {
            var input = "a";

            var result = input.ToDouble();

            result.Should()
                .BeOfType(typeof(double))
                .And
                .Be(0);
        }
    }
}