using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToTimeSpanTests
    {
        [Fact]
        public void String_With_TimeSpan_Should_Be_Converted_To_TimeSpan()
        {
            var input = "17:1:25";

            var result = input.ToTimeSpan();

            result.Should()
                .Be(new TimeSpan(17, 1, 25));
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_TimeSpan()
        {
            var input = "a";

            var result = input.ToTimeSpan();

            result.Should()
                .Be(default(TimeSpan));
        }
    }
}