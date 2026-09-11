using Microsoft.AspNetCore.Mvc;
using ptna.btvn04.Models;

namespace ptna.btvn04.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();

        public IActionResult Index()
        {
            // Truyền dữ liệu SelectListItem tác giả và thể loại qua ViewBag để hiển thị trên ComboBox
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
        public IActionResult Create()
        {
            // Truyền dữ liệu SelectListItem tác giả và thể loại qua ViewBag
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;

            // Khởi tạo model Book mới để truyền sang View
            Book model = new Book();
            return View(model);
        }
        public PartialViewResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }
    }
}
