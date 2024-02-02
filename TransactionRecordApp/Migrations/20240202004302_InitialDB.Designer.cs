﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransactionRecordApp.Entities;

#nullable disable

namespace TransactionRecordApp.Migrations
{
    [DbContext(typeof(TransactionDbContext))]
    [Migration("20240202004302_InitialDB")]
    partial class InitialDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TransactionRecordApp.Entities.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TickerSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("sharePrice")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            TransactionId = 1,
                            CompanyName = "Apple",
                            Quantity = 2,
                            TickerSymbol = "AAPL",
                            sharePrice = 194.62
                        },
                        new
                        {
                            TransactionId = 2,
                            CompanyName = "Ford Motors Company",
                            Quantity = 4,
                            TickerSymbol = "F",
                            sharePrice = 11.34
                        },
                        new
                        {
                            TransactionId = 3,
                            CompanyName = "Alphabet Inc.",
                            Quantity = 100,
                            TickerSymbol = "GOOG",
                            sharePrice = 146.50999999999999
                        },
                        new
                        {
                            TransactionId = 4,
                            CompanyName = "Microsoft Corporation",
                            Quantity = 100,
                            TickerSymbol = "MSFT",
                            sharePrice = 397.20999999999998
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
