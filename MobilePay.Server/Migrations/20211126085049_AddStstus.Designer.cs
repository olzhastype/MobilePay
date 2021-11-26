﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobilePay.Model;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MobilePay.Server.Migrations
{
    [DbContext(typeof(ModelDbContext))]
    [Migration("20211126085049_AddStstus")]
    partial class AddStstus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MobilePay.Model.Pay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Cost")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<string>("SenderName")
                        .HasColumnType("text");

                    b.Property<bool?>("Successfully")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Pays");
                });

            modelBuilder.Entity("MobilePay.Model.PayLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SenderName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PayLogs");
                });
#pragma warning restore 612, 618
        }
    }
}