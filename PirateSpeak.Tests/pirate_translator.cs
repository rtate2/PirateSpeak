using System;
using Xunit;
using System.Collections.Generic;

namespace PirateSpeak.Tests
{
    public class Pirate_translator
    {
        [Fact]
        public void translate_ortsp()
        {
            List<char> characters = new List<char> { 'o', 'r', 't', 's', 'p' };
            var word = "ortsp";
            List<string> pirateWords = new List<string> { "sport", "parrot", "ports", "matey" };
            List<string> expectedResult = new List<string> { "sport", "ports" };

            var translator = new Translator();

            var actualResult = translator.Translate(word, pirateWords);

            Assert.Equal(actualResult, expectedResult);
        }
    }
}