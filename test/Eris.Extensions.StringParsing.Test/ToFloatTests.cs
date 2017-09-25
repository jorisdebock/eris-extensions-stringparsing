using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToFloatTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_Float()
        {
            var input = "123";

            var result = input.ToFloat();

            result.Should()
                .BeOfType(typeof(float))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Float()
        {
            var input = "a";

            var result = input.ToFloat();

            result.Should()
                .BeOfType(typeof(float))
                .And
                .Be(0);
        }
    }
}