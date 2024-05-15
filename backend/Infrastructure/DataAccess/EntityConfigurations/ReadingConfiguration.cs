using CounterMotinor.Domain.Entities.Readings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal sealed class ReadingConfiguration : IEntityTypeConfiguration<Reading>
{
  public void Configure(EntityTypeBuilder<Reading> builder)
  {
    builder.ToTable("Readings");

    builder.HasKey(reading => reading.Id);

    builder.Property(reading => reading.Id)
           .HasConversion(id => id.Value, value => ReadingId.Create(value));

    builder.Property(reading => reading.Date)
           .IsRequired();

    builder.Property(reading => reading.Value)
           .IsRequired()
           .HasConversion(value => value.Value, value => NonNegativeDouble.Create(value));
  }
}