using AnimeCD.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeCD.DataAccess.Data
{
    public class ApplicationDbContext : DbContext // Kế thừa từ DbContext Class
    {
        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)     
        {

        }

        public DbSet<Category> Categories { get; set; } // DbSet để thao tác với table Categories trong Database, tự động tạo ra bảng Categories

		public DbSet<Product> Products { get; set; } 

		protected override void OnModelCreating(ModelBuilder modelBuilder) // Ghi đè phương thức OnModelCreating
        {
            // Thêm dữ liệu mẫu cho table Categories, sử dụng phương thức HasData
            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                    new Category { Id = 2, Name = "Adventure", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "Comedy", DisplayOrder = 3 },
                    new Category { Id = 4, Name = "Drama", DisplayOrder = 4 },
                    new Category { Id = 5, Name = "Fantasy", DisplayOrder = 5 },
                    new Category { Id = 6, Name = "Horror", DisplayOrder = 6 },
                    new Category { Id = 7, Name = "Mystery", DisplayOrder = 7 },
                    new Category { Id = 8, Name = "Psychological", DisplayOrder = 8 },
                    new Category { Id = 9, Name = "Romance", DisplayOrder = 9 },
                    new Category { Id = 10, Name = "Sci-fi", DisplayOrder = 10 },
                    new Category { Id = 11, Name = "Slice of Life", DisplayOrder = 11 },
                    new Category { Id = 12, Name = "Supernatural", DisplayOrder = 12 },
                    new Category { Id = 13, Name = "Thriller", DisplayOrder = 13 },
                    new Category { Id = 14, Name = "Mecha", DisplayOrder = 14 },
                    new Category { Id = 15, Name = "Sports", DisplayOrder = 15 },
                    new Category { Id = 16, Name = "Music", DisplayOrder = 16 },
                    new Category { Id = 17, Name = "School", DisplayOrder = 17 },
                    new Category { Id = 18, Name = "Shounen", DisplayOrder = 18 },
                    new Category { Id = 19, Name = "Shoujo", DisplayOrder = 19 },
                    new Category { Id = 22, Name = "Harem", DisplayOrder = 20 }
            );
            modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "Fairy Tail",
					Author = "Ochikoshi Tomonori",
					Description = "Câu chuyện về một cô thiếu nữ tên Lucy Heartfilia, khao khát của cô là gia nhập Hội Pháp sư nổi tiếng Fairy Tail. " +
						"Trên đường phiêu lưu, Lucy đã vô tình gặp gỡ Natsu Salamander Dragneel, một thành viên của Fairy Tail, người sở hữu pháp thuật cổ đại Sát Long. " +
						"Thế rồi Lucy được Natsu giới thiệu vào Hội Pháp sư Fairy Tail và cùng anh chàng này tham gia vô số nhiệm vụ khó khăn nhưng cũng không kém phần thú vị. ",
					Serial = "SWD9999001",
					ListPrice = 99,
					Price = 90,
					Price50 = 85,
					Price100 = 80,
                    CategoryID = 1,
                    ImageUrl = "fairytail.jpg"
                },
				new Product
				{
					Id = 2,
					Title = "One Piece",
					Author = "Uda Kounosuke",
					Description = "Monkey D. Luffy, 1 cậu bé rất thích Đảo hải tặc có ước mơ tìm được kho báu One Piece và trở thành Vua hải tặc - Pirate King. " +
					"Lúc nhỏ, Luffy tình cờ ăn phải trái quỉ (Devil Fruit) Gomu Gomu, nó cho cơ thể cậu khả năng co dãn đàn hồi như cao su nhưng đổi lại cậu sẽ không bao giờ biết bơi. " +
					"Hãy cùng theo dõi xem liệu Luffy có thể trở thành đạt được kho báu One Piece và trở thành Vua Hải Tặc không nhé.",
					Serial = "CAW777777701",
					ListPrice = 40,
					Price = 30,
					Price50 = 25,
					Price100 = 20,
                    CategoryID = 2,
                    ImageUrl = "onepiece.jpg"
                },
				new Product
				{
					Id = 3,
					Title = "The Fable",
					Author = "Julian Button",
					Description = "Fable là một tay sát thủ lão luyện giỏi nhất trong lĩnh vực của mình. " +
					"Tuy nhiên, anh ta đã giết rất nhiều người đến nỗi ông chủ của anh ta yêu cầu anh ta phải nằm im trong một thời gian. ",
					Serial = "RITO5555501",
					ListPrice = 55,
					Price = 50,
					Price50 = 40,
					Price100 = 35,
                    CategoryID = 3,
                    ImageUrl = "thefable.jpg"
                },
				new Product
				{
					Id = 4,
					Title = "Naze Boku no Sekai wo Daremo Oboeteinai no ka?",
					Author = "Abby Muscles",
					Description = "Kỷ nguyên của các cuộc đại chiến nảy lửa giữa 5 chủng tộc để giành quyền bá chủ mặt đất đã kết thúc với phần thắng thuộc về nhân loại do Anh Hùng Sid lãnh đạo. " +
					"Tuy nhiên, thế giới đó bất ngờ bị ”thay đổi” trước sự chứng kiến của chàng trai tên Kai. " +
					"Trong thế giới đó, Kai đã thấy Anh Hùng Sid không còn tồn tại, dẫn đến sự thất bại của con người trong trận đại chiến giữa 5 chủng tộc.",
					Serial = "WS3333333301",
					ListPrice = 70,
					Price = 65,
					Price50 = 60,
					Price100 = 55,
                    CategoryID = 4,
                    ImageUrl = "naze.jpg"
                },
				new Product
				{
					Id = 5,
					Title = "The New Gate",
					Author = "Ron Parker",
					Description = "The New Gate là một game online thu hút hàng nghìn người chơi tham gia. " +
					"Khi trò game trở thành một nơi chết chóc, nhờ vào Shin, một trong người chơi mạnh nhất đá đánh bại chùm cuối và giải thoát mọi người. " +
					"Nhưng sau khi chiến thắng, Shin bị một tia sáng chiếu vào và kéo anh ta tới thế giới game đó 500 năm sau và bị mắc kẹt luôn trong đó. ",
					Serial = "SOTJ1111111101",
					ListPrice = 30,
					Price = 27,
					Price50 = 25,
					Price100 = 20,
                    CategoryID = 5,
                    ImageUrl = "thenewgate.jpg"
                },
				new Product
				{
					Id = 6,
					Title = "Grimm Kumikyoku",
					Author = "Laura Phantom",
					Description = "Phim dựa trên 6 câu chuyện: Lọ Lem, Cô Bé Quàng Khăn Đỏ, Hansel và Gretel, Người Thợ Giày và Lũ Yêu Tinh, Những Nhạc Sĩ Thành Bremen, Người Thổi Sáo Thành Hamelin.",
					Serial = "FOT000000001",
					ListPrice = 25,
					Price = 23,
					Price50 = 22,
					Price100 = 20,
                    CategoryID = 6,
                    ImageUrl = "grimkumikyoku.jpg"
                }
			);

		}
    }
} 
