using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project4SAD.Data;
using Project4SAD.Models;
using Project4SAD.Repstory;

namespace Project4SAD
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDbContext<DbAppContext>(option=>option.UseSqlServer(@"Server=LAPTOP-7KTRGKH2\SQLEXPRESS;Database=Pizz;Trusted_Connection=True;"));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DbAppContext>();
            services.AddSession();
            services.AddScoped<IRepstory<Pizza>, RepstoryPizza>();
            services.AddScoped<IRepstory<Customer>, RepstoryCustomer>();
            services.AddScoped<IRepstory<CustomerOrder>, RepstoryCustomerOrder>();
            services.AddScoped<IRepstory<Order>, RepstoryOrder>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
           // app.UseSession();
            app.UseStaticFiles();
            app.UseSession();
            /* app.UseEndpoints(endpoints =>
             {
           //   endpoints.

             });*/

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
