using CMS.Data;
using CMS.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CMS.Backend.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. TRANG DANH SÁCH (INDEX)
        public IActionResult Index()
        {
            var data = _context.Categories.ToList();
            return View(data);
        }

        // 2. THÊM MỚI (CREATE) - GET: Hiển thị form
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // THÊM MỚI (CREATE) - POST: Xử lý lưu dữ liệu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category model)
        {
            ModelState.Remove("Posts");

            if (ModelState.IsValid)
            {
                _context.Categories.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model); // Nếu dữ liệu lỗi, trả lại form kèm dữ liệu đã nhập
        }

        // 3. SỬA (EDIT) - GET: Lấy dữ liệu cũ và hiển thị lên form
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Tìm danh mục theo ID trong cơ sở dữ liệu
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound(); // Trả về trang 404 nếu không tìm thấy
            }

            return View(category);
        }

        // SỬA (EDIT) - POST: Xử lý cập nhật dữ liệu thay đổi vào SQL
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category model)
        {
            ModelState.Remove("Posts");
            if (ModelState.IsValid)
            {
                // Cập nhật trạng thái của model thành Modified (Đã chỉnh sửa)
                _context.Categories.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        // 4. XÓA (DELETE) - GET: Hiển thị trang xác nhận xóa
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // XÓA (DELETE) - POST: Xác nhận xóa thật sự khỏi SQL
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}