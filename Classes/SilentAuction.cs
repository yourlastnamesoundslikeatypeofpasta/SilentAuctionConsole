﻿using System;
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
        public User LoggedInUser { get; set; }

        public SilentAuction()
        {
            // test users and auction
            CreateTestSilentAuction();
        }

        public void CreateTestSilentAuction()
        {
            // create admin & add user to Users
            Admin admin = new(1, "admin", "demo123");
            Users.Add(admin);

            // create regular & add user to Users
            User regularUser = admin.AddUser(Users, "christian", "demo123");
            Users.Add(regularUser);

            // create auctions
            DateTime startdate = new DateTime(2022, 11, 20);
            DateTime enddate = new DateTime(2022, 12, 20);
            Auction newAuction = admin.CreateAuction("November Auction", startdate, enddate);
            Auctions.Add(newAuction);


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
    }
}