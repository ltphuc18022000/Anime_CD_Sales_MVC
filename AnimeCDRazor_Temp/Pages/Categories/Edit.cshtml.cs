using AnimeCDRazor_Temp.Data;
using AnimeCDRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnimeCDRazor_Temp.Pages.Categories
{
	[BindProperties]
	public class EditModel : PageModel
	{
		private readonly ApplicationDbContext _db;
		// gõ prop + tab để tạo property
		public Category Category { get; set; }

		// gõ ctor + tab để tạo constructor
		public EditModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(int? id)
		{
			if (id != null && id != 0)
			{
				Category = _db.Categories.Find(id);
			}
		}

		public IActionResult OnPost() // hàm xử lý khi form gửi dữ liệu lên server
		{
			if (ModelState.IsValid) // kiểm tra xem dữ liệu nhập vào có hợp lệ không
			{
				_db.Categories.Update(Category);
				_db.SaveChanges();
				TempData["success"] = "Category updated successfully"; // thông báo khi cập nhật thành công
				return RedirectToPage("Index"); // chuyển hướng đến action Index
			}
			return Page();
		}
	}
}
