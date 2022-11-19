using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilentAuctionConsole.Classes
{
    internal class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RetailAmount { get; set; }
        public int MinimumBid { get; set; }

        public Item(int id, string name, int retailamount, int minimumbid)
        {
            Id = id;
            Name = name;
            RetailAmount = retailamount;
            MinimumBid = minimumbid;
        }
    }
}
