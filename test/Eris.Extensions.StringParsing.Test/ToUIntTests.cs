using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToUIntTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_UInt()
        {
            var input = "123";

            var result = input.ToUInt();

            result.Should()
                .BeOfType(typeof(uint))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_UInt()
        {
            var input = "a";

            var result = input.ToUInt();

            result.Should()
                .BeOfType(typeof(uint))
                .And
                .Be(0);
        }
    }
}