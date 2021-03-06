using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Organize_Cds_System.Entity.Entities.Persons.Users.Indentity;
using Organize_Cds_System.Infrastructure.Configurations.Context;

[assembly: HostingStartup(typeof(Organize_Cds_System.UI.Areas.Identity.IdentityHostingStartup))]
namespace Organize_Cds_System.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}