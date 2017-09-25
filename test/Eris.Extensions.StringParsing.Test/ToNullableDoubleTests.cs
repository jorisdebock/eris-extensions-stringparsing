using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToNullableDoubleTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableDouble()
        {
            var input = "123";

            var result = input.ToNullableDouble();

            result.HasValue.Should().BeTrue();
            result.Should()
                .BeOfType(typeof(double))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableDouble()
        {
            var input = "a";

            var result = input.ToNullableDouble();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}