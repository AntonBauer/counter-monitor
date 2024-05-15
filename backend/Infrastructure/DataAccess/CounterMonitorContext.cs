using CounterMotinor.Domain.Entities.Counters;
using Microsoft.EntityFrameworkCore;

namespace CounterMotinor.Infrastructure.DataAccess;

public sealed class CounterMonitorContext(DbContextOptions<CounterMonitorContext> options) : DbContext(options)
{
  public DbSet<Counter> Counters => Set<Counter>();

  protected override void OnModelCreating(ModelBuilder modelBuilder) =>
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(CounterMonitorContext).Assembly)
                .HasDefaultSchema("monitor");
}