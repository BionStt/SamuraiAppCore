﻿// <auto-generated />
using EFCoreUWP.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EFCoreUWP.Model.Migrations
{
    [DbContext(typeof(BingeContext))]
    [Migration("20180410144608_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("EFCoreUWP.Model.CookieBinge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HowMany");

                    b.Property<DateTime>("TimeOccurred");

                    b.Property<bool>("WorthIt");

                    b.HasKey("Id");

                    b.ToTable("Binges");
                });
#pragma warning restore 612, 618
        }
    }
}
