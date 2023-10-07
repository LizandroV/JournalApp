using JournalApp;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Journal APP");
        Console.WriteLine();

        DisplayMenu display = new DisplayMenu();
        int option;
        List<string> myJournalList = new List<string>();

        do
        {
            option = display.Display();
            if (option == 1)
            {
                Journal myJournal = new Journal();
                string entry = myJournal.Write();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                myJournalList.Add($"{dateText} - Prompt: {myJournal.PromptUsed()}");
                myJournalList.Add(entry);
                myJournalList.Add("");
                Console.WriteLine();
            }
            else if (option == 2)
            {
                foreach(string value in myJournalList)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine();
            }
            else if (option == 3)
            {
                Console.WriteLine("What is the filename? ");
                Console.Write("> ");

                string filename = Console.ReadLine();
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    myJournalList.Add(line);
                }

                Console.WriteLine("Entries loaded");
                Console.WriteLine();
            }
            else if (option == 4)
            {
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (string value in myJournalList)
                    {
                        outputFile.WriteLine(value);
                    }
                }
                Console.WriteLine("Journal saved");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }

        } while (option != 5);
        Console.WriteLine();
        Console.WriteLine("Thanks!");
    }
}