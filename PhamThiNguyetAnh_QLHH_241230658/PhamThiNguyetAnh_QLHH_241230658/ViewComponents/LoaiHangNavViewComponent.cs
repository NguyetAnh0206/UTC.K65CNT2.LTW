using Microsoft.AspNetCore.Mvc;
using PhamThiNguyetAnh_QLHH_241230658.Models;
namespace PhamThiNguyetAnh_QLHH_241230658.ViewComponents
{
    public class LoaiHangNavViewComponent: ViewComponent
    {
        private readonly QLHangHoaContext _context;
        public LoaiHangNavViewComponent( QLHangHoaContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var dsLoai= _context.LoaiHangs.ToList();
            return View(dsLoai);

        }
    }
}
