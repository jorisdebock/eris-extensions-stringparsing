using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToNullableSByteTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_NullableSByte()
        {
            var input = "123";

            var result = input.ToNullableSByte();

            result.HasValue.Should().BeTrue();
            result.Value.Should()
                .BeOfType(typeof(sbyte))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableSByte()
        {
            var input = "a";

            var result = input.ToNullableSByte();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}