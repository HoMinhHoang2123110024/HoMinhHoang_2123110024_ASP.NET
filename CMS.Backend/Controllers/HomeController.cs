using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS.Data; // Thư mục chứa DbContext
using System.Linq;

namespace CMS.Backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // LINQ: Giữ nguyên 100% code của thầy, không thay đổi một chữ
            var latestPosts = _context.Posts
                                .Include(p => p.Category) // Lấy kèm tên danh mục để hiển thị 
                                .OrderByDescending(p => p.CreatedDate) // Sắp xếp ngày mới nhất lên đầu 
                                .Take(3) // Chỉ lấy đúng 3 bản tin đầu tiên
                                .ToList();

            return View(latestPosts);
        }
    }
}