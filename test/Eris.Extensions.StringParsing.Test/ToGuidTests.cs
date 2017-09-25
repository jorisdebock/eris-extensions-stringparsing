using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToGuidTests
    {
        [Fact]
        public void String_With_Guid_Should_Be_Converted_To_Guid()
        {
            const string input = "12345678-1234-1234-1234-123456789012";

            var result = input.ToGuid();

            result.Should()
                .Be(new Guid("12345678-1234-1234-1234-123456789012"));
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Guid()
        {
            const string input = "12345678-1234-1234-1234-123456789012-123456789";

            var result = input.ToGuid();

            result.Should()
                .Be(default(Guid));
        }
    }
}