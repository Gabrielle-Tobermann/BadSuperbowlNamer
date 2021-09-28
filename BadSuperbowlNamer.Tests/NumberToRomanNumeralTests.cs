using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    // Tests classes must be public
    public class NumberToRomanNumeralTests
    {
        // needs a fact attribute to be considered a test for something
        [Fact]
        public void the_number_1_is_translated_into_the_letter_I()
        {
            // tests pass if no exceptions are thrown while the test is running


            // 1. Arrange --> context that the test is run inside of
            var numberToTranslate = 1;
            var expectedResult = "I";
            var translator = new NumberTranslator();

            // 2. Act --> the actual thing we're testing
            var actualResult = translator.Translate(numberToTranslate);

            // Assert --> lay out the expectations in such a way that, if not met, exceptions are thrown.
            if (actualResult != expectedResult)
            {
                throw new Exception($"This is wrong. {actualResult} is not equal to {expectedResult}");
            }

            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void the_number_4_should_be_translated_to_IV()
        {
            // Arrange 
            var numberToTranslate = 4;
            var expectedResult = "IV";
            var translator = new NumberTranslator();

            // Act 
            var actualResult = translator.Translate(numberToTranslate);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_3_should_be_translated_to_IV()
        {
            // Arrange 
            var numberToTranslate = 3;
            var expectedResult = "III";
            var translator = new NumberTranslator();

            // Act 
            var actualResult = translator.Translate(numberToTranslate);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        public void given_a_number_it_is_translated_appropriately(int numberToTranslate, string expectedResult)
        {
            var translator = new NumberTranslator();

            // Act 
            var actualResult = translator.Translate(numberToTranslate);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
