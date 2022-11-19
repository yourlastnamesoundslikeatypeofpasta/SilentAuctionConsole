using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilentAuctionConsole.Classes
{
    internal class Auction
    {
        public string Name { get; set; }
        public List<Item> ItemList { get; set; } = new();
        public List<Bid> BidList { get; set; } = new();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsLive { get; set; } = false;

        public Auction(string name, DateTime startdate, DateTime enddate)
        {
            Name = name;
            StartDate = startdate;
            EndDate = enddate;
        }
    }
}
