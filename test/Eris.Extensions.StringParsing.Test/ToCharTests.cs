using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToCharTests
    {
        [Fact]
        public void String_With_One_Character_Should_Be_Converted_To_Char()
        {
            var input = "a";

            var result = input.ToChar();

            result.Should()
                .BeOfType<char>()
                .And
                .Be('a');
        }

        [Fact]
        public void String_With_Two_Character_Should_Be_Default_Of_Char()
        {
            var input = "aa";

            var result = input.ToChar();

            result.Should()
                .BeOfType<char>()
                .And
                .Be('\0');
        }
    }
}