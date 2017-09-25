using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToNullableBoolTests
    {
        [Fact]
        public void String_With_Bool_Should_Be_Converted_To_NullableBool()
        {
            var input = "true";

            var result = input.ToNullableBool();

            result.HasValue.Should().BeTrue();
            result.Should()
                .Be(true);
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_NullableBool()
        {
            var input = "truefalse";

            var result = input.ToNullableBool();

            result.HasValue.Should().BeFalse();
            result.Should().BeNull();
        }
    }
}