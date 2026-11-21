using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhamThiNguyetAnh_QLTS2_241230658.Models;
using System.Diagnostics;

namespace PhamThiNguyetAnh_QLTS2_241230658.Controllers
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
            var danhSachTaiSan= _context.TaiSans.Where(ts => ts.NguyenGia!=null && ts.NguyenGia>=20).ToList();
            return View(danhSachTaiSan);
        }
        public IActionResult LocTheoLoai(int? maLoai)
        {
            var query = _context.TaiSans.AsQueryable();
            if (maLoai.HasValue)
            {
                query = query.Where(ts => ts.MaLoai == maLoai.Value);
            }
            else
            {
                query = query.Where(ts => ts.NguyenGia != null && ts.NguyenGia >= 20);
            }
            return PartialView("_DanhSachTaiSanPartial", query.ToList());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var taiSan = _context.TaiSans.Find(id);
            if(taiSan == null)
            {
                return NotFound();
            }
            ViewBag.MaLoai = new SelectList(_context.LoaiTaiSans.ToList(), "MaLoai", "TenLoai", taiSan.MaLoai);
            return View(taiSan);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TaiSan taiSan)
        {
            if(id != taiSan.MaTs)
            {
                return NotFound();
            }
            ModelState.Remove("MaLoaiNavigation");
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taiSan);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TaiSans.Any(e => e.MaTs == taiSan.MaTs))
                    {
                        return NotFound();
                    }
                    throw;
                }
            }
            ViewBag.MaLoai = new SelectList(_context.LoaiTaiSans.ToList(), "MaLoai", "TenLoai", taiSan.MaLoai);
            return View(taiSan);
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
