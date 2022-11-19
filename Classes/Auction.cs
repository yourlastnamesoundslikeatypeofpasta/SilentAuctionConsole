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
        public List<Item> ItemList { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsLive { get; set; } = false;

        public Auction(DateTime startdate, DateTime enddate)
        {
            StartDate = startdate;
            EndDate = enddate;
        }
    }
}
