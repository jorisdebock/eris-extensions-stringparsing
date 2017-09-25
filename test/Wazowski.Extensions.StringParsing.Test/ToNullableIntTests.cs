using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToNullableIntTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableInt()
        {
            var input = "123";

            var result = input.ToNullableInt();

            result.HasValue.Should().BeTrue();
            result.Should()
                .BeOfType(typeof(int))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableInt()
        {
            var input = "a";

            var result = input.ToNullableInt();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}