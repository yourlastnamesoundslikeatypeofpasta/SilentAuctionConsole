using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilentAuctionConsole.Classes
{
    public class ConsoleMenu
    {
        public ConsoleMenu()
        {
        }

        public static void ShowLoginMenu(SilentAuction sa)
        {
            Console.WriteLine("Welcome to Silent Auction");
            
            if (sa.LoggedInUser != null)
            {
                Console.WriteLine($"Logged in user: {sa.LoggedInUser.Username}");

            }

            // display choices
            Dictionary<int, string> choices = new()
            {
                { 1, "Login" },
                { 2, "Quit Application" }
            };
            foreach (KeyValuePair<int, string> choice in choices)
            {
                Console.WriteLine($"{choice.Key}. {choice.Value}");
            }

            Console.Write($"Enter your choice :=> ");
            string response = Console.ReadLine();
        }

        public static Dictionary<int, string> GetChoices(SilentAuction sa)
        {
            Dictionary<int, string> choices = new();

            if (sa.LoggedInUser == null)
            {
                choices.Add(choices.Keys.Max() + 1, "Login");
            }

            if (sa.LoggedInUser != null)  // so implicit
            {
                choices.Add(choices.Keys.Max(), "View Auctions");
                
                if (sa.LoggedInUser is Admin)
                {
                    choices.Add(choices.Keys.Max(), "View Items");
                    choices.Add(choices.Keys.Max(), "Add Auction");
                    choices.Add(choices.Keys.Max(), "Add Item");

                }

            }


            choices.Add(choices.Keys.Max() + 1, "Quit Application");
            return choices;
        }
    }
}
