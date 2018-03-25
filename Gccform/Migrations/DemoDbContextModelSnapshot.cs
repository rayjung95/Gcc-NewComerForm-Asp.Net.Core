﻿// <auto-generated />
using Gccform.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Gccform.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    partial class DemoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Gccform.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PersonID");

                    b.Property<string>("city")
                        .HasMaxLength(100);

                    b.Property<string>("postal_code")
                        .HasMaxLength(100);

                    b.Property<string>("street1")
                        .HasMaxLength(100);

                    b.Property<string>("street2")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Gccform.Models.Church", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PersonID");

                    b.Property<string>("baptized_church")
                        .HasMaxLength(100);

                    b.Property<DateTime>("baptized_date");

                    b.Property<string>("friends_in_church")
                        .HasMaxLength(100);

                    b.Property<string>("infant_baptized_church")
                        .HasMaxLength(100);

                    b.Property<DateTime>("infant_baptized_date");

                    b.Property<string>("last_church_leader")
                        .HasMaxLength(100);

                    b.Property<string>("last_church_name")
                        .HasMaxLength(100);

                    b.Property<string>("person_status")
                        .HasMaxLength(100);

                    b.Property<string>("position_type")
                        .HasMaxLength(100);

                    b.Property<string>("vehicle_license")
                        .HasMaxLength(100);

                    b.Property<string>("volunteer_experience")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Churches");
                });

            modelBuilder.Entity("Gccform.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PersonID");

                    b.Property<string>("home_num")
                        .HasMaxLength(100);

                    b.Property<string>("phone_num")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Gccform.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("company_name")
                        .HasMaxLength(100);

                    b.Property<DateTime>("dob");

                    b.Property<string>("email")
                        .HasMaxLength(100);

                    b.Property<string>("job")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Gccform.Models.PersonName", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PersonID");

                    b.Property<string>("e_fname")
                        .HasMaxLength(100);

                    b.Property<string>("e_lname")
                        .HasMaxLength(100);

                    b.Property<string>("k_fname")
                        .HasMaxLength(100);

                    b.Property<string>("k_lname")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("PersonNames");
                });

            modelBuilder.Entity("Gccform.Models.Address", b =>
                {
                    b.HasOne("Gccform.Models.Person", "Person")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gccform.Models.Church", b =>
                {
                    b.HasOne("Gccform.Models.Person", "Person")
                        .WithMany("Churches")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gccform.Models.Contact", b =>
                {
                    b.HasOne("Gccform.Models.Person", "Person")
                        .WithMany("Contacts")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gccform.Models.PersonName", b =>
                {
                    b.HasOne("Gccform.Models.Person", "Person")
                        .WithMany("PersonNames")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
