using Microsoft.Azure.Mobile.Server;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.OData;
using xPlatAuction.Backend.DataObjects;

namespace xPlatAuction.Backend.Models
{
    public class AuctionItemDomainManager : MappedEntityDomainManager<AuctionItem, AuctionItemDbEntity>
    {
        public AuctionItemDomainManager(DbContext context, HttpRequestMessage request) : base(context, request)
        { }

        public override IQueryable<AuctionItem> Query()
        {
            var dbContext = (MobileServiceContext)Context;

            var items = dbContext.AuctionItems
                                 .Select(auctionItem => new AuctionItem
                                 {
                                     Id = auctionItem.Id,
                                     Description = auctionItem.Description,
                                     StartingBid = auctionItem.StartingBid,
                                     Name = auctionItem.Name,
                                     AuctionId = auctionItem.AuctionId,
                                     Deleted = auctionItem.Deleted,
                                     CreatedAt = auctionItem.CreatedAt,
                                     UpdatedAt = auctionItem.UpdatedAt,
                                     Version = auctionItem.Version,
                                     CurrentBid = auctionItem.Bids.Count == 0
                                                     ? 0
                                                     : auctionItem.Bids.Max(b => b.BidAmount)
                                 });

            return items;
        }

        public override SingleResult<AuctionItem> Lookup(string id)
        {

            var dbContext = (MobileServiceContext)Context;

            var items = dbContext.AuctionItems
                                .Where(auctionItem => auctionItem.Id == id)
                                .Select(auctionItem => new AuctionItem
                                {
                                    Id = auctionItem.Id,
                                    Description = auctionItem.Description,
                                    StartingBid = auctionItem.StartingBid,
                                    Name = auctionItem.Name,
                                    AuctionId = auctionItem.AuctionId,
                                    Deleted = auctionItem.Deleted,
                                    CreatedAt = auctionItem.CreatedAt,
                                    UpdatedAt = auctionItem.UpdatedAt,
                                    Version = auctionItem.Version,
                                    CurrentBid = auctionItem.Bids.Count == 0
                                                      ? 0
                                                      : auctionItem.Bids.Max(b => b.BidAmount)
                                });

            return new SingleResult<AuctionItem>(items);

        }

        public override Task<bool> DeleteAsync(string id)
        {
            return base.DeleteItemAsync(id);
        }
        public override Task<AuctionItem> UpdateAsync(string id, Delta<AuctionItem> patch)
        {
            return base.UpdateEntityAsync(patch, id);
        }

    }
}