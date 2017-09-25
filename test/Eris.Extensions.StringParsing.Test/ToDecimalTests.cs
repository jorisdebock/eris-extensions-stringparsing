using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToDecimalTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_Decimal()
        {
            var input = "123";

            var result = input.ToDecimal();

            result.Should()
                .BeOfType(typeof(decimal))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Decimal()
        {
            var input = "a";

            var result = input.ToDecimal();

            result.Should()
                .BeOfType(typeof(decimal))
                .And
                .Be(0);
        }
    }
}