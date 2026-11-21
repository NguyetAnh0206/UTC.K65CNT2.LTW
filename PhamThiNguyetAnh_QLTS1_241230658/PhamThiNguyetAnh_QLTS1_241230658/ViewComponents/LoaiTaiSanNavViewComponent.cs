using Microsoft.AspNetCore.Mvc;
using PhamThiNguyetAnh_QLTS1_241230658.Models;
namespace PhamThiNguyetAnh_QLTS1_241230658.ViewComponents
{
    public class LoaiTaiSanNavViewComponent: ViewComponent
    {
        private readonly QLTaiSanContext _context;
        public LoaiTaiSanNavViewComponent(QLTaiSanContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var dsLoai = _context.LoaiTaiSans.ToList();
            return View(dsLoai);
        }
    }
}
