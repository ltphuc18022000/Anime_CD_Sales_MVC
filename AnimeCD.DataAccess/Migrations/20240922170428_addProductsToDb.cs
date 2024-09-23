using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeCD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ListPrice", "Price", "Price100", "Price50", "Serial", "Title" },
                values: new object[,]
                {
                    { 1, "Ochikoshi Tomonori", "Câu chuyện về một cô thiếu nữ tên Lucy Heartfilia, khao khát của cô là gia nhập Hội Pháp sư nổi tiếng Fairy Tail. Trên đường phiêu lưu, Lucy đã vô tình gặp gỡ Natsu Salamander Dragneel, một thành viên của Fairy Tail, người sở hữu pháp thuật cổ đại Sát Long. Thế rồi Lucy được Natsu giới thiệu vào Hội Pháp sư Fairy Tail và cùng anh chàng này tham gia vô số nhiệm vụ khó khăn nhưng cũng không kém phần thú vị. ", 99.0, 90.0, 80.0, 85.0, "SWD9999001", "Fairy Tail" },
                    { 2, "Uda Kounosuke", "Monkey D. Luffy, 1 cậu bé rất thích Đảo hải tặc có ước mơ tìm được kho báu One Piece và trở thành Vua hải tặc - Pirate King. Lúc nhỏ, Luffy tình cờ ăn phải trái quỉ (Devil Fruit) Gomu Gomu, nó cho cơ thể cậu khả năng co dãn đàn hồi như cao su nhưng đổi lại cậu sẽ không bao giờ biết bơi. Hãy cùng theo dõi xem liệu Luffy có thể trở thành đạt được kho báu One Piece và trở thành Vua Hải Tặc không nhé.", 40.0, 30.0, 20.0, 25.0, "CAW777777701", "One Piece" },
                    { 3, "Julian Button", "Fable là một tay sát thủ lão luyện giỏi nhất trong lĩnh vực của mình. Tuy nhiên, anh ta đã giết rất nhiều người đến nỗi ông chủ của anh ta yêu cầu anh ta phải nằm im trong một thời gian. ", 55.0, 50.0, 35.0, 40.0, "RITO5555501", "The Fable" },
                    { 4, "Abby Muscles", "Kỷ nguyên của các cuộc đại chiến nảy lửa giữa 5 chủng tộc để giành quyền bá chủ mặt đất đã kết thúc với phần thắng thuộc về nhân loại do Anh Hùng Sid lãnh đạo. Tuy nhiên, thế giới đó bất ngờ bị ”thay đổi” trước sự chứng kiến của chàng trai tên Kai. Trong thế giới đó, Kai đã thấy Anh Hùng Sid không còn tồn tại, dẫn đến sự thất bại của con người trong trận đại chiến giữa 5 chủng tộc.", 70.0, 65.0, 55.0, 60.0, "WS3333333301", "Naze Boku no Sekai wo Daremo Oboeteinai no ka?" },
                    { 5, "Ron Parker", "The New Gate là một game online thu hút hàng nghìn người chơi tham gia. Khi trò game trở thành một nơi chết chóc, nhờ vào Shin, một trong người chơi mạnh nhất đá đánh bại chùm cuối và giải thoát mọi người. Nhưng sau khi chiến thắng, Shin bị một tia sáng chiếu vào và kéo anh ta tới thế giới game đó 500 năm sau và bị mắc kẹt luôn trong đó. ", 30.0, 27.0, 20.0, 25.0, "SOTJ1111111101", "The New Gate" },
                    { 6, "Laura Phantom", "Phim dựa trên 6 câu chuyện: Lọ Lem, Cô Bé Quàng Khăn Đỏ, Hansel và Gretel, Người Thợ Giày và Lũ Yêu Tinh, Những Nhạc Sĩ Thành Bremen, Người Thổi Sáo Thành Hamelin.", 25.0, 23.0, 20.0, 22.0, "FOT000000001", "Grimm Kumikyoku" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
