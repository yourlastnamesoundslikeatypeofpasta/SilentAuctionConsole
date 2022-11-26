using SilentAuctionConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilentAuctionConsole.Classes
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Bid> ApprovedBidList { get; set; } = new();


        public User(int id, string username, string password)
        {
            ID = id;
            Username = username;
            Password = password;
        }

        public void ChangePassword(string newPassword)
        {
            Password = newPassword;
        }

        public void ChangeUsername(string newUsername)
        {
            Username = newUsername;
        }
    }

    public class Admin : User
    {
        public Admin(int id, string username, string password) : base(id, username, password)
        {

        }
    }

}

