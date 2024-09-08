using AnimeCDRazor_Temp.Data;
using AnimeCDRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnimeCDRazor_Temp.Pages.Categories
{
	[BindProperties] // tạo liên kết thuộc tính với form input field trong Razor Page View 
	public class CreateModel : PageModel
	{
		private readonly ApplicationDbContext _db;
		// gõ prop + tab để tạo property
		public Category Category { get; set; }

		// gõ ctor + tab để tạo constructor
		public CreateModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet()
		{
		}

		public IActionResult OnPost() // hàm xử lý khi form gửi dữ liệu lên server
		{
			_db.Categories.Add(Category); // thêm Category object vào bảng Categories
			_db.SaveChanges();
			TempData["success"] = "Category created successfully"; // thông báo khi thêm thành công
			return RedirectToPage("Index");
		}
	}
}
