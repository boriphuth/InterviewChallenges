using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LetterCount
{
    //Using the your language of choice language, have the function LetterCount(str) take the str parameter being passed and return the first word with the greatest number of repeated letters.
    //For example: "Today, is the greatest day ever!" should return greatest because it has 2 e's (and 2 t's) and it comes before ever which also has 2 e's. 
    //If there are no words with repeating letters return -1. Words will be separated by spaces.
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Today, is the greatest day ever!";
            if (args.Length > 0)
            {
                testString = args[0];
            }
            else
            {
                Console.WriteLine(string.Format("Since you didn't enter a parameter we will use the default {0}", testString));
            }

            var highestScoreWord = LetterCount(testString);
            Console.WriteLine("Highest score word is: {0}", highestScoreWord);
        }

        public static string LetterCount(string message)
        {
            var wordList = message.Split(' ').ToList();
            int score = 0;
            string highestScoreWord = "-1";
            foreach (var iWord in wordList)
            {
                var tempScore = WordScore(iWord);
                if (tempScore > score)
                {
                    score = tempScore;
                    highestScoreWord = iWord;
                }

            }

            return highestScoreWord;
        }


        public static int WordScore(string message)
        {
            //Get the first character.
            //Find the count of that character in the string
            //If it is greater than 1 then increment a counter.
            //Remove all occurrances of the character from the string and repeat until string.length == 0
            int score = 0;
            while (message.Length > 0)
            {
                var firstChar = message[0];
                var regEx = new Regex(firstChar.ToString());
                var charCount = regEx.Matches(message).Count;
                if (charCount > 1)
                {
                    score++;
                }
                message = message.Replace(message[0].ToString(), "");
            }

            return score;
        }
    }
}
