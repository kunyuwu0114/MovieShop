﻿// <auto-generated />
using System;
using Infrasturcture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrasturcture.Migrations
{
    [DbContext(typeof(MovieShopDbContext))]
    [Migration("20220516162919_CreatingUserTable")]
    partial class CreatingUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApplicationCore.Entities.Cast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<int?>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("int");

                    b.Property<int?>("ProfilePath")
                        .HasMaxLength(2048)
                        .HasColumnType("int");

                    b.Property<int?>("TmdbUrl")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cast");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Crew", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProfilePath")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("TmdbUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Crew");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Genre", (string)null);
                });

            modelBuilder.Entity("ApplicationCore.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BackdropUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<decimal?>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImdbUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("OriginalLanguage")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Overview")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("PosterUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Revenue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RunTime")
                        .HasColumnType("int");

                    b.Property<string>("Tagline")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Title")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TmdbUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("ApplicationCore.Entities.MovieCast", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("CastId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MovieId", "CastId", "Character");

                    b.HasIndex("CastId");

                    b.ToTable("MovieCast", (string)null);
                });

            modelBuilder.Entity("ApplicationCore.Entities.MovieCrew", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("CrewId")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Job")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("MovieId", "CrewId", "Department", "Job");

                    b.HasIndex("CrewId");

                    b.ToTable("MovieCrew", (string)null);
                });

            modelBuilder.Entity("ApplicationCore.Entities.MovieGenre", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenre", (string)null);
                });

            modelBuilder.Entity("ApplicationCore.Entities.Trailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("TrailerUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Trailer");
                });

            modelBuilder.Entity("ApplicationCore.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("HashedPassword")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool?>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginDateTime")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LockoutEndDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<string>("LsstName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Salt")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool?>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ApplicationCore.Entities.MovieCast", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Cast", "Cast")
                        .WithMany("MoviesOfCast")
                        .HasForeignKey("CastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Movie", "Movie")
                        .WithMany("MoviesOfCast")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cast");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ApplicationCore.Entities.MovieCrew", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Crew", "Crew")
                        .WithMany("MoviesOfCrew")
                        .HasForeignKey("CrewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Movie", "Movie")
                        .WithMany("MoviesOfCrew")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Crew");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ApplicationCore.Entities.MovieGenre", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Genre", "Genre")
                        .WithMany("GenresOfMovie")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Movie", "Movie")
                        .WithMany("MoviesOfGenre")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Trailer", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Movie", "Movie")
                        .WithMany("Trailers")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Cast", b =>
                {
                    b.Navigation("MoviesOfCast");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Crew", b =>
                {
                    b.Navigation("MoviesOfCrew");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Genre", b =>
                {
                    b.Navigation("GenresOfMovie");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Movie", b =>
                {
                    b.Navigation("MoviesOfCast");

                    b.Navigation("MoviesOfCrew");

                    b.Navigation("MoviesOfGenre");

                    b.Navigation("Trailers");
                });
#pragma warning restore 612, 618
        }
    }
}
