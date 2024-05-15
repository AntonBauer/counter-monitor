using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CounterMotinor.Infrastructure.DataAccess;
public static class ServiceCollectionExtensions
{
  internal const string ConnectionStringName = "CounterMonitorConnection";

  public static IServiceCollection AddDataAccess(this IServiceCollection services,
                                                 IConfiguration configuration) =>
    services.AddDbContext<CounterMonitorContext>(options =>
      options.UseNpgsql(configuration.GetConnectionString(ConnectionStringName)));

}