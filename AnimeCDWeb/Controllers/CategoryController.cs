using AnimeCDWeb.Data;
using AnimeCDWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeCDWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList); // chuyển du lieu obj tu Controller sang View
        }
        public IActionResult Create()
        {
            return View();
        }

        // Thêm danh mục mới vào Database 
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Tên không thể giống với Thứ tự hiển thị");
            }

            if (ModelState.IsValid) // kiểm tra xem dữ liệu nhập vào có hợp lệ không
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index"); // chuyển hướng đến action Index
            }
            return View();
        }
         
		public IActionResult Edit(int? id) // id là Id của Category cần sửa
		{
			if (id==null || id==0) // kiểm tra xem id có tồn tại không
			{
				return NotFound();
			}
			Category? categoryFromDb = _db.Categories.Find(id); // tìm Category có id trong Database, "?" để kiểm tra xem trường có thể null không
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id == id).FirstOrDefault();
			if (categoryFromDb == null)
            {
                return NotFound();
            }
			return View(categoryFromDb);
		}
		
		// Chỉnh sửa danh mục
		[HttpPost]
		public IActionResult Edit(Category obj)
		{
			//if (obj.Name == obj.DisplayOrder.ToString())
			//{
			//	ModelState.AddModelError("name", "Tên không thể giống với Thứ tự hiển thị");
			//}

			if (ModelState.IsValid) // kiểm tra xem dữ liệu nhập vào có hợp lệ không
			{
				_db.Categories.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index"); // chuyển hướng đến action Index
			}
			return View();
		}

		public IActionResult Delete(int? id) 
		{
			if (id == null || id == 0) // kiểm tra xem id có tồn tại không
			{
				return NotFound();
			}
			Category? categoryFromDb = _db.Categories.Find(id); // tìm Category có id trong Database, "?" để kiểm tra xem trường có thể null không

			if (categoryFromDb == null)
			{
				return NotFound();
			}
			return View(categoryFromDb);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeletePost(int? id) // ? để kiểm tra xem id có thể null không
		{
			// Tìm danh mục cần xóa từ Database
			Category? obj = _db.Categories.Find(id);
			if (obj == null)
			{
				return NotFound();
			}
			_db.Categories.Remove(obj); // Xóa danh mục
			_db.SaveChanges(); // Lưu thay đổi 
			return RedirectToAction("Index"); // Chuyển hướng đến action Index
		}
	}
}
 