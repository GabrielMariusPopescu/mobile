using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Swagger;
using Swashbuckle.Application;
using System.Web.Http;
using System.Web.Http.Description;

namespace xPlatAuction.Backend
{
    public partial class Startup
    {
        public static void ConfigureSwagger(HttpConfiguration config)
        {
            config.Services.Replace(typeof(IApiExplorer), new MobileAppApiExplorer(config));
            config.EnableSwagger(it =>
                   {
                       it.SingleApiVersion("V1", "My First Mobile App");
                       it.OperationFilter<MobileAppHeaderFilter>();
                       it.SchemaFilter<MobileAppSchemaFilter>();
                   })
                  .EnableSwaggerUi();
        }

    }
}