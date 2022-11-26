using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SilentAuctionConsole.Classes;


namespace SilentAuctionConsole.Classes
{
    public class SilentAuction
    {
        public List<Auction> Auctions { get; set; } = new();
        public List<User> Users { get; set; } = new();
        public User? LoggedInUser { get; set; }

        public SilentAuction()
        {
            CreateStartupAdmin();
        }

        public void CreateStartupAdmin()
        {
            // create admin
            Admin admin = new(1, "admin", "demo123");
            Users.Add(admin);
        }


        public void CreateTestUsers()
        {
            // create regular & add user to Users
            User? newUserChristian = AddUser("christian", "demo123");
            if (newUserChristian != null)
            {
                Console.WriteLine($"Test user created: {newUserChristian.Username}");
            }
        }
        public void CreateTestSilentAuction()
        {


            // create auctions
            DateTime startdate = new DateTime(2022, 11, 20);
            DateTime enddate = new DateTime(2022, 12, 20);
            Auction? newAuction = CreateAuction("November Auction", startdate, enddate);
            if (newAuction != null)
            {
                Auctions.Add(newAuction);
            }


        }

        public bool Login()
        {
            Console.WriteLine("--- Please login ---");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            foreach (User user in Users)
            {
                if (username == user.Username && password == user.Password)
                {
                    LoggedInUser = user;
                    return true;
                }

            }
            return false;
        }

        public Auction? CreateAuction(string name, DateTime startdate, DateTime enddate)
        {
            if (LoggedInUser is Admin)
            {
                Auction newAuction = new(Auctions, name, startdate, enddate);
                Auctions.Add(newAuction);
                return newAuction;
            }
            return null;
        }

        public User? AddUser(string username, string password)
        {
            if (LoggedInUser is Admin)
            {
                int id = Users.Count + 1;
                User newUser = new(id, username, password);
                Users.Add(newUser);
                return newUser;
            }

            return null;
        }
    }
}
