using LMC.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LMC.Web.Areas.Identity.IdentityHostingStartup))]
namespace LMC.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<LMCIdentityContext>(options =>
                    options.UseSqlite("Filename=LMCIdentity.db"));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<LMCIdentityContext>();
            });
        }
    }
}