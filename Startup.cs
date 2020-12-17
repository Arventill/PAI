using ProgramowanieAplikacjiInternetowych.Repository;
using ProgramowanieAplikacjiInternetowych.Repository.Users;
using ProgramowanieAplikacjiInternetowych.Repository.Models;
using ProgramowanieAplikacjiInternetowych.Services.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProgramowanieAplikacjiInternetowych.Utils;
using ProgramowanieAplikacjiInternetowych.Utils.ExtensionMethods;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace ProgramowanieAplikacjiInternetowych
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<PaiDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            RegisterUtilities(ref services);
            RegisterServices(ref services);
            RegisterRepositories(ref services);

#if DEBUG
            services.AddCors(options =>
            {
                options.AddPolicy(AppSettings.CorsConfigurationName,
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                    });
            });
#endif
        }

        private static void RegisterUtilities(ref IServiceCollection services)
        {
            //
        }

        private static void RegisterServices(ref IServiceCollection services)
        {
            services.AddTransient<IUsersDataService, UserDataService>();
        }

        private static void RegisterRepositories(ref IServiceCollection services)
        {
            services.AddTransient<IUsersRepository, UsersRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors(AppSettings.CorsConfigurationName);
            }
            else
            {
                app.UseHsts();
            }

            app.UpdateDatabase();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
