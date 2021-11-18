using System;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Ordering.API.Extensions
{
    public static class HostExtensions
    {
        public static IHost MigrateDatabase<TContext>
            (this IHost host, Action<TContext, IServiceProvider> seeder, int? retry = 0) where TContext : DbContext
        {
            int retryForAvailability = retry.Value;
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            var logger = services.GetRequiredService<ILogger<TContext>>();
            var context = services.GetService<TContext>();
            try
            {
                logger.LogInformation("Migration started with context {Context}", typeof(TContext));

                InvokeSeeder(seeder, context, services);
                
                logger.LogInformation("Migration ended with context {Context}", typeof(TContext));

            }
            catch (Exception e)
            {
                logger.LogError(e, "Error occurred while migrating the database on context {Context}", typeof(TContext));
                if (retryForAvailability < 50)
                {
                    retryForAvailability++;
                    Thread.Sleep(2000);
                    MigrateDatabase<TContext>(host, seeder, retryForAvailability);
                }
            }

            return host;
        }

        private static void InvokeSeeder<TContext>(Action<TContext,IServiceProvider> seeder, 
                                                    TContext context, 
                                                    IServiceProvider services) 
                                                    where TContext : DbContext
        {
            context.Database.Migrate();
            seeder(context, services);
        }
    }
}