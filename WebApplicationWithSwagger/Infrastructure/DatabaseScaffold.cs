using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplicationWithSwagger.Context;

namespace WebApplicationWithSwagger.Infrastructure
{
    public static class DatabaseScaffold
    {
        public static IHost Migrate(this IHost host) {
            var ServiceScopeFactory = (IServiceScopeFactory)host.Services.GetService(typeof(IServiceScopeFactory));

            using (var scope = ServiceScopeFactory.CreateScope())
            {
                var service = scope.ServiceProvider;
                var dbContext = service.GetRequiredService<WebAppContext>();
                dbContext.Database.Migrate();
            }
            return host;
        }
    }
}
