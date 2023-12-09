using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppIntPrueba.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrailerLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageRoute = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId");
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Description", "Duration", "Genre", "ImageRoute", "Rating", "ReleaseDate", "Title", "TrailerLink" },
                values: new object[,]
                {
                    { 1, "Armed with only one word, Tenet, and fighting for the survival of the entire world, a Protagonist journeys through a twilight world of international espionage on a mission that will unfold in something beyond real time.", "2h 30 min", "Action, Sci-Fi", "../../assets/Tenet.png", 7.7999999999999998, new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tenet", "9UfIRXjoO3I?si=-ESo5GlhVtCie2qt" },
                    { 2, "Teen Miles Morales becomes the Spider-Man of his universe, and must join with five spider-powered individuals from other dimensions to stop a threat for all realities.", "1h 57min", "Action, Animation, Adventure", "../../assets/SpiderMan.png", 8.4000000000000004, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man: Into the Spider-Verse", "g4Hbz2jLxvQ?si=svS6wG8qKGc-6_Xg" },
                    { 3, "A detective investigates the death of a patriarch of an eccentric, combative family", "2h 10min", "Comedy, Crime, Drama", "../../assets/KnivesOut.png", 7.9000000000000004, new DateTime(2019, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knives Out", "qGqiHJTsRkQ?si=lzgBSLf83TZELPE7" },
                    { 4, "A group of intergalactic criminals must pull together to stop a fanatical warrior with plans to purge the universe.", "2h 1min", "Action, Adventure, Comedy", "../../assets/GuardiansOfTheGalaxy.png", 8.0, new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guardians of the Galaxy", "d96cjJhvlMA?si=QQCyB3VqDSed3nhu" },
                    { 5, "When Tony Stark and Bruce Banner try to jump-start a dormant peacekeeping program called Ultron, things go horribly wrong and it's up to Earth's mightiest heroes to stop the villainous Ultron from enacting his terrible plan.", "2h 21min", "Action, Adventure, Sci-Fi", "../../assets/Avengers.png", 7.2999999999999998, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers: Age of Ultron", "-f5PwE_Q8Fs?si=JJ1NkKNgq5xuYTN2" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "CommentDate", "Content", "MovieId" },
                values: new object[,]
                {
                    { 1, new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good movie", 1 },
                    { 3, new DateTime(2013, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I like it", 3 },
                    { 4, new DateTime(2013, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cool seeing them all together again, even if I didn't massively enjoy it. It's good, nothing more or less in my opinion", 5 },
                    { 5, new DateTime(2014, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert Downey Jr. felt a little flat to me as Iron Man - he still has a decent amount of moments, just not as many as you get in his individual films", 5 },
                    { 6, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cheerful blockbuster in which Star Wars meets Ziggy Stardust", 4 },
                    { 7, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guardians bounces with the energy of pure invention.", 4 },
                    { 21, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boring movie", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MovieId",
                table: "Comments",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
