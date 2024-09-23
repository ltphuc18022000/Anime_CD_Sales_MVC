using AnimeCD.DataAccess.Data;
using AnimeCD.DataAccess.Repository.IRepository;
using AnimeCD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AnimeCDWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork; // Khởi tạo đối tượng _unitOfWork
        }
        public IActionResult Index()
        {
            List<Product> objProductList = _unitOfWork.Product.GetAll().ToList(); // truy xuất tất cả dữ liệu từ bảng Categories
            // phép chiếu trong EF Core là cách chúng ta chọn một số cột cụ thể từ một bảng hoặc nhiều bảng và trả về dữ liệu dưới dạng một đối tượng mới hoặc một danh sách các đối tượng mới.
            IEnumerable<SelectListItem> CategoryList = _unitOfWork.Category
                .GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString()
            }); // Lấy tất cả danh mục từ bảng Categories, chuyển thành SelectListItem
            return View(objProductList); // chuyển du lieu obj tu Controller sang View
        }
        public IActionResult Create()
        {
            return View();
        }

        // Thêm danh mục mới vào Database 
        [HttpPost]
        public IActionResult Create(Product obj)
        {

            if (ModelState.IsValid) // kiểm tra xem dữ liệu nhập vào có hợp lệ không
            {
                _unitOfWork.Product.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Thêm danh mục thành công"; // tao thông báo thêm thành công
                return RedirectToAction("Index"); // chuyển hướng đến action Index
            }
            return View();
        }

        public IActionResult Edit(int? id) // id là Id của Product cần sửa
        {
            if (id == null || id == 0) // kiểm tra xem id có tồn tại không
            {
                return NotFound();
            }
            Product? productFromDb = _unitOfWork.Product.Get(u => u.Id == id); // tìm Product có id trong Database, "?" để kiểm tra xem trường có thể null không

            //Product? productFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id); FirstOrDefault trong LinQ expression
            //Product? productFromDb2 = _db.Categories.Where(u=>u.Id == id).FirstOrDefault();
            if (productFromDb == null)
            {
                return NotFound();
            }
            return View(productFromDb);
        }

        // Chỉnh sửa danh mục
        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            //if (obj.Name == obj.DisplayOrder.ToString())
            //{
            //	ModelState.AddModelError("name", "Tên không thể giống với Thứ tự hiển thị");
            //}

            if (ModelState.IsValid) // kiểm tra xem dữ liệu nhập vào có hợp lệ không
            {
                _unitOfWork.Product.Update(obj); // cập nhật thông tin danh mục
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
            Product? productFromDb = _unitOfWork.Product.Get(u => u.Id == id); // tìm Product có id trong Database, "?" để kiểm tra xem trường có thể null không

            if (productFromDb == null)
            {
                return NotFound();
            }
            return View(productFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id) // ? để kiểm tra xem id có thể null không
        {
            // Tìm danh mục cần xóa từ Database
            Product? obj = _unitOfWork.Product.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Product.Remove(obj); // Xóa danh mục
            _unitOfWork.Save(); // Lưu thay đổi
            TempData["success"] = "Xóa danh mục thành công"; // Tạo thông báo xóa thành công
            return RedirectToAction("Index"); // Chuyển hướng đến action Index
        }
    }
}
