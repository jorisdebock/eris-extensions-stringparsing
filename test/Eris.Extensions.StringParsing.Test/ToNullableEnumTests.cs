using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToNullableEnumTests
    {
        private enum EnumTest
        {
            One,
            Two
        }

        [Fact]
        public void String_With_Enum_Should_Be_Converted_To_NullableEnum()
        {
            var input = "Two";

            var result = input.ToNullableEnum<EnumTest>();

            result.HasValue.Should().BeTrue();
            result.Should()
                .BeOfType<EnumTest>()
                .And
                .Be(EnumTest.Two);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableEnum()
        {
            var input = "Three";

            var result = input.ToNullableEnum<EnumTest>();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}