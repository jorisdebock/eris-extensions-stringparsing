using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToNullableULongTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableULong()
        {
            var input = "123";

            var result = input.ToNullableULong();

            result.HasValue.Should().BeTrue();
            result.Should()
                .BeOfType(typeof(ulong))
                .And
                .Be(123UL);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableULong()
        {
            var input = "a";

            var result = input.ToNullableULong();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}