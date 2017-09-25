using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToNullableShortTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableShort()
        {
            var input = "123";

            var result = input.ToNullableShort();

            result.HasValue.Should().BeTrue();
            result.Should()
                .BeOfType(typeof(short))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableShort()
        {
            var input = "a";

            var result = input.ToNullableShort();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}