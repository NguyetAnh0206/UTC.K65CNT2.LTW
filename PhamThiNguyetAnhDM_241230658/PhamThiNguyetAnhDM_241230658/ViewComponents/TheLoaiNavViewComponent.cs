using Microsoft.AspNetCore.Mvc;
using PhamThiNguyetAnhDM_241230658.Models;
namespace PhamThiNguyetAnhDM_241230658.ViewComponents
{
    public class TheLoaiNavViewComponent: ViewComponent
    {
        private readonly QLNhaSachContext _context;
        public TheLoaiNavViewComponent(QLNhaSachContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var listTheLoai = _context.TheLoais.ToList();
            return View(listTheLoai);
        }
    }
}
