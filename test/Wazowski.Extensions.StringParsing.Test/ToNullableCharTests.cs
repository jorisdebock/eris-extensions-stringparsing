using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{
    public class ToNullableLongTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableLong()
        {
            var input = "123";

            var result = input.ToNullableLong();

            result.HasValue.Should().BeTrue();
            result.Should()
                .BeOfType(typeof(long))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableLong()
        {
            var input = "a";

            var result = input.ToNullableLong();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}