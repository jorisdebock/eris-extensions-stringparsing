using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToEnumTests
    {
        private enum EnumTest
        {
            One,
            Two
        }

        [Fact]
        public void String_With_Enum_Should_Be_Converted_To_Enum()
        {
            var input = "Two";

            var result = input.ToEnum<EnumTest>();

            result.Should()
                .BeOfType<EnumTest>()
                .And
                .Be(EnumTest.Two);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Enum()
        {
            var input = "Three";

            var result = input.ToEnum<EnumTest>();

            result.Should()
                .BeOfType<EnumTest>()
                .And
                .Be(default(EnumTest));
        }
    }
}