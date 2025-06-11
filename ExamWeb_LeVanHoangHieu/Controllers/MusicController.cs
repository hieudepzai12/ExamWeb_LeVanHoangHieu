using ExamWeb_LeVanHoangHieu.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamWeb_LeVanHoangHieu.Controllers
{
    public class MusicController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MusicController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var musicList = _db.DiaNhacs.ToList();
            //tổng số lượng đĩa nhạc
            var sumDiaNhac = musicList.Sum(m => m.SoLuong);
            ViewBag.TotalSoLuong = sumDiaNhac;
            return View(musicList);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(DiaNhac diaNhac)
        {
            if (ModelState.IsValid)
            {
                _db.DiaNhacs.Add(diaNhac);
                _db.SaveChanges();
                TempData["success"] = "Thêm đĩa nhạc thành công";
                return RedirectToAction("Index");
            }
            return View(diaNhac);
        }
        public IActionResult Update(int id)
        {
            var diaNhac = _db.DiaNhacs.Find(id);
            if (diaNhac == null)
            {
                return NotFound();
            }
            return View(diaNhac);
        }

        [HttpPost]
        public IActionResult Update(DiaNhac diaNhac)
        {
            if (ModelState.IsValid)
            {
                var existingDiaNhac = _db.DiaNhacs.Find(diaNhac.Id);
                if (existingDiaNhac == null)
                {
                    TempData["error"] = "Đĩa nhạc không tồn tại.";
                    return RedirectToAction("Index");
                }
                existingDiaNhac.TuaCD = diaNhac.TuaCD;
                existingDiaNhac.NgheSi = diaNhac.NgheSi;
                existingDiaNhac.TrongNuoc = diaNhac.TrongNuoc;
                existingDiaNhac.GiaBan = diaNhac.GiaBan;
                existingDiaNhac.SoLuong = diaNhac.SoLuong;
                _db.SaveChanges();
                TempData["success"] = "Cập nhật đĩa nhạc thành công.";
                return RedirectToAction("Index");
            }
            return View(diaNhac);
        }
        public IActionResult Delete(int id)
        {
            var diaNhac = _db.DiaNhacs.Find(id);
            if (diaNhac == null)
            {
                return NotFound();
            }
            return View(diaNhac);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var diaNhac = _db.DiaNhacs.Find(id);
            if (diaNhac == null)
            {
                TempData["error"] = "Đĩa nhạc không tồn tại.";
                return RedirectToAction("Index");
            }
            _db.DiaNhacs.Remove(diaNhac);
            _db.SaveChanges();
            TempData["success"] = "Xóa đĩa nhạc thành công.";
            return RedirectToAction("Index");
        }
    }
}
