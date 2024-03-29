﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TableBooking.Data;

namespace TableBooking.Migrations
{
    [DbContext(typeof(BookingContext))]
    [Migration("20190805082520_InitSetUp")]
    partial class InitSetUp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TableBooking.Data.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookedFrom");

                    b.Property<string>("BookedUntil");

                    b.Property<DateTime>("BookingDate");

                    b.Property<int>("CustomerID");

                    b.Property<int>("PartySize");

                    b.Property<int>("TableID");

                    b.HasKey("BookingID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TableID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TableBooking.Data.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Mobile");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TableBooking.Data.Table", b =>
                {
                    b.Property<int>("TableID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TableNumber");

                    b.HasKey("TableID");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("TableBooking.Data.Booking", b =>
                {
                    b.HasOne("TableBooking.Data.Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TableBooking.Data.Table")
                        .WithMany("Bookings")
                        .HasForeignKey("TableID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
