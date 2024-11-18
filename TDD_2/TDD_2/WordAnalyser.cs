using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_2
{
    public class WordAnalyser
    {
        public List<string> FindLongestWords(string text)
        {
            string[] splitText = text.Split(" ");
            // make new list
            List<string> result = new List<string>();

            int longestWordLength = 0;

            // loop splitText to get highest character count
            for (int i = 0; i < splitText.Length; i++)
            {
                string word = splitText[i];
                if (word.Length >= longestWordLength)
                {
                    longestWordLength = word.Length;
                }
            }
            
            // loop splitText again, if word.length == counter then add to result list
            foreach (string word in splitText)
            {
                if (word.Length == longestWordLength)
                {
                    result.Add(word);
                }
            }

            return result;
        }

        public Dictionary<char, int> CalculateLetterFrequency(string text)
        {
            // TODO: Implement the logic to calculate the frequency of each letter in the given text
            return new Dictionary<char, int>();
        }
    }
}
