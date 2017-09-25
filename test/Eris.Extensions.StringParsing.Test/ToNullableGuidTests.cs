using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToNullableGuidTests
    {
        [Fact]
        public void String_With_Guid_Should_Be_Converted_To_NullableGuid()
        {
            const string input = "12345678-1234-1234-1234-123456789012";

            var result = input.ToNullableGuid();

            result.HasValue.Should().BeTrue();
            result.Should()
                .Be(new Guid("12345678-1234-1234-1234-123456789012"));
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableGuid()
        {
            const string input = "12345678-1234-1234-1234-123456789012-123456789";

            var result = input.ToNullableGuid();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}