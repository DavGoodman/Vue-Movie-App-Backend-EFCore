using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreMoviesForVue.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Animation" },
                    { 3, "Comedy" },
                    { 4, "ScienceFiction" },
                    { 5, "Drama" },
                    { 6, "Adventure" },
                    { 7, "Super Hero" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "ImgUrl", "Synopsis", "Title" },
                values: new object[,]
                {
                    { 1, "https://m.media-amazon.com/images/M/MV5BZDEyN2NhMjgtMjdhNi00MmNlLWE5YTgtZGE4MzNjMTRlMGEwXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_FMjpg_UX1000_.jpg", "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "Spider-Man 2002" },
                    { 2, "https://m.media-amazon.com/images/M/MV5BYmVhNmFmOGYtZjgwNi00ZGQ0LThiMmQtOGZjMDUzNzJhMGIzXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg", "A goofy detective specializing in animals goes in search of the missing mascot of the Miami Dolphins.", "Ace Ventura: Pet Detective 1994" },
                    { 3, "https://static.wikia.nocookie.net/listofdeaths/images/b/b5/A_New_Hope_poster.jpg/revision/latest/scale-to-width-down/1200?cb=20211105092556", "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.", "Star Wars: Episode IV - A New Hope 1977" },
                    { 4, "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UX1000_.jpg", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "The Dark Knight 2008" },
                    { 5, "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg", "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", "The Matrix 1999" }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 3, 2 },
                    { 4, 3 },
                    { 4, 5 },
                    { 5, 4 },
                    { 6, 3 },
                    { 7, 1 },
                    { 7, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
