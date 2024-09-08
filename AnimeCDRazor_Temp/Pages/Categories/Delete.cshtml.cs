using AnimeCDRazor_Temp.Data;
using AnimeCDRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnimeCDRazor_Temp.Pages.Categories
{
	[BindProperties]
	public class DeleteModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		// gõ prop + tab để tạo property
		public Category Category { get; set; }

		// gõ ctor + tab để tạo constructor
		public DeleteModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(int? id)
		{
			{
				if (id != null && id != 0)
				{
					Category = _db.Categories.Find(id);
				}
			}
		}
		public IActionResult OnPost() // hàm xử lý khi form gửi dữ liệu lên server
		{
			Category? obj = _db.Categories.Find(Category.Id); // get id from Category vì BindProperties nên có thể lấy trực tiếp từ Category 
			if (obj == null)
			{
				return NotFound();
			}
			_db.Categories.Remove(obj); // Xóa danh mục
			_db.SaveChanges(); // Lưu thay đổi 
			TempData["success"] = "Category deleted successfully"; // thông báo khi xóa thành công
			return RedirectToPage("Index"); // chuyển hướng đến action Index 
		}
	}
}
