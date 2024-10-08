﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLiteEF_LoRa.Data;

#nullable disable

namespace SQLiteEF_LoRa.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240722113756_initialdb")]
    partial class initialdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("SQLiteEF_LoRa.Models.LoRaCommModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CRCStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataRate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("FrameCounter")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Frequency")
                        .HasColumnType("REAL");

                    b.Property<int>("MessageLength")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte>("Port")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RSSI")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SNR")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tbLoRaComm");
                });
#pragma warning restore 612, 618
        }
    }
}
