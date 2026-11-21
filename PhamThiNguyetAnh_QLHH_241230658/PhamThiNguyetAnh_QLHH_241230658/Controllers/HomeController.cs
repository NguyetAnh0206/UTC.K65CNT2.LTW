using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PhamThiNguyetAnh_QLHH_241230658.Models;
using System.Diagnostics;

namespace PhamThiNguyetAnh_QLHH_241230658.Controllers
{
    public class HomeController : Controller
    {
        public readonly QLHangHoaContext _context;
        public HomeController(QLHangHoaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var dsHangHoa= _context.HangHoas.Where(hh=> hh.Gia != null && hh.Gia>=100).ToList();
            return View(dsHangHoa);
        }
        public IActionResult LocTheoLoai(int? maLoai)
        {
            var query = _context.HangHoas.AsQueryable();
            if (maLoai.HasValue)
            {
                query=query.Where(hh=> hh.MaLoai == maLoai.Value);
            }
            else
            {
                query = query.Where(hh => hh.Gia != null && hh.Gia >= 100);
            }
            return PartialView("_DanhSachHangHoaPartial", query.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(_context.LoaiHangs.ToList(), "MaLoai", "TenLoai");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HangHoa hangHoa)
        {
            ModelState.Remove("MaLoaiNavigation");
            if (ModelState.IsValid)
            {
                _context.HangHoas.Add(hangHoa);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoai = new SelectList(_context.LoaiHangs.ToList(), "MaLoai", "TenLoai", hangHoa.MaLoai);
            return View(hangHoa);
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
