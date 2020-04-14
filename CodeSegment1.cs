using System;
using System.Collections.Generic;

namespace DataStructures
{
   //  Write a C# Program to work with the following string which the user typed in:
   //  "The quick brown fox jumped over the lazy dog"
   //  Write code to output the number of times that each letter appeared in the above sentence.

    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();
            // Console.WriteLine("The sum of the letter's number values is {0}", w.ProcessText());
            w.CountNumberOfLetterOccurances();
        }
    }

    class Worker
    {
        // class instance variables are defined out side of any method
        String stringToProcess;

        Dictionary<char, int> dict = new Dictionary<char, int>();
        public Worker()
        {
            stringToProcess = this.GetUserInput();
            try
            {
                dict.Add(' ', 0);
                dict.Add('a', 1);
                dict.Add('b', 2);
                dict.Add('c', 3);
                dict.Add('d', 4);
                dict.Add('e', 5);
                dict.Add('f', 6);
                dict.Add('g', 7);
                dict.Add('h', 8);
                dict.Add('i', 9);
                dict.Add('j', 10);
                dict.Add('k', 11);
                dict.Add('l', 12);
                dict.Add('m', 13);
                dict.Add('n', 14);
                dict.Add('o', 15);
                dict.Add('p', 16);
                dict.Add('q', 17);
                dict.Add('r', 18);
                dict.Add('s', 19);
                dict.Add('t', 20);
                dict.Add('u', 21);
                dict.Add('v', 22);
                dict.Add('w', 23);
                dict.Add('x', 24);
                dict.Add('y', 25);
                dict.Add('z', 26);
            }
            // lineOfText.Add(dict[input[i]]);
            catch (Exception e) { Console.WriteLine(e.StackTrace); }
        }
    
        public String GetUserInput()
        {
            return Console.ReadLine();
        }
        public int ProcessText()
        {
            int sum = 0;
            for (int i = 0; i < stringToProcess.Length; i++)
            {
                //  we can treat a STRING like an ARRAY
                //  whatever we do with a STRING we can do with an ARRAY

                // but how to handle a CAPITAL Letter as an INPUT ??
                // we give the dictionary a KEY: it returns a VALUE
                Console.WriteLine( dict[Char.ToLower(stringToProcess[i])] );
                // let's calculate the SUM of all the Letter number values
                sum += dict[Char.ToLower(stringToProcess[i])]; 
            }
            return sum; 
        }

        public void CountNumberOfLetterOccurances()
        {
            // HOW are we going to keep track of HOW MANY of EACH LETTER we find??
            // let's try using a DICTIONARY!
            Dictionary<char, int> keepTrackOfLetterFrequencies = new Dictionary<char, int>();
            keepTrackOfLetterFrequencies.Add(' ', 0);
            keepTrackOfLetterFrequencies.Add('a', 0);
            keepTrackOfLetterFrequencies.Add('b', 0);
            keepTrackOfLetterFrequencies.Add('c', 0);
            keepTrackOfLetterFrequencies.Add('d', 0);
            keepTrackOfLetterFrequencies.Add('e', 0);
            keepTrackOfLetterFrequencies.Add('f', 0);
            keepTrackOfLetterFrequencies.Add('g', 0);
            keepTrackOfLetterFrequencies.Add('h', 0);
            keepTrackOfLetterFrequencies.Add('i', 0);
            keepTrackOfLetterFrequencies.Add('j', 0);
            keepTrackOfLetterFrequencies.Add('k', 0);
            keepTrackOfLetterFrequencies.Add('l', 0);
            keepTrackOfLetterFrequencies.Add('m', 0);
            keepTrackOfLetterFrequencies.Add('n', 0);
            keepTrackOfLetterFrequencies.Add('o', 0);
            keepTrackOfLetterFrequencies.Add('p', 0);
            keepTrackOfLetterFrequencies.Add('q', 0);
            keepTrackOfLetterFrequencies.Add('r', 0);
            keepTrackOfLetterFrequencies.Add('s', 0);
            keepTrackOfLetterFrequencies.Add('t', 0);
            keepTrackOfLetterFrequencies.Add('u', 0);
            keepTrackOfLetterFrequencies.Add('v', 0);
            keepTrackOfLetterFrequencies.Add('w', 0);
            keepTrackOfLetterFrequencies.Add('x', 0);
            keepTrackOfLetterFrequencies.Add('y', 0);
            keepTrackOfLetterFrequencies.Add('z', 0);

            // walk over input string
            // for each character, access the Dictionary location, and update the number of occurances by 1
            char CurrentCharacter;
            int NumberOfOccurances = 0;
            for (int i = 0; i < stringToProcess.Length; i++)
            {
                // we are now in an Execution Context in which we can access to each character 
                // in the string, one at a time
                // so what do we do with it??
                // I need to access in dictionary the character
                // then I need to increment by 1 the number of occurances!

                CurrentCharacter = stringToProcess[i];
                // I will locate the CurrentCharacter in the Dictionary!
                // 1. Console.WriteLine(keepTrackOfLetterFrequencies[Char.ToLower(CurrentCharacter)]);
                
                // acquire the value
                NumberOfOccurances = keepTrackOfLetterFrequencies[Char.ToLower(CurrentCharacter)];
                // 2. adjust the value
                NumberOfOccurances++;
                // 3. push the value back into the data repository!
                keepTrackOfLetterFrequencies[Char.ToLower(CurrentCharacter)] = NumberOfOccurances;
            }

            // now dump out the dictionary to view the result:

            foreach (var item in keepTrackOfLetterFrequencies)
            {
                Console.WriteLine(item);
            }
        }

    }
}
