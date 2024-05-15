using CounterMotinor.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

internal static class WebApplicationExtensions
{
  public static async Task MigrateDatabase(this WebApplication webApplication)
  {
    using var scope = webApplication.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<CounterMonitorContext>();

    await db.Database.MigrateAsync();
  }
}