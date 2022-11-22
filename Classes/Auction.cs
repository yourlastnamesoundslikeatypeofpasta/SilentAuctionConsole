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

        public void AddItem(Item item)
        {
            ItemList.Add(item);
        }

        public void RemoveItem(Item item)
        {
            ItemList.Add(item);
        }

        public bool AddBid(Bid bid)
        {
            if (bid.BidAmount > bid.Item.MinimumBid)
            {
                BidList.Add(bid);
                return true;
            }
            return false;
        }

        public void RemoveBid(Bid bid)
        {
            BidList.Remove(bid);
        }

        public void StartAuction()
        {
            IsLive = true;
        }

        public void EndAuction()
        {
            IsLive = false;
        }

        public void RenameAuction(string newName)
        {
            Name = newName;
        }
    }
}
