using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProgramowanieAplikacjiInternetowych.Repository;

namespace ProgramowanieAplikacjiInternetowych.Utils.ExtensionMethods
{
    public static class ApplicationBuilderExtensions
    {
        public static void UpdateDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<PaiDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
