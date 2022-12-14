// <auto-generated />
using System;
using AppIntPrueba.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppIntPrueba.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221030131255_inicio")]
    partial class inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppIntPrueba.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"), 1L, 1);

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            ArtistName = "Metallica"
                        },
                        new
                        {
                            ArtistId = 2,
                            ArtistName = "Foo Fighters"
                        });
                });

            modelBuilder.Entity("AppIntPrueba.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("SongId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("AppIntPrueba.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"), 1L, 1);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongDislikes")
                        .HasColumnType("int");

                    b.Property<string>("SongImageRoute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SongLikes")
                        .HasColumnType("int");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SongRegistryDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SongId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            ArtistId = 1,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "Nothing Else Matters",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SongId = 2,
                            ArtistId = 1,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "Master of Pupets",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SongId = 3,
                            ArtistId = 1,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "The Unforgiven",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SongId = 4,
                            ArtistId = 1,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "One",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SongId = 5,
                            ArtistId = 1,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "For Whom the Bell Tolls",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SongId = 6,
                            ArtistId = 1,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "Whiskey in the Jar",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SongId = 7,
                            ArtistId = 1,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "Sad but True",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SongId = 8,
                            ArtistId = 1,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "Everlong",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SongId = 9,
                            ArtistId = 2,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "The Pretender",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SongId = 10,
                            ArtistId = 2,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "Best of You",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SongId = 11,
                            ArtistId = 2,
                            SongDislikes = 0,
                            SongImageRoute = "./assets",
                            SongLikes = 1,
                            SongName = "My Hero",
                            SongRegistryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AppIntPrueba.Models.Comment", b =>
                {
                    b.HasOne("AppIntPrueba.Models.Song", "Song")
                        .WithMany("Comments")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Song");
                });

            modelBuilder.Entity("AppIntPrueba.Models.Song", b =>
                {
                    b.HasOne("AppIntPrueba.Models.Artist", "Artist")
                        .WithMany("Songs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("AppIntPrueba.Models.Artist", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("AppIntPrueba.Models.Song", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
