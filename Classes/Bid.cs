using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilentAuctionConsole.Classes
{
    public class Bid
    {
        public User User { get; set; }
        public int BidAmount { get; set; }
        public Item Item { get; set; }

        public Bid(User user, int bidAmount, Item item)
        {
            User = user;
            BidAmount = bidAmount;
            Item = item;
        }
    }
}
