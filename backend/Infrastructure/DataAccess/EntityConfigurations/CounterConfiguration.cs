using CounterMotinor.Domain.Entities.Counters;
using GeneralDomain.UtilityTypes;
using LanguageExt.SomeHelp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal sealed class CounterConfiguration : IEntityTypeConfiguration<Counter>
{
  public void Configure(EntityTypeBuilder<Counter> builder)
  {
    builder.ToTable("Counters");

    builder.HasKey(counter => counter.Id);

    builder.Property(counter => counter.Id)
           .HasConversion(id => id.Value, value => CounterId.CreateFrom(value));
                        
    builder.Property(counter => counter.Name)
           .IsRequired()
           .HasConversion(name => name.Value, value => NonEmptyString.Create(value).ToSome().Value);

    builder.HasMany(counter => counter.Readings)
           .WithOne()
           .IsRequired()
           .OnDelete(DeleteBehavior.Cascade);
  }
}