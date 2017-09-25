using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToShortTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_Short()
        {
            var input = "123";

            var result = input.ToShort();

            result.Should()
                .BeOfType(typeof(short))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Short()
        {
            var input = "a";

            var result = input.ToShort();

            result.Should()
                .BeOfType(typeof(short))
                .And
                .Be(0);
        }
    }
}