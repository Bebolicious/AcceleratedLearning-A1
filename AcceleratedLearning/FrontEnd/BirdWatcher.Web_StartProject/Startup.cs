using BirdWatcher.Web.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BirdWatcher.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ObservationContext>(options =>
                options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = BirdWatcherDb;"));

            services.AddTransient<Repository, Repository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseDirectoryBrowser();
            app.UseMvc();

        }
    }
}
