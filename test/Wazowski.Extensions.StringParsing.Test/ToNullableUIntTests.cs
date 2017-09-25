using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToNullableUIntTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableUInt()
        {
            var input = "123";

            var result = input.ToNullableUInt();

            result.HasValue.Should().BeTrue();
            result.Should()
                .BeOfType(typeof(uint))
                .And
                .Be(123u);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableUInt()
        {
            var input = "a";

            var result = input.ToNullableUInt();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}