using Microsoft.Azure.Mobile.Server;
using System.ComponentModel.DataAnnotations.Schema;
using xPlatAuction.Backend.Models;

namespace xPlatAuction.Backend.DataObjects
{
    public class Bid : EntityData
    {
        public double BidAmount { get; set; }
        public string Bidder { get; set; }

        [Column("AuctionItem_Id")]
        public string AuctionItemId { get; set; }
        [ForeignKey("AuctionItemId")]
        public virtual AuctionItemDbEntity AuctionItem { get; set; }
    }
}