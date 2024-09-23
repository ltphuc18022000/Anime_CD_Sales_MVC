using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimeCD.Models
{
    public class Product
    {
		[Key]
		public int Id { get; set; } //Khoá chính của table (thuộc tính số nguyên)
		[Required]
		public string Title { get; set; }
		public string Description { get; set; }
		[Required]
		public string Serial { get; set; }
		[Required]
		public string Author { get; set; }

  
        [Required]
		[Display(Name ="Danh sách giá")]
		[Range(50000, 100000)]
		public double ListPrice { get; set; }

		[Required]
		[Display(Name = "Giá cho từ 1-50")]
		[Range(50000, 100000)]
		public double Price { get; set; }

		[Required]
		[Display(Name = "Giá cho lượt mua 50+")]
		[Range(50000, 100000)]
		public double Price50 { get; set; }

		[Required]
		[Display(Name = "Giá cho lượt mua 100+")]
		[Range(50000, 100000)]
		public double Price100 { get; set; }

        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")] // Khóa ngoại
        public Category Category { get; set; }

		public string ImageUrl { get; set; }
    }
}
