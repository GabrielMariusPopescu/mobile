using Microsoft.Azure.Mobile.Server.Config;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using xPlatAuction.Backend.DataObjects;
using xPlatAuction.Backend.Models;

namespace xPlatAuction.Backend.Controllers
{
    [MobileAppController]
    public class MyItemsController : ApiController
    {
        public IEnumerable<MyAuctionItem> Get()
        {
            var dbContext = new MobileServiceContext();

            var myItems = dbContext.AuctionItems.Select(item => new MyAuctionItem
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                CurrentBid = item.Bids.Count == 0 ? 0 : item.Bids.Max(bid=> bid.BidAmount),
                MyHighestBid = 0
            });

            return myItems;
        }
    }
}
