using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptna.buoi07_tren_lop.Models;

namespace ptna.buoi07_tren_lop.Controllers
{
    public class PtnaMemberController : Controller
    {
        private static List<PtnaMember> ptnaMembers = new List<PtnaMember>();
        // GET: PtnaMemberController
        public ActionResult Index()
        {
            return View(ptnaMembers);
        }

        // GET: PtnaMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PtnaMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PtnaMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PtnaMember ptnaMember)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(ptnaMember);
                }
                ptnaMember.Id = ptnaMember.Id;
                ptnaMembers.Add(ptnaMember);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PtnaMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PtnaMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PtnaMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PtnaMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
