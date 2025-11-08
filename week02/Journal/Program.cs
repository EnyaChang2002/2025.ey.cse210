using System;

class Program
{
    static void Main(string[] args)
    {
        string run = "off";
        while (run == "off")
        {
            string choices = "";
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Wrtie");
            Console.WrtieLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            if (choices == "1")
            {
                Entry _newEntry = new Entry();

                DateTime _theCurrentTime = DateTime.Now;

                _newEntry._promptText = PromptGenerator.GetRandomPrompt();
                Console.WriteLine(_newEntry._promptText);

                _newEntry._date = _theCurrentTime.ToShortDateString();
                _newEntry._entryText = Console.WriteLine();

                Journal.AddEntry();

            }
            else if (choices == "2")
            {

            }
            else if (choices == "3")
            {

            }
            else if (choices == "4")
            {
                string files = Console.ReadLine();
                Journal.SavingFiles();
            }
            else if (choices == "5")
            {
                break;
            }
            else
            {
                continue;
            }

        }

    }
}

/* List _entry<string> : list of entries you write
 display() journal : iterate through all the entries in display
*/