using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilentAuctionConsole.Classes
{
    public class Auction
    {
        int ID { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Item> ItemDictionary = new();
        public List<Bid> BidList { get; set; } = new();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsLive { get; set; } = false;

        public Auction(List<Auction> auctionlist, string name, DateTime startdate, DateTime enddate)
        {
            ID = CreateAuctionID(auctionlist);
            Name = name;
            StartDate = startdate;
            EndDate = enddate;

        }

        public int CreateAuctionID(List<Auction> auctionList)
        {
            int auctionID = auctionList.Count + 1;
            return auctionID;
        }

        public void AddItem(Item item)
        {
            // dict kvp:
            //      Key:ID, Value:Item
            ItemDictionary.Add(item.Id, item);
        }

        public void RemoveItem(Item item)
        {
            ItemDictionary.Remove(item.Id);
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
