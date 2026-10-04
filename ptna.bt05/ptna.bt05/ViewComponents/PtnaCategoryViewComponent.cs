using Microsoft.AspNetCore.Mvc;
using ptna.bt05.Models;
namespace ptna.bt05.ViewComponents
{
    public class PtnaCategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(bool? active)
        {
            var categories = new List<TvcCategory>
            {
                new PtnaCategory(){ CategoryId =1, CategoryName="Điện gia dụng", IsActive=true },
                new PtnaCategory(){CategoryId=2,CategoryName="Iphone ", IsActive=true },
                new PtnaCategory(){CategoryId=3,CategoryName="Làm đẹp ", IsActive=true },
                new PtnaCategory(){CategoryId=4,CategoryName="Điện tử ", IsActive=false },

            };

            if (active != null)
            {
                categories = categories.Where(x => x.IsActive == active.Value).ToList();
            }
            return View(categories);
        }
    }
}
