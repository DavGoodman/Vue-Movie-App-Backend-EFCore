using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMoviesForVue.Migrations
{
    /// <inheritdoc />
    public partial class seed_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUrl",
                value: "https://cdn2.penguin.com.au/covers/original/9781473544888.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUrl",
                value: "https://static.wikia.nocookie.net/listofdeaths/images/b/b5/A_New_Hope_poster.jpg/revision/latest/scale-to-width-down/1200?cb=20211105092556");
        }
    }
}
