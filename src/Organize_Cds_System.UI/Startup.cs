using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Organize_Cds_System.Application.Interfaces.Products.Cds;
using Organize_Cds_System.Application.OpenApp.Products.Cds;
using Organize_Cds_System.Domain.Interfaces.Generics;
using Organize_Cds_System.Domain.Interfaces.InterfaceServices.Products.Cds;
using Organize_Cds_System.Domain.Interfaces.Products.Cds;
using Organize_Cds_System.Domain.Services.Products.Cds;
using Organize_Cds_System.Entity.Entities.Persons.Users.Indentity;
using Organize_Cds_System.Infrastructure.Configurations.Context;
using Organize_Cds_System.Infrastructure.Repositories.Generics;
using Organize_Cds_System.Infrastructure.Repositories.Products.Cds;

namespace Organize_Cds_System.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BaseDbContext>(options =>
                  options.UseSqlServer(
                      Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<BaseDbContext>();
            services.AddControllersWithViews();


            // INTERFACE E REPOSITORIO
            services.AddSingleton(typeof(IGeneric<>), typeof(GenericRepository<>));
            services.AddSingleton<ICd, CdRepository>();

            // INTERFACE APLICA��O
            services.AddSingleton<ICdApp, CdApp>();

            // SERVI�O DOMINIO
            services.AddSingleton<IServiceCd, ServiceCd>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

        }
    }
}
