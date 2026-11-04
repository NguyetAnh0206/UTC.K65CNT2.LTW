using Microsoft.AspNetCore.Mvc;
using ptna.lab5.Data;
using ptna.lab5.Models;
namespace ptna.lab5.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        SchoolContext db;

        public MajorViewComponent(SchoolContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var majors = db.Majors.ToList();
            return View("RenderMajor", majors);
        }
    }
}
