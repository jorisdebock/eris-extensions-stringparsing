using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToLongTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_Long()
        {
            var input = "123";

            var result = input.ToLong();

            result.Should()
                .BeOfType(typeof(long))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Long()
        {
            var input = "a";

            var result = input.ToLong();

            result.Should()
                .BeOfType(typeof(long))
                .And
                .Be(0);
        }
    }
}