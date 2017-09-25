using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToNullableByteTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableByte()
        {
            var input = "123";

            var result = input.ToNullableByte();

            result.HasValue.Should().BeTrue();
            result.Value.Should()
                .BeOfType(typeof(byte))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableByte()
        {
            var input = "a";

            var result = input.ToNullableByte();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}