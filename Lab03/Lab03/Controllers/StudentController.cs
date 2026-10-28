using Microsoft.AspNetCore.Mvc;
using Lab03.Models;

namespace Lab03.Controllers
{
    public class StudentController : Controller
    {
        private static readonly List<Student> listStudents = new List<Student>();

        // GET: Student
        public IActionResult Index()
        {
            return View(listStudents);
        }

        // GET: Student/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student s)
        {
            // Kiểm tra các Annotation trong Model
            if (ModelState.IsValid)
            {
                // Tạo mã sinh viên tiếp theo
                s.Id = listStudents.Count > 0
                    ? listStudents.Max(x => x.Id) + 1
                    : 1;

                // Thêm sinh viên vào danh sách
                listStudents.Add(s);

                // Chuyển sang trang danh sách sinh viên
                return RedirectToAction(nameof(Index));
            }

            // Nếu dữ liệu không hợp lệ, hiển thị lại form
            return View(s);
        }
    }
}
