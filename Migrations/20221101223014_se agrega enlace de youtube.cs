using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppIntPrueba.Migrations
{
    public partial class seagregaenlacedeyoutube : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SongYoutubeRoute",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/nothing else matters.jpg", "../../assets/tAGnKpE4NCI" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/master of puppets.jpg", "../../assets/6xjJ2XIbGRk" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/the unforgiven.jpg", "../../assets/DDGhKS6bSAE" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/one.jpg", "../../assets/WM8bTdBs-cw" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/for whom the bells tolls.jpg", "../../assets/B_HSa1dEL9s" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/whiskey in the jar.jpg", "../../assets/boanuwUMNNQ" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/sadButTrue.jpg", "../../assets/A8MO7fkZc5o" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/Everlong.jpg", "../../assets/eBG7P-K-r1Y" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/the pretender.jpg", "../../assets/SBjQ9tuuTJQ" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 10,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/bestOfYou.jpg", "../../assets/h_L4Rixya64" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 11,
                columns: new[] { "SongImageRoute", "SongYoutubeRoute" },
                values: new object[] { "../../assets/my hero.png", "../../assets/EqWRaAF6_WY" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SongYoutubeRoute",
                table: "Songs");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1,
                column: "SongImageRoute",
                value: "./assets");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2,
                column: "SongImageRoute",
                value: "./assets");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3,
                column: "SongImageRoute",
                value: "./assets");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4,
                column: "SongImageRoute",
                value: "./assets");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5,
                column: "SongImageRoute",
                value: "./assets");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6,
                column: "SongImageRoute",
                value: "./assets");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7,
                column: "SongImageRoute",
                value: "./assets");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8,
                column: "SongImageRoute",
                value: "./assets");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9,
                column: "SongImageRoute",
                value: "./assets");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 10,
                column: "SongImageRoute",
                value: "./assets");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 11,
                column: "SongImageRoute",
                value: "./assets");
        }
    }
}
