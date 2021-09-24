﻿// <auto-generated />
using System;
using API_Answer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_Answer.Migrations
{
    [DbContext(typeof(AnswerDbContext))]
    partial class AnswerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiService.Models.AnswerManagement", b =>
                {
                    b.Property<int?>("ans_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ans_cont")
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("img_url")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("isActive")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<int>("qst_id")
                        .HasColumnType("int");

                    b.Property<string>("rating")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ref_url")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("ans_id");

                    b.ToTable("AnswerManagement");
                });
#pragma warning restore 612, 618
        }
    }
}
