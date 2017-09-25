using FluentAssertions;
using System;
using Xunit;

namespace Wazowski.Extensions.StringParsing.Test
{

    public class ToUriTests
    {
        [Fact]
        public void String_With_Uri_Should_Be_Converted_To_Uri()
        {
            var input = "https://google.com";

            var result = input.ToUri();

            result.Should()
                .Be(new Uri("https://google.com"));
        }

        [Fact]
        public void String_With_One_Character_Should_Be_Default_Of_Uri()
        {
            var input = "https://google.com<>";

            var result = input.ToUri();

            result.Should()
                .Be(default(Uri));
        }
    }
}