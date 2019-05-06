using Microsoft.Azure.Mobile.Server;
using System;

namespace xPlatAuction.Backend.DataObjects
{
    public class Auction :EntityData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}