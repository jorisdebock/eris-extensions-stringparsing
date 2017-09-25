using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToNullableTimeSpanTests
    {
        [Fact]
        public void String_With_TimeSpan_Should_Be_Converted_To_NullableTimeSpan()
        {
            var input = "17:1:25";

            var result = input.ToNullableTimeSpan();

            result.HasValue.Should().BeTrue();
            result.Should()
                .Be(new TimeSpan(17, 1, 25));
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableTimeSpan()
        {
            var input = "a";

            var result = input.ToNullableTimeSpan();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}