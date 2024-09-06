using AnimeCDWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeCDWeb.Data
{
    public class ApplicationDbContext : DbContext // Kế thừa từ DbContext Class
    {
        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)     
        {

        }

        public DbSet<Category> Categories { get; set; } // DbSet để thao tác với table Categories trong Database, tự động tạo ra bảng Categories

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
        }
    }
} 
