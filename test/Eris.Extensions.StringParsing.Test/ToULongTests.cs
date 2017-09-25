using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToULongTests
    {
        [Fact]
        public void String_With_Number_Should_Be_Converted_To_ULong()
        {
            var input = "123";

            var result = input.ToULong();

            result.Should()
                .BeOfType(typeof(ulong))
                .And
                .Be(123);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_ULong()
        {
            var input = "a";

            var result = input.ToULong();

            result.Should()
                .BeOfType(typeof(ulong))
                .And
                .Be(0);
        }
    }
}