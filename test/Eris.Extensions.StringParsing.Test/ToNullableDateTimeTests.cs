using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToNullableDateTimeTests
    {
        [Fact]
        public void String_With_DateTime_Should_Be_Converted_To_NullableDateTime()
        {
            var input = "2017-1-25";

            var result = input.ToNullableDateTime();

            result.HasValue.Should().BeTrue();
            result.Should()
                .Be(new DateTime(2017, 1, 25));
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableDateTime()
        {
            var input = "a";

            var result = input.ToNullableDateTime();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}