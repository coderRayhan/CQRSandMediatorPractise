﻿// <auto-generated />
using System;
using MediatrAndCQRSDemo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MediatrAndCQRSDemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MediatrAndCQRSDemo.Entities.EducationalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("CGPA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HighestDegree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassingYear")
                        .HasColumnType("int");

                    b.Property<int>("PersonalInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonalInfoId");

                    b.ToTable("EducationalInfos");
                });

            modelBuilder.Entity("MediatrAndCQRSDemo.Entities.PersonalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonalInfos");
                });

            modelBuilder.Entity("MediatrAndCQRSDemo.Entities.EducationalInfo", b =>
                {
                    b.HasOne("MediatrAndCQRSDemo.Entities.PersonalInfo", "PersonalInfo")
                        .WithMany("EducationalInfos")
                        .HasForeignKey("PersonalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalInfo");
                });

            modelBuilder.Entity("MediatrAndCQRSDemo.Entities.PersonalInfo", b =>
                {
                    b.Navigation("EducationalInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
