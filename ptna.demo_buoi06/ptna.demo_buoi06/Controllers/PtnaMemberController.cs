using Microsoft.AspNetCore.Mvc;
using ptna.demo_buoi06.Models;


namespace ptna.demo_buoi06.Controllers
{
    public class PtnaMemberController : Controller
    {
        // mock data
        private static readonly List<PtnaMember> _ptnaMembers = new List<PtnaMember>()
        {
            new PtnaMember
            {
                PtnaMemberId = Guid.NewGuid().ToString(),
                PtnaMemberUserName = "phamthinguyetanh",
                PtnaMemberPassword = "123456@anh",
                PtnaMemberEmail = "phamthinguyetanh@gmail.com",
                PtnaMemberFullName = "Phạm Thị Nguyệt Anh"
            },
            new PtnaMember
            {
                PtnaMemberId = Guid.NewGuid().ToString(),
                PtnaMemberUserName = "tranthib",
                PtnaMemberPassword = "123",
                PtnaMemberEmail = "tranthib@gmail.com",
                PtnaMemberFullName = "Trần Thị B"
            },
            new PtnaMember
            {
                PtnaMemberId = Guid.NewGuid().ToString(),
                PtnaMemberUserName = "levanc",
                PtnaMemberPassword = "123",
                PtnaMemberEmail = "levanc@gmail.com",
                PtnaMemberFullName = "Lê Văn C"
            },
            new PtnaMember
            {
                PtnaMemberId = Guid.NewGuid().ToString(),
                PtnaMemberUserName = "phamdinhd",
                PtnaMemberPassword = "123",
                PtnaMemberEmail = "phamdinhd@gmail.com",
                PtnaMemberFullName = "Phạm Đình D"
            },
            new PtnaMember
            {
                PtnaMemberId = Guid.NewGuid().ToString(),
                PtnaMemberUserName = "hoangthie",
                PtnaMemberPassword = "123",
                PtnaMemberEmail = "hoangthie@gmail.com",
                PtnaMemberFullName = "Hoàng Thị E"
            }
        };
        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult PtnaIndex()
        {
            return View("PtnaIndex",_ptnaMembers);
        }
        [HttpPost]
        public IActionResult PtnaGreate(PtnaMember ptnaMember)
        {
            ptnaMember.PtnaMemberId = Guid.NewGuid().ToString();
            _ptnaMembers.Add(ptnaMember);
            return RedirectToAction("PtnaIndex");
        }

        public IActionResult PtnaGetDetails() {
            var PtnaMember = new PtnaMember()
            {
                PtnaMemberId = Guid.NewGuid().ToString(),
                PtnaMemberUserName = "PhamAnh",
                PtnaMemberPassword = "Anh111@",
                PtnaMemberFullName="Phạm Thị Nguyệt Anh",
                PtnaMemberEmail="Phamnguyetanh@gmail.com",

            };
            return View(PtnaMember);
        }
    }
}
