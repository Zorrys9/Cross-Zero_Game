using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cross_zero.Data;
using cross_zero.Data.Repositories;
using cross_zero.Data.Repositories.Implementations;
using cross_zero.Hubs;
using cross_zero.Logic.Logics;
using cross_zero.Logic.Logics.Implementations;
using cross_zero.Services.Services;
using cross_zero.Services.Services.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace cross_zero
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSignalR();

            services.AddTransient<IHistoryGamesRepository, HistoryGamesRepository>();

            services.AddTransient<IHistoryGamesService, HistoryGamesService>();
            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IUserLogic, UserLogic>();
            services.AddTransient<IGameLogic, GameLogic>();

            services.AddSingleton<IUserIdProvider, UserIdProvider>();

            services.AddIdentity<IdentityUser, IdentityRole>(opt=>
            {

                opt.Password.RequireDigit = false;
                opt.Password.RequiredLength = 3;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;

            })
                .AddEntityFrameworkStores<GameContext>();

            services.AddEntityFrameworkNpgsql()
                .AddDbContext<GameContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("Default")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseSignalR(routes =>
            {

                routes.MapHub<CallHub>("/Call");
                routes.MapHub<GameHub>("/GameUsers");

            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
