﻿// <auto-generated />
using System;
using AuvoChallenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuvoChallenge.Migrations
{
    [DbContext(typeof(AuvoChallengeContext))]
    [Migration("20210627221403_Other")]
    partial class Other
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AuvoChallenge.Models.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name");

                    b.Property<string>("Observation");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.ToTable("Transfer");
                });
#pragma warning restore 612, 618
        }
    }
}
