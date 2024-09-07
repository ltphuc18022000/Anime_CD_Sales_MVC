using AnimeCDRazor_Temp.Data;
using AnimeCDRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnimeCDRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        // gõ prop + tab để tạo property
        public List<Category> CategoryList { get; set; }

        // gõ ctor + tab để tạo constructor
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList(); // sử dụng Entity Framework Core để truy xuất dữ liệu từ bảng Categories
        }
    }
}
