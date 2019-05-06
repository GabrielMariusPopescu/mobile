using System.Web.Http;
using xPlatAuction.Backend.DataObjects;
using xPlatAuction.Backend.Models;

namespace xPlatAuction.Backend
{
    public partial class Startup
    {
        public static void ConfigureAutoMapper(HttpConfiguration config)
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AuctionItem, AuctionItemDbEntity>();
                cfg.CreateMap<AuctionItemDbEntity, AuctionItem>()
                      .ForMember(auctionItem => auctionItem.CurrentBid, map => map.UseValue(0.0));
            });
        }
    }
}