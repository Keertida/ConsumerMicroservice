﻿// <auto-generated />
using System;
using ConsumerMicroservice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsumerMicroservice.Migrations
{
    [DbContext(typeof(InsureityPortalDBContext))]
    [Migration("20220911192032_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsumerMicroservice.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessMasterId")
                        .HasColumnType("int");

                    b.Property<string>("BusinessName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsumerId")
                        .HasColumnType("int");

                    b.Property<int>("TotalEmployees")
                        .HasColumnType("int");

                    b.HasKey("BusinessId");

                    b.HasIndex("BusinessMasterId");

                    b.ToTable("Business");
                });

            modelBuilder.Entity("ConsumerMicroservice.Models.BusinessMaster", b =>
                {
                    b.Property<int>("BusinessMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusinessTurnOver")
                        .HasColumnType("int");

                    b.Property<int>("BusinessValue")
                        .HasColumnType("int");

                    b.Property<int>("CapitalInvest")
                        .HasColumnType("int");

                    b.HasKey("BusinessMasterId");

                    b.ToTable("BusinessMaster");
                });

            modelBuilder.Entity("ConsumerMicroservice.Models.Consumer", b =>
                {
                    b.Property<int>("ConsumerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<int>("BusinessValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pancard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("annual_turnover")
                        .HasColumnType("int");

                    b.Property<string>("business_Overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("capitalInvested")
                        .HasColumnType("int");

                    b.Property<int>("no_of_employees")
                        .HasColumnType("int");

                    b.HasKey("ConsumerId");

                    b.ToTable("Consumer");
                });

            modelBuilder.Entity("ConsumerMicroservice.Models.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingAge")
                        .HasColumnType("int");

                    b.Property<int>("BuildingStoreys")
                        .HasColumnType("int");

                    b.Property<string>("BuildingType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Buildingsqft")
                        .HasColumnType("int");

                    b.Property<int>("ConsumerId")
                        .HasColumnType("int");

                    b.Property<int>("CostOfAssest")
                        .HasColumnType("int");

                    b.Property<int>("PropertyValue")
                        .HasColumnType("int");

                    b.Property<int>("SalvageValue")
                        .HasColumnType("int");

                    b.Property<int>("UsefulLifeOfAssest")
                        .HasColumnType("int");

                    b.HasKey("PropertyId");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("ConsumerMicroservice.Models.Business", b =>
                {
                    b.HasOne("ConsumerMicroservice.Models.BusinessMaster", "BusinessMaster")
                        .WithMany()
                        .HasForeignKey("BusinessMasterId");

                    b.Navigation("BusinessMaster");
                });
#pragma warning restore 612, 618
        }
    }
}
