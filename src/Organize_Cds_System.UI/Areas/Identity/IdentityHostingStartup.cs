using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Organize_Cds_System.UI.Areas.Identity.IdentityHostingStartup))]
namespace Organize_Cds_System.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}