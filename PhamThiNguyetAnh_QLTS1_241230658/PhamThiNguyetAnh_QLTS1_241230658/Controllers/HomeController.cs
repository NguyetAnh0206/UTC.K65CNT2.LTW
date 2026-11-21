using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PhamThiNguyetAnh_QLTS1_241230658.Models;
using System.Diagnostics;

namespace PhamThiNguyetAnh_QLTS1_241230658.Controllers
{
    public class HomeController : Controller
    {
        private readonly QLTaiSanContext _context;
        public HomeController(QLTaiSanContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var danhSachTaiSan = _context.TaiSans.Where(ts=>ts.NguyenGia !=  null && ts.NguyenGia >=20).ToList();
            return View(danhSachTaiSan);
        }
        public IActionResult LocTheoLoai(int? maLoai)
        {
            var query = _context.TaiSans.AsQueryable();
            if (maLoai.HasValue)
            {
                query=query.Where(ts=>ts.MaLoai== maLoai.Value);
            }
            else
            {
                query = query.Where(ts => ts.NguyenGia != null && ts.NguyenGia >= 20);
            }
            return PartialView("_DanhSachTaiSanPartial", query.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(_context.LoaiTaiSans.ToList(), "MaLoai", "TenLoai");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TaiSan taisan)
        {
            ModelState.Remove("MaLoaiNavigation");
            if (ModelState.IsValid)
            {
                _context.TaiSans.Add(taisan);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoai = new SelectList(_context.LoaiTaiSans.ToList(), "MaLoai", "TenLoai", taisan.MaLoai);
            return View(taisan);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
