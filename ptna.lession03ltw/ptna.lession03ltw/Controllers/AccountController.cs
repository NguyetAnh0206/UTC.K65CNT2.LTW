using Microsoft.AspNetCore.Mvc;
using ptna.lession03ltw.Models;

namespace ptna.lession03ltw.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/02.jfif"),
                    Gender=1,
                    Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 1,Name="Trường Giang",
                    Email="giang@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/03.jfif"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 1,Name="Hoàng Thúy",
                    Email="thuy@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/04.jfif"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/02.jfif"),
                    Gender=1,
                    Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 1,Name="Trường Giang",
                    Email="giang@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/03.jfif"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 1,Name="Hoàng Thúy",
                    Email="thuy@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/04.jfif"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
            };
            // sử dụng using System.Linq; truy xuất dữ liệu 1 đối tượng trong danh sách theo id
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            // gửi đối tượng account qua view
            ViewBag.account = account;
            return View();
        }
    }
}
