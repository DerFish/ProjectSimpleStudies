﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleStudies.Data.Entities;

#nullable disable

namespace SimpleStudies.Data.Migrations
{
    [DbContext(typeof(SimpleStudiesDbContext))]
    [Migration("20220428113456_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("SimpleStudies.Data.Entities.Dozent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Dozent");
                });

            modelBuilder.Entity("SimpleStudies.Data.Entities.Hausaufgabe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Beschreibung")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("GeplantAm")
                        .HasColumnType("TEXT");

                    b.Property<int>("KursId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notizen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KursId");

                    b.ToTable("Hausaufgabe");
                });

            modelBuilder.Entity("SimpleStudies.Data.Entities.Kurs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DozentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ECTS")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Semester")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DozentId");

                    b.ToTable("Kurs");
                });

            modelBuilder.Entity("SimpleStudies.Data.Entities.Lernplan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Beschreibung")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("GeplantAm")
                        .HasColumnType("TEXT");

                    b.Property<int>("KursId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notizen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KursId");

                    b.ToTable("Lernplan");
                });

            modelBuilder.Entity("SimpleStudies.Data.Entities.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("EndNote")
                        .HasColumnType("TEXT");

                    b.Property<int>("KursId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("KursId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("SimpleStudies.Data.Entities.Hausaufgabe", b =>
                {
                    b.HasOne("SimpleStudies.Data.Entities.Kurs", "Kurs")
                        .WithMany()
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kurs");
                });

            modelBuilder.Entity("SimpleStudies.Data.Entities.Kurs", b =>
                {
                    b.HasOne("SimpleStudies.Data.Entities.Dozent", "Dozent")
                        .WithMany()
                        .HasForeignKey("DozentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dozent");
                });

            modelBuilder.Entity("SimpleStudies.Data.Entities.Lernplan", b =>
                {
                    b.HasOne("SimpleStudies.Data.Entities.Kurs", "Kurs")
                        .WithMany()
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kurs");
                });

            modelBuilder.Entity("SimpleStudies.Data.Entities.Note", b =>
                {
                    b.HasOne("SimpleStudies.Data.Entities.Kurs", "Kurs")
                        .WithMany()
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kurs");
                });
#pragma warning restore 612, 618
        }
    }
}
