using System;
using System.Collections.Generic;

namespace Palindrome
{
    //Write a function to take a string parameter and return true if the parameter is a palindrome, (the string is the same forward as it is backward) otherwise return false. 
    //The parameter entered may have punctuation and symbols but they should not affect whether the string is in fact a palindrome. 
    //Examples: 
    //"Anne, I vote more cars race Rome-to-Vienna" should return true
    //"Sex at noon taxes" should return true
    //"I, man, am regal; a German am I." should return true
    //"Noel sees Leon." should return true;
    //"This sentence is not a palindrome." should return false

    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Noel sees Leon";
            if (args.Length > 0)
            {
                testString = args[0];
            }
            else
            {
                Console.WriteLine(string.Format("Since you didn't enter a parameter we will use the default {0}", testString));
            }

            //Only because this is a console app and the starting method is static. We have to do this to start the IoC container.
            var main = new Program();
            var result = IsPalindrome(testString);
            Console.WriteLine("Is the input a palindrome: " + result);
        }

        public static bool IsPalindrome(string input)
        {
            //1: convert to character array
            var charArray = input.ToCharArray();
            var trimmedCharArray = new List<char>();

            //2: pull out any punctuation characters and store in new array
            foreach (var iChar in charArray)
            {
                //I didn't know about the char.IsPunctuation method. Only after browsing around 10 minutes for how to strip punctuation from a string in C# did I discover it.
                //Read http://stackoverflow.com/questions/421616/how-can-i-strip-punctuation-from-a-string for lots of different ways to do this.
                if (!char.IsPunctuation(iChar) && !char.IsWhiteSpace(iChar))
                {
                    trimmedCharArray.Add(iChar);
                }
            }


            //3: compare ith character to last char minus ith char index to see if they are the same.
            for (var iPosition = 0; iPosition <= trimmedCharArray.Count / 2; iPosition++)
            {
                //Breaking these out into seperate variables so I can evaluate them in the debugger. If it was just an expression like
                //if(trimmedCharArray[iPosition] != trimmedCharArray[(trimmedCharArray.Count - 1) - iPosition]) then I wouldn't be able to see the values and could make it harder to debug.
                //Have to subtract 1 from the Count because counts are based on the starting point being 1 but indexes are based on the starting point being 0.
                //Converting these to string so that I can use the ToLower function. Prob other ways to do this but this was the simplest way I could think of. You could subtract 30 something from
                //the ascii value of the character and get the same thing but...
                var indexedCharacter = trimmedCharArray[iPosition].ToString().ToLower();
                var indexedMirroredCharacter = trimmedCharArray[(trimmedCharArray.Count - 1) - iPosition].ToString().ToLower();

                if (indexedCharacter != indexedMirroredCharacter)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
