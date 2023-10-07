using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp
{
    public class DisplayMenu
    {
        int myChoise = 0;
        public int Display()
        {
            Console.WriteLine("Please Select one of the following choises");
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do?: ");
            myChoise = Convert.ToInt32(Console.ReadLine());
            if (myChoise == 1) { return 1; }
            else if (myChoise == 2) { return 2; }
            else if (myChoise == 3) { return 3; }
            else if (myChoise == 4) { return 4; }
            else if (myChoise == 5) { return 5; }
            else { Console.WriteLine("This is not a option"); return 0; }
        }
    }
}
