﻿// <auto-generated />
using System;
using AuctionGrpcService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AuctionGrpcService.Migrations
{
    [DbContext(typeof(AuctionContext))]
    partial class AuctionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("AuctionGrpcService.Models.Auction", b =>
                {
                    b.Property<int>("AuctionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ActionIsOver")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AuctionDateEnd")
                        .HasColumnType("TEXT");

                    b.Property<int>("AuctionPicId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AuctionPrice")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuctionId");

                    b.HasIndex("ClientId");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("AuctionGrpcService.Models.Bid", b =>
                {
                    b.Property<int>("BidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuctionId")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("BidIsWinner")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BidPrice")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BidId");

                    b.HasIndex("AuctionId");

                    b.HasIndex("ClientId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("AuctionGrpcService.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientDir")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("AuctionGrpcService.Models.Auction", b =>
                {
                    b.HasOne("AuctionGrpcService.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("AuctionGrpcService.Models.Bid", b =>
                {
                    b.HasOne("AuctionGrpcService.Models.Auction", "Auction")
                        .WithMany()
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuctionGrpcService.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}