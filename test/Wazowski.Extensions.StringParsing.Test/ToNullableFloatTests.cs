using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToNullableFloatTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableFloat()
        {
            var input = "123";

            var result = input.ToNullableFloat();

            result.HasValue.Should().BeTrue();
            result.Should()
                .BeOfType(typeof(float))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableFloat()
        {
            var input = "a";

            var result = input.ToNullableFloat();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}