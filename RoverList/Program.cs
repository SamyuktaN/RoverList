using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> list = new RoverList<string>();

            list.Add("jelly");
            list.Add("psychology");
            list.Add("Boston");
            list.Add("GoogleSlides");
            list.Add("birthday");
            list.Add("toothbrush");
            list.Add("school");
            list.Add("summer");
            list.Add("program");
            list.Add("books");
            list.Add("probability");
            list.Add("history");
            list.Add("COVID-19");
            list.Add("hair");
            list.Add("glasses");
            list.Add("computer");

            list.ListNodes();

            Console.WriteLine("Please enter some words:");
            while (true)
            {

                Console.Write("> ");

                string line = Console.ReadLine();
                if (line == "done")
                    break;

                list.Add(line);
            }
            Console.WriteLine("");

            list.ListNodes();

            Console.WriteLine("");
            Console.WriteLine("Please enter some more words:");
            while (true)
            {

                Console.Write("> ");

                string line = Console.ReadLine();
                if (line == "done")
                    break;

                list.Add(0, line);
            }
            Console.WriteLine("");

            list.ListNodes();

            Console.WriteLine("");
            Console.WriteLine("Now I will remove all odd words");
            Console.WriteLine("");


            int count = list.Count - 1;
            while (count >= 0)
            {
                var word = list.ElementAt(count);

                if (word.Length % 2 != 0)
                {
                    list.RemoveAt(count);
                }
                count--;
            }

            Console.WriteLine("");
            list.ListNodes();

            Console.WriteLine("");
            Console.WriteLine("Now I will clear the list");

            list.Clear();

            list.ListNodes();
            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words

            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
