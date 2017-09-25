using FluentAssertions;
using System;
using Xunit;

namespace Eris.Extensions.StringParsing.Test
{
    public class ToBoolTests
    {
        [Fact]
        public void String_With_Bool_Should_Be_Converted_To_Bool()
        {
            var input = "true";

            var result = input.ToBool();

            result.Should()
                .Be(true);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Bool()
        {
            var input = "truefalse";

            var result = input.ToBool();

            result.Should()
                .Be(default(bool));
        }
    }
}