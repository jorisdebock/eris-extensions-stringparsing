using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToNullableUShortTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableUShort()
        {
            var input = "123";

            var result = input.ToNullableUShort();

            result.HasValue.Should().BeTrue();
            result.Should()
                .BeOfType(typeof(ushort))
                .And
                .Be((ushort)123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableUShort()
        {
            var input = "a";

            var result = input.ToNullableUShort();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}