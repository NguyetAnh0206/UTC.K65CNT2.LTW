using Microsoft.AspNetCore.Mvc;
using ptna.btvn04.Models;

namespace ptna.btvn04.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        protected Book book = new Book();

        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();
            return View(books);
        }
    }
}