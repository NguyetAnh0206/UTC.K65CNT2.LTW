using Microsoft.AspNetCore.Mvc;
using ptna.lab6.Data;

namespace ptna.lab6.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        private readonly SchoolContext db;
        public MajorViewComponent(SchoolContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke()
        {
            var majors = db.Majors.OrderBy(m => m.MajorID).ToList();
            return View(majors);
        }
    }
}
