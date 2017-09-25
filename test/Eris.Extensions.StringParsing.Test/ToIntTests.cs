using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToIntTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_Int()
        {
            var input = "123";

            var result = input.ToInt();

            result.Should()
                .BeOfType(typeof(int))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Int()
        {
            var input = "a";

            var result = input.ToInt();

            result.Should()
                .BeOfType(typeof(int))
                .And
                .Be(0);
        }
    }
}