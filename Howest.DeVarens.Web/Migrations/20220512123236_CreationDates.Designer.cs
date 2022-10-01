﻿// <auto-generated />
using System;
using Howest.DeVarens.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Howest.DeVarens.Web.Migrations
{
    [DbContext(typeof(WebshopContext))]
    [Migration("20220512123236_CreationDates")]
    partial class CreationDates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(3824),
                            Description = "Het maken van figuren in hout.",
                            Name = "Houtbewerking"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(3860),
                            Description = "Kunst door middel van verf op canvas.",
                            Name = "Schilderen"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(3863),
                            Description = "Het bijeenlassen van metalen onderdelen.",
                            Name = "Metaalbewerking"
                        });
                });

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.FormOfEducation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("FormOfEducation");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4047),
                            Description = "Opleidingsvorm 1 richt zich op jongeren met een matige tot ernstige verstandelijke beperking (type 2), al dan niet gecombineerd met een motorische beperking (type 4).",
                            DisplayOrder = 1,
                            Name = "Opleidingsvorm 1"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4051),
                            Description = "Opleidingsvorm 2 geeft een algemene en sociale vorming en een arbeidstraining met het oog op de integratie in een beschermd arbeids- en werkmilieu (maatwerkbedrijf).",
                            DisplayOrder = 2,
                            Name = "Opleidingsvorm 2"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4055),
                            Description = "In opleidingsvorm 3 krijgen de leerlingen een algemene, sociale en beroepsgerichte vorming met als einddoel een tewerkstelling in het gewone arbeidsmilieu. Dit voor leerlingen met type basisaanbod, 3, 4 en 9.",
                            DisplayOrder = 3,
                            Name = "Opleidingsvorm 3"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4058),
                            Description = "Opleidingsvorm 4 behandelt de leerstof en eindtermen van het gewoon onderwijs, mét omkadering van buitengewoon onderwijs.",
                            DisplayOrder = 4,
                            Name = "Opleidingsvorm 4"
                        });
                });

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Medias");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4106),
                            Path = "ironman.png",
                            ProductId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Title = "Ironman"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4110),
                            Path = "dinosaurus.jpg",
                            ProductId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Title = "Dinosaurus"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4113),
                            Path = "hout.jpg",
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Title = "Hout"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4116),
                            Path = "hout2.jpg",
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Title = "Hout"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4120),
                            Path = "schilderij.jpg",
                            ProductId = new Guid("00000000-0000-0000-0000-000000000004"),
                            Title = "Schilderij"
                        });
                });

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FormOfEducationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FormOfEducationId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4078),
                            Description = "Dit is de geweldige Ironman.",
                            FormOfEducationId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "Ironman",
                            Price = 16.99m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4084),
                            Description = "Dit is een grote dinosaurus.",
                            FormOfEducationId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Name = "Dinosaurus",
                            Price = 79.99m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4088),
                            Description = "Dit is een houten kunstwerk.",
                            FormOfEducationId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Name = "Houten kunstwerk",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreationDate = new DateTime(2022, 5, 12, 14, 32, 35, 778, DateTimeKind.Local).AddTicks(4092),
                            Description = "Dit is een schilderij.",
                            FormOfEducationId = new Guid("00000000-0000-0000-0000-000000000004"),
                            Name = "Schilderij",
                            Price = 199.99m
                        });
                });

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.Media", b =>
                {
                    b.HasOne("Howest.DeVarens.Core.Entities.Product", null)
                        .WithMany("Media")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.OrderItem", b =>
                {
                    b.HasOne("Howest.DeVarens.Core.Entities.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.HasOne("Howest.DeVarens.Core.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.Product", b =>
                {
                    b.HasOne("Howest.DeVarens.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Howest.DeVarens.Core.Entities.FormOfEducation", "FormOfEducation")
                        .WithMany()
                        .HasForeignKey("FormOfEducationId");

                    b.Navigation("Category");

                    b.Navigation("FormOfEducation");
                });

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Howest.DeVarens.Core.Entities.Product", b =>
                {
                    b.Navigation("Media");
                });
#pragma warning restore 612, 618
        }
    }
}
