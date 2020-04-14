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
            Console.WriteLine("The sum of the letter's number values is {0}", w.ProcessText(w.GetUserInput()));
        }
    }

    class Worker
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        public Worker()
        {
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
        public int ProcessText(String inputString)
        {
            int sum = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                //  we can treat a STRING like an ARRAY
                //  whatever we do with a STRING we can do with an ARRAY

                // but how to handle a CAPITAL Letter as an INPUT ??
                // we give the dictionary a KEY: it returns a VALUE
                Console.WriteLine( dict[Char.ToLower(inputString[i])] );
                // let's calculate the SUM of all the Letter number values
                sum += dict[Char.ToLower(inputString[i])]; 
            }
            return sum; 
        }

    }
}
