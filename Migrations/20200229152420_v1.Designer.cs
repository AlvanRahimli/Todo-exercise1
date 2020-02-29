﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ex1_ToDo.Data;

namespace ToDo_exercise1.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20200229152420_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ex1_ToDo.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<int>("Order");

                    b.Property<int>("TodoId");

                    b.Property<bool>("isDone");

                    b.HasKey("Id");

                    b.HasIndex("TodoId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ex1_ToDo.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorEmail")
                        .IsRequired();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Priority");

                    b.HasKey("Id");

                    b.HasIndex("AuthorEmail");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("ex1_ToDo.Models.User", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Id");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUsername");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Email");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ex1_ToDo.Models.Item", b =>
                {
                    b.HasOne("ex1_ToDo.Models.Todo", "Todo")
                        .WithMany("Items")
                        .HasForeignKey("TodoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ex1_ToDo.Models.Todo", b =>
                {
                    b.HasOne("ex1_ToDo.Models.User", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorEmail")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}