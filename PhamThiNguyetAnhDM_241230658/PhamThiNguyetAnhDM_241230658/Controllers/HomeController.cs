using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Rendering;
using PhamThiNguyetAnhDM_241230658.Models;
using System.Diagnostics;

namespace PhamThiNguyetAnhDM_241230658.Controllers
{
    public class HomeController : Controller
    {
        private readonly QLNhaSachContext _context;
        public HomeController(QLNhaSachContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var danhSachSach = _context.Saches.Where(s=>s.Gia !=null && s.Gia>=100).ToList();
            return View(danhSachSach);
        }
        public IActionResult LocSachTheoTheLoai(int? maTl)
        {
            var query = _context.Saches.AsQueryable();
            if (maTl.HasValue)
            {
                query = query.Where(s => s.MaTl == maTl.Value);
            }
            return PartialView("_DanhSachSachPartial", query.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MaTl = new SelectList(_context.TheLoais.ToList(), "MaTl", "TenTl");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sach sach)
        {
            ModelState.Remove("MaTlNavigation");
            if (ModelState.IsValid)
            {
                _context.Saches.Add(sach);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaTl = new SelectList(_context.TheLoais.ToList(), "MaTl", "TenTl", sach.MaTl);
            return View(sach);
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
