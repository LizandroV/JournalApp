using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp
{
    public class Journal
    {
        string _prompt = "";
        public string Prompt()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 5);
            if (number == 1)
            {
                return "Who was the most interesting person I interacted with today?";
            }
            else if (number == 2)
            {
                return "What was the best part of my day?";
            }
            else if (number == 3)
            {
                return "How did I see the hand of the Lord in my life today?";
            }
            else if (number == 4)
            {
                return "What was the strongest emotion I felt today?";
            }
            else
            {
                return "If I had one thing I could do over today, what would it be?";
            }

        }

        public string Write()
        {
            _prompt = Prompt();
            Console.WriteLine(_prompt);
            Console.Write(">");
            string myEntry = Console.ReadLine();
            return myEntry;
        }

        public string PromptUsed()
        {
            return _prompt;
        }
    }
}
