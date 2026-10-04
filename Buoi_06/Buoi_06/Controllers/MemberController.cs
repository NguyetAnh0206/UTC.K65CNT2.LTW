using Microsoft.AspNetCore.Mvc;
using Buoi_06.Models.DataModels;

namespace Buoi_06.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            List<Member> members = new List<Member>()
        {
        new Member{MemberId = Guid.NewGuid().ToString(), Username = "member1", Fullname = "Thành viên 1", Password ="123456", Email = "tv1@gmail.com"},
        new Member{MemberId = Guid.NewGuid().ToString(), Username = "member2", Fullname = "Thành viên 2", Password ="123456", Email = "tv2@gmail.com"},
        new Member{MemberId = Guid.NewGuid().ToString(), Username = "member3", Fullname = "Thành viên 3", Password ="123456", Email = "tv3@gmail.com"},
        new Member{MemberId = Guid.NewGuid().ToString(), Username = "member4", Fullname = "Thành viên 4", Password ="123456", Email = "tv4@gmail.com"},
        new Member{MemberId = Guid.NewGuid().ToString(), Username = "member5", Fullname = "Thành viên 5", Password ="123456", Email = "tv5@gmail.com"},
        };

            ViewBag.members = members;
            return View();
        }
    }
}
