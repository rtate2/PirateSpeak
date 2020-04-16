using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PirateSpeak
{
    public class Translator
    {
        public List<string> Translate(string word, List<string> pirateWords)
        {
            List<string> possibleWords = new List<string>();

            var characters = word.ToCharArray();

            foreach (var pword in pirateWords)
            {
                var pchars = pword.ToCharArray();
                var difference = characters.Except(pchars);
                if (!difference.Any())
                {
                    possibleWords.Add(pword);
                }
            }
            return possibleWords;
        }
    }
}