using System;
using System.Collections.Generic;


namespace Arrays_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints sentences whit the inputed word.
            bool isLooping = true;
            string[] story = { "James is a ", "In that house lives a ", "I've always wanted a ", "Do you now that on Mars, there is a living " };
            string addWord = "";

            while (isLooping)
            {
                Console.WriteLine("Enter a word, Enter \"Quit\" to Quit");
                addWord = Console.ReadLine();

                if (addWord == "quit" || addWord == "Quit") { isLooping = false; }
                else
                {
                    for (int i = 0; i < story.Length; i++)
                    {
                        story[i] += addWord;
                        Console.WriteLine("\n" + story[i]);
                    }
                }

            }

            //Lets you guess a number until it is 100 or bigger.
            Console.WriteLine("\nNow Enter a number");

            int number1 = 0;
            while (number1 < 100)
            {
                Console.WriteLine("Enter a number");
                number1 = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("It was 100 or bigger! \nEnter a number again.");

            //Lets you guess a number until it is 106 or bigger.
            int number2 = 0;
            while (number2 <= 105)
            {
                Console.WriteLine("Enter a number");
                number2 = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("it was bigger as 105! great! ");

           //This part searchses for the value of keyword in the list. It returns only the first match it finds.
           List<string> words = new List<string>() { "dog", "mouse", "ape", "dolphin", "bear", "cat", "hummingbird", "gorilla", "lion", "eagle", "seagull", "elephant", "tiger" };

            Console.WriteLine("Enter a keyword to search the list words");
            string keyword = Console.ReadLine();

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Contains(keyword))
                {
                    Console.WriteLine("the index of this word (" + words[i] + ") is: " + i);
                    break;
                }
                else if (i == words.Count - 1)
                {
                    Console.WriteLine("Your word isn't in the list.");
                }
            }

            // This part returns al the matching words in the list.
            List<string> doubleWords = new List<string>() { "dog", "mouse", "ape", "dolphin", "dog", "mouse", "ape", "dolphin" };

            Console.WriteLine("Enter a keyword to search the list words");
            string keywordDouble = Console.ReadLine();
            bool isInList = false;

            for (int i = 0; i < doubleWords.Count; i++)
            {
                if (doubleWords[i].Contains(keywordDouble))
                {
                    Console.WriteLine("the indices of this word (" + doubleWords[i] + ") is: " + i);
                    isInList = true;
                }
                else if (i == doubleWords.Count - 1 && !isInList)
                {
                    Console.WriteLine("Your word isn't in the list.");
                }
            }

            // loops through the list animale and prints each element and if it already exsists in the list or not.
            List<string> animales = new List<string>() { "dog", "mouse", "ape", "dolphin", "dog", "mouse", "ape", "dolphin" };
            List<string> alreadyThere = new List<string>() {""};

            foreach(string animale in animales)
            {
                string hasAppeared = alreadyThere.Contains(animale) ? ", already exists in this list" : ", is until now unique in this list ";
                if(!alreadyThere.Contains(animale)) { alreadyThere.Add(animale); }

                Console.WriteLine(animale + hasAppeared);
            }

            Console.Read();
        }     
    }
}
