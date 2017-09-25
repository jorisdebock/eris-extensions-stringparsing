using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToSByteTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_SByte()
        {
            var input = "123";

            var result = input.ToSByte();

            result.Should()
                .BeOfType(typeof(sbyte))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_SByte()
        {
            var input = "a";

            var result = input.ToSByte();

            result.Should()
                .BeOfType(typeof(sbyte))
                .And
                .Be(0);
        }
    }
}