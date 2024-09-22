using AnimeCD.DataAccess.Data;
using AnimeCD.DataAccess.Repository.IRepository;
using AnimeCD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeCDWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork; // Khởi tạo đối tượng _unitOfWork
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList(); // truy xuất tất cả dữ liệu từ bảng Categories
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
                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Thêm danh mục thành công"; // tao thông báo thêm thành công
                return RedirectToAction("Index"); // chuyển hướng đến action Index
            }
            return View();
        }

        public IActionResult Edit(int? id) // id là Id của Category cần sửa
        {
            if (id == null || id == 0) // kiểm tra xem id có tồn tại không
            {
                return NotFound();
            }
            Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id); // tìm Category có id trong Database, "?" để kiểm tra xem trường có thể null không

            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id); FirstOrDefault trong LinQ expression
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
                _unitOfWork.Category.Update(obj); // cập nhật thông tin danh mục
                _unitOfWork.Save(); // lưu thay đổi
                TempData["success"] = "Chỉnh sửa danh mục thành công"; // tạo thông báo chỉnh sửa thành công
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
            Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id); // tìm Category có id trong Database, "?" để kiểm tra xem trường có thể null không

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
            Category? obj = _unitOfWork.Category.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Category.Remove(obj); // Xóa danh mục
            _unitOfWork.Save(); // Lưu thay đổi
            TempData["success"] = "Xóa danh mục thành công"; // Tạo thông báo xóa thành công
            return RedirectToAction("Index"); // Chuyển hướng đến action Index
        }
    }
}
