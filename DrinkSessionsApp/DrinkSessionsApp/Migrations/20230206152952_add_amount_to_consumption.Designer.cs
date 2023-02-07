﻿// <auto-generated />
using System;
using DrinkSessionsApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrinkSessionsApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230206152952_add_amount_to_consumption")]
    partial class addamounttoconsumption
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DrinkSessionsApp.Models.Consumption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("DrinkSessionId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DrinkSessionId");

                    b.HasIndex("ProductId");

                    b.ToTable("Consumptions");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.DrinkSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Closed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ClosedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VenueId");

                    b.ToTable("DrinkSessions");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VenueId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.Venue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.Consumption", b =>
                {
                    b.HasOne("DrinkSessionsApp.Models.DrinkSession", "DrinkSession")
                        .WithMany("Consumptions")
                        .HasForeignKey("DrinkSessionId");

                    b.HasOne("DrinkSessionsApp.Models.Product", "Product")
                        .WithMany("Consumptions")
                        .HasForeignKey("ProductId");

                    b.Navigation("DrinkSession");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.DrinkSession", b =>
                {
                    b.HasOne("DrinkSessionsApp.Models.User", "User")
                        .WithMany("DrinkSessions")
                        .HasForeignKey("UserId");

                    b.HasOne("DrinkSessionsApp.Models.Venue", "Venue")
                        .WithMany("DrinkSessions")
                        .HasForeignKey("VenueId");

                    b.Navigation("User");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.Product", b =>
                {
                    b.HasOne("DrinkSessionsApp.Models.Venue", "Venue")
                        .WithMany("Products")
                        .HasForeignKey("VenueId");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.DrinkSession", b =>
                {
                    b.Navigation("Consumptions");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.Product", b =>
                {
                    b.Navigation("Consumptions");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.User", b =>
                {
                    b.Navigation("DrinkSessions");
                });

            modelBuilder.Entity("DrinkSessionsApp.Models.Venue", b =>
                {
                    b.Navigation("DrinkSessions");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
