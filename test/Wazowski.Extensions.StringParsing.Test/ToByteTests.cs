using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToByteTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_Byte()
        {
            var input = "123";

            var result = input.ToByte();

            result.Should()
                .BeOfType(typeof(byte))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Byte()
        {
            var input = "a";

            var result = input.ToByte();

            result.Should()
                .BeOfType(typeof(byte))
                .And
                .Be(0);
        }
    }
}