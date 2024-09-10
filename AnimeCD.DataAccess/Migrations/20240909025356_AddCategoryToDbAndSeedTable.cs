using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeCD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryToDbAndSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "Adventure" },
                    { 3, 3, "Comedy" },
                    { 4, 4, "Drama" },
                    { 5, 5, "Fantasy" },
                    { 6, 6, "Horror" },
                    { 7, 7, "Mystery" },
                    { 8, 8, "Psychological" },
                    { 9, 9, "Romance" },
                    { 10, 10, "Sci-fi" },
                    { 11, 11, "Slice of Life" },
                    { 12, 12, "Supernatural" },
                    { 13, 13, "Thriller" },
                    { 14, 14, "Mecha" },
                    { 15, 15, "Sports" },
                    { 16, 16, "Music" },
                    { 17, 17, "School" },
                    { 18, 18, "Shounen" },
                    { 19, 19, "Shoujo" },
                    { 22, 20, "Harem" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
