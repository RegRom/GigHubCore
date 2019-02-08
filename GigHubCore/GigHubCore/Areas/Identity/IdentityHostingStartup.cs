using System;
using GigHubCore.Areas.Identity.Data;
using GigHubCore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GigHubCore.Areas.Identity.IdentityHostingStartup))]
namespace GigHubCore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GigHubCoreContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GigHubCoreContextConnection")));

                services.AddDefaultIdentity<GigHubCoreUser>()
                    .AddEntityFrameworkStores<GigHubCoreContext>();
            });
        }
    }
}