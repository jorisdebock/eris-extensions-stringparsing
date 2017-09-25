using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToNullableDecimalTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableDecimal()
        {
            var input = "123";

            var result = input.ToNullableDecimal();

            result.HasValue.Should().BeTrue();
            result.Should()
                .BeOfType(typeof(decimal))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableDecimal()
        {
            var input = "a";

            var result = input.ToNullableDecimal();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}