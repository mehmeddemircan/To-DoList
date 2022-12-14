// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using To_DoList.DataAccess.Concrete.Contexts;

#nullable disable

namespace To_DoList.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220912152649_add-color")]
    partial class addcolor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("To_DoList.Entities.Concrete.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ColorHexaDecimal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ColorText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("To_DoList.Entities.Concrete.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ColorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("MissionId")
                        .HasColumnType("integer");

                    b.Property<int?>("ThemeId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("To_DoList.Entities.Concrete.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsStarred")
                        .HasColumnType("boolean");

                    b.Property<string>("NoteText")
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("To_DoList.Entities.Concrete.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ThemeImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });
#pragma warning restore 612, 618
        }
    }
}
