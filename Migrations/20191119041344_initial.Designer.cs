﻿// <auto-generated />
using System;
using CopAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CopAPI.Migrations
{
    [DbContext(typeof(movieContext))]
    [Migration("20191119041344_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CopAPI.Models.movie", b =>
                {
                    b.Property<int>("mov_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("mov_dt_rel")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("mov_lang")
                        .HasColumnType("text");

                    b.Property<string>("mov_rel_country")
                        .HasColumnType("text");

                    b.Property<int>("mov_time")
                        .HasColumnType("integer");

                    b.Property<string>("mov_title")
                        .HasColumnType("text");

                    b.Property<int>("mov_year")
                        .HasColumnType("integer");

                    b.HasKey("mov_id");

                    b.ToTable("movies");
                });
#pragma warning restore 612, 618
        }
    }
}
