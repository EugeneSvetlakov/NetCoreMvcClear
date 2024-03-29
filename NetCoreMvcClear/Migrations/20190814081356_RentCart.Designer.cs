﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreMvcClear.Data;

namespace NetCoreMvcClear.Migrations
{
    [DbContext(typeof(AppDbContent))]
    [Migration("20190814081356_RentCart")]
    partial class RentCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCoreMvcClear.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NetCoreMvcClear.Data.Models.RentCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Quantity");

                    b.Property<string>("RentCartId");

                    b.Property<int?>("RentItemId");

                    b.HasKey("Id");

                    b.HasIndex("RentItemId");

                    b.ToTable("RentCartItems");
                });

            modelBuilder.Entity("NetCoreMvcClear.Data.Models.RentItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName");

                    b.Property<string>("Desc");

                    b.Property<string>("ImgUrl");

                    b.Property<bool>("IsAvailable");

                    b.Property<string>("Name");

                    b.Property<int>("RentPrice");

                    b.Property<int>("Size");

                    b.Property<int>("categoryId");

                    b.HasKey("Id");

                    b.HasIndex("categoryId");

                    b.ToTable("RentItems");
                });

            modelBuilder.Entity("NetCoreMvcClear.Data.Models.RentCartItem", b =>
                {
                    b.HasOne("NetCoreMvcClear.Data.Models.RentItem", "RentItem")
                        .WithMany()
                        .HasForeignKey("RentItemId");
                });

            modelBuilder.Entity("NetCoreMvcClear.Data.Models.RentItem", b =>
                {
                    b.HasOne("NetCoreMvcClear.Data.Models.Category", "Category")
                        .WithMany("RentItems")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
