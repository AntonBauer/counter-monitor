﻿// <auto-generated />
using System;
using CounterMotinor.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CounterMotinor.Infrastructure.DataAccess.Migrations
{
    [DbContext(typeof(CounterMonitorContext))]
    [Migration("20240519170725_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("monitor")
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CounterMotinor.Domain.Entities.Counters.Counter", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Counters", "monitor");
                });

            modelBuilder.Entity("CounterMotinor.Domain.Entities.Readings.Reading", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CounterId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CounterId");

                    b.ToTable("Readings", "monitor");
                });

            modelBuilder.Entity("CounterMotinor.Domain.Entities.Readings.Reading", b =>
                {
                    b.HasOne("CounterMotinor.Domain.Entities.Counters.Counter", null)
                        .WithMany("Readings")
                        .HasForeignKey("CounterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CounterMotinor.Domain.Entities.Counters.Counter", b =>
                {
                    b.Navigation("Readings");
                });
#pragma warning restore 612, 618
        }
    }
}