using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AnimeCD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } //Khoá chính của table (thuộc tính số nguyên)
        [Required]

        [MaxLength(35)] //Độ dài tối đa của thuộc tính Name
        [DisplayName("Tên Thể Loại Anime")] //Tên hiển thị cho thuộc tính Name
        public string Name { get; set; }

        [DisplayName("Thứ tự hiển thị")]
        [Range(1,100, ErrorMessage = "Thứ tự hiển thị phải nằm trong khoảng từ 1 - 100")] //Giá trị của thuộc tính DisplayOrder phải nằm trong khoảng từ 1 đến 100
        public int DisplayOrder { get; set; } //Thứ tự hiển thị
    } 
}
