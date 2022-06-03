﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyActiveLife.Database;

#nullable disable

namespace MyActiveLife.Database.Migrations
{
    [DbContext(typeof(MyActiveLifeDbContext))]
    partial class MyActiveLifeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyActiveLife.Database.Entities.Activity", b =>
                {
                    b.Property<Guid>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActivityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ActivityTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ActivityId");

                    b.HasIndex("ActivityTypeId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("SourceId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.ActivityType", b =>
                {
                    b.Property<int>("ActivityTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityTypeId"), 1L, 1);

                    b.Property<string>("ActivityTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityTypeId");

                    b.ToTable("ActivityType");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Photo", b =>
                {
                    b.Property<Guid>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SourceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PhotoId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("SourceId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Profile", b =>
                {
                    b.Property<Guid>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfileId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Source", b =>
                {
                    b.Property<Guid>("SourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SourceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SourceId");

                    b.ToTable("Source");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.StravaActivity", b =>
                {
                    b.HasBaseType("MyActiveLife.Database.Entities.Activity");

                    b.Property<float?>("AverageCadence")
                        .HasColumnType("real");

                    b.Property<float?>("AverageSpeed")
                        .HasColumnType("real");

                    b.Property<float?>("AverageTemp")
                        .HasColumnType("real");

                    b.Property<float?>("AverageWatts")
                        .HasColumnType("real");

                    b.Property<float?>("Calories")
                        .HasColumnType("real");

                    b.Property<float?>("Distance")
                        .HasColumnType("real");

                    b.Property<TimeSpan>("ElapsedTime")
                        .HasColumnType("time");

                    b.Property<float?>("ElevationHigh")
                        .HasColumnType("real");

                    b.Property<float?>("ElevationLow")
                        .HasColumnType("real");

                    b.Property<float?>("Kilojoules")
                        .HasColumnType("real");

                    b.Property<string>("MapPolyline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("MaxSpeed")
                        .HasColumnType("real");

                    b.Property<float?>("MaxWatts")
                        .HasColumnType("real");

                    b.Property<TimeSpan>("MovingTime")
                        .HasColumnType("time");

                    b.Property<float?>("SufferScore")
                        .HasColumnType("real");

                    b.Property<float?>("WeightedAverageWatts")
                        .HasColumnType("real");

                    b.ToTable("StravaActivity");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Activity", b =>
                {
                    b.HasOne("MyActiveLife.Database.Entities.ActivityType", "ActivityType")
                        .WithMany("Activities")
                        .HasForeignKey("ActivityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.Profile", "Profile")
                        .WithMany("Activities")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.Source", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActivityType");

                    b.Navigation("Profile");

                    b.Navigation("Source");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Photo", b =>
                {
                    b.HasOne("MyActiveLife.Database.Entities.Profile", "Profile")
                        .WithMany("Photos")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.Source", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("Source");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.StravaActivity", b =>
                {
                    b.HasOne("MyActiveLife.Database.Entities.Activity", null)
                        .WithOne()
                        .HasForeignKey("MyActiveLife.Database.Entities.StravaActivity", "ActivityId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.ActivityType", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Profile", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}