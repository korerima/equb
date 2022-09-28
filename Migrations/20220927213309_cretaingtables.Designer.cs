﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using equb.Data;

namespace equb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220927213309_cretaingtables")]
    partial class cretaingtables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("equb.Models.Account", b =>
                {
                    b.Property<int>("account_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("balance")
                        .IsRequired()
                        .HasColumnType("real");

                    b.Property<int?>("cust_id")
                        .HasColumnType("int");

                    b.HasKey("account_id");

                    b.HasIndex("cust_id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("equb.Models.Customer", b =>
                {
                    b.Property<int>("cust_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("contact")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("f_name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("l_name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cust_id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("equb.Models.Equb_detail", b =>
                {
                    b.Property<int>("equb_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("amount")
                        .IsRequired()
                        .HasColumnType("real");

                    b.Property<int?>("cust_id")
                        .HasColumnType("int");

                    b.Property<string>("cycle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("end_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("equb_name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("number_of_users")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("equb_id");

                    b.HasIndex("cust_id");

                    b.ToTable("Equb_detail");
                });

            modelBuilder.Entity("equb.Models.Equb_order", b =>
                {
                    b.Property<int>("equb_order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("cust_id")
                        .HasColumnType("int");

                    b.Property<int?>("equb_id")
                        .HasColumnType("int");

                    b.Property<int>("order")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("win_date")
                        .HasColumnType("datetime2");

                    b.HasKey("equb_order_id");

                    b.HasIndex("cust_id");

                    b.HasIndex("equb_id");

                    b.ToTable("Equb_order");
                });

            modelBuilder.Entity("equb.Models.Reserves", b =>
                {
                    b.Property<int>("reserve_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("cust_id")
                        .HasColumnType("int");

                    b.Property<int?>("equb_id")
                        .HasColumnType("int");

                    b.Property<int>("order")
                        .HasColumnType("int");

                    b.HasKey("reserve_id");

                    b.HasIndex("cust_id");

                    b.HasIndex("equb_id");

                    b.ToTable("Reserves");
                });

            modelBuilder.Entity("equb.Models.Transact", b =>
                {
                    b.Property<int>("trans_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("amount")
                        .IsRequired()
                        .HasColumnType("real");

                    b.Property<int>("cust_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<string>("trans_to")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trans_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("trans_id");

                    b.HasIndex("cust_id");

                    b.ToTable("Transact");
                });

            modelBuilder.Entity("equb.Models.Account", b =>
                {
                    b.HasOne("equb.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("cust_id");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("equb.Models.Equb_detail", b =>
                {
                    b.HasOne("equb.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("cust_id");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("equb.Models.Equb_order", b =>
                {
                    b.HasOne("equb.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("cust_id");

                    b.HasOne("equb.Models.Equb_detail", "Equb_detail")
                        .WithMany()
                        .HasForeignKey("equb_id");

                    b.Navigation("Customer");

                    b.Navigation("Equb_detail");
                });

            modelBuilder.Entity("equb.Models.Reserves", b =>
                {
                    b.HasOne("equb.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("cust_id");

                    b.HasOne("equb.Models.Equb_detail", "Equb_detail")
                        .WithMany()
                        .HasForeignKey("equb_id");

                    b.Navigation("Customer");

                    b.Navigation("Equb_detail");
                });

            modelBuilder.Entity("equb.Models.Transact", b =>
                {
                    b.HasOne("equb.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("cust_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}