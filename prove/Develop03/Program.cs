using System;
using System.Xml.Serialization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   //Gives values for the scripture and reference
        Reference reference = new Reference("Doctrine and Covenants", 4, 4);
        string content = "For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with all his might, the same layeth up in store that he perisheth not, but bringeth salvation to his soul;";

        //Puts each of the words in the string as an item in a list
        List<Word> words = new List<Word>();
        foreach (string w in content.Split()) 
        {
            words.Add(new Word(w));
        }
        //calls scripture class and uses the constructor
        Scripture scripture = new Scripture(words, reference);

        //loop to run the program until all of the words are hidden or until user quits
        bool running = true;
        while (running)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllHidden())
            {
                break;
            }

            Console.Write("Press enter to continue or type 'quit' to finish. ");
            string choice = Console.ReadLine().Trim().ToLower();

            if (choice == "quit")
                break;
            else
                scripture.HideWords(words, 3);
            
        }
    }
}