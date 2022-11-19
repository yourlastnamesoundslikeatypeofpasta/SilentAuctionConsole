using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilentAuctionConsole.Classes
{
    internal class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id, string username, string password)
        {
            ID = id;
            Username = username;
            Password = password;
        }
    }

    internal class Admin : User
    {
        public Admin(int id, string username, string password) : base(id, username, password)
        {

        }

        public User AddUser(List<User> users, string username, string password)
        {
            int id = users.Count + 1;
            User newUser = new(id, username, password);
            return newUser;
        }

        public Auction CreateAuction(DateTime startdate, DateTime enddate)
        {
            Auction newAuction = new Auction(startdate, enddate);
            return newAuction;
        }
    }

}
