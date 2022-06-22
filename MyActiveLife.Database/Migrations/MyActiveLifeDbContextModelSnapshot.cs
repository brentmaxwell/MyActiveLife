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
                .HasAnnotation("ProductVersion", "6.0.6")
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

                    b.Property<Guid>("DayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WeatherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ActivityId");

                    b.HasIndex("ActivityTypeId");

                    b.HasIndex("DayId");

                    b.HasIndex("SourceId");

                    b.HasIndex("UserId");

                    b.HasIndex("WeatherId");

                    b.ToTable("Activity", (string)null);
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

                    b.ToTable("ActivityType", (string)null);
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Day", b =>
                {
                    b.Property<Guid>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WeatherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DayId");

                    b.HasIndex("WeatherId");

                    b.HasIndex("UserId", "Date")
                        .IsUnique();

                    b.ToTable("Day", (string)null);
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Diary", b =>
                {
                    b.Property<Guid>("DiaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Entry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DiaryId");

                    b.HasIndex("DayId");

                    b.HasIndex("UserId");

                    b.ToTable("Diary", (string)null);
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Mood", b =>
                {
                    b.Property<Guid>("MoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<short>("MoodLevel")
                        .HasColumnType("smallint");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserProfileUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MoodId");

                    b.HasIndex("DayId");

                    b.HasIndex("UserProfileUserId");

                    b.ToTable("Mood", (string)null);
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Photo", b =>
                {
                    b.Property<Guid>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PhotoId");

                    b.HasIndex("DayId");

                    b.HasIndex("SourceId");

                    b.HasIndex("UserId");

                    b.ToTable("Photo", (string)null);
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Phq9", b =>
                {
                    b.Property<Guid>("Phq9Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Answer1")
                        .HasColumnType("int");

                    b.Property<int>("Answer2")
                        .HasColumnType("int");

                    b.Property<int>("Answer3")
                        .HasColumnType("int");

                    b.Property<int>("Answer4")
                        .HasColumnType("int");

                    b.Property<int>("Answer5")
                        .HasColumnType("int");

                    b.Property<int>("Answer6")
                        .HasColumnType("int");

                    b.Property<int>("Answer7")
                        .HasColumnType("int");

                    b.Property<int>("Answer8")
                        .HasColumnType("int");

                    b.Property<int>("Answer9")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Phq9Id");

                    b.HasIndex("DayId");

                    b.HasIndex("UserId");

                    b.ToTable("Phq9s", (string)null);
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

                    b.ToTable("Source", (string)null);
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.UserProfile", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserProfile", (string)null);
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Weather", b =>
                {
                    b.Property<Guid>("WeatherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<float?>("Dewpoint")
                        .HasColumnType("real");

                    b.Property<float?>("MaxTemperature")
                        .HasColumnType("real");

                    b.Property<float?>("MinTemperature")
                        .HasColumnType("real");

                    b.Property<float?>("Precipitation")
                        .HasColumnType("real");

                    b.Property<string>("StationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Temperature")
                        .HasColumnType("real");

                    b.Property<int?>("WindDirection")
                        .HasColumnType("int");

                    b.Property<float?>("WindGust")
                        .HasColumnType("real");

                    b.Property<float?>("WindSpeed")
                        .HasColumnType("real");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeatherId");

                    b.ToTable("Weather", (string)null);
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("MaxSpeed")
                        .HasColumnType("real");

                    b.Property<float?>("MaxWatts")
                        .HasColumnType("real");

                    b.Property<TimeSpan>("MovingTime")
                        .HasColumnType("time");

                    b.Property<float?>("SufferScore")
                        .HasColumnType("real");

                    b.Property<float?>("TotalElevationGain")
                        .HasColumnType("real");

                    b.Property<float?>("WeightedAverageWatts")
                        .HasColumnType("real");

                    b.ToTable("StravaActivity", (string)null);
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Activity", b =>
                {
                    b.HasOne("MyActiveLife.Database.Entities.ActivityType", "ActivityType")
                        .WithMany("Activities")
                        .HasForeignKey("ActivityTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.Day", "Day")
                        .WithMany("Activities")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.Source", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.UserProfile", "UserProfile")
                        .WithMany("Activities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.Weather", "Weather")
                        .WithMany()
                        .HasForeignKey("WeatherId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ActivityType");

                    b.Navigation("Day");

                    b.Navigation("Source");

                    b.Navigation("UserProfile");

                    b.Navigation("Weather");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Day", b =>
                {
                    b.HasOne("MyActiveLife.Database.Entities.UserProfile", "Profile")
                        .WithMany("Days")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.Weather", "Weather")
                        .WithMany()
                        .HasForeignKey("WeatherId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Profile");

                    b.Navigation("Weather");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Diary", b =>
                {
                    b.HasOne("MyActiveLife.Database.Entities.Day", "Day")
                        .WithMany()
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.UserProfile", "UserProfile")
                        .WithMany("Diaries")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Mood", b =>
                {
                    b.HasOne("MyActiveLife.Database.Entities.Day", "Day")
                        .WithMany("Moods")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.UserProfile", null)
                        .WithMany("Moods")
                        .HasForeignKey("UserProfileUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Day");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Photo", b =>
                {
                    b.HasOne("MyActiveLife.Database.Entities.Day", "Day")
                        .WithMany("Photos")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.Source", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.UserProfile", "UserProfile")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("Source");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.Phq9", b =>
                {
                    b.HasOne("MyActiveLife.Database.Entities.Day", "Day")
                        .WithMany("Phq9s")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MyActiveLife.Database.Entities.UserProfile", "UserProfile")
                        .WithMany("Phq9s")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("UserProfile");
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

            modelBuilder.Entity("MyActiveLife.Database.Entities.Day", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Moods");

                    b.Navigation("Photos");

                    b.Navigation("Phq9s");
                });

            modelBuilder.Entity("MyActiveLife.Database.Entities.UserProfile", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Days");

                    b.Navigation("Diaries");

                    b.Navigation("Moods");

                    b.Navigation("Photos");

                    b.Navigation("Phq9s");
                });
#pragma warning restore 612, 618
        }
    }
}
