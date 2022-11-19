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

        public Item()
        {

        }
    }
}
