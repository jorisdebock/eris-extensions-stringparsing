using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToUShortTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_UShort()
        {
            var input = "123";

            var result = input.ToUShort();

            result.Should()
                .BeOfType(typeof(ushort))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_UShort()
        {
            var input = "a";

            var result = input.ToUShort();

            result.Should()
                .BeOfType(typeof(ushort))
                .And
                .Be(0);
        }
    }
}