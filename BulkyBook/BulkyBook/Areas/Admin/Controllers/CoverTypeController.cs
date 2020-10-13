using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            CoverType coverType = new CoverType();

            if (id == null) return View(coverType);

            coverType = _unitOfWork.CoverType.Get(id.GetValueOrDefault());

            if (coverType == null) return NotFound();

            return View(coverType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType coverType)
        {
            if (ModelState.IsValid)
            {
                if (coverType.Id == 0)
                    _unitOfWork.CoverType.Add(coverType);
                else
                    _unitOfWork.CoverType.Update(coverType);

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(coverType);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var coverTypeFromDb = _unitOfWork.CoverType.Get(id);
            if (coverTypeFromDb == null)
                return Json(new { success = false, message = "Error while deleting!" });

            _unitOfWork.CoverType.Remove(coverTypeFromDb);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            var allCategories = _unitOfWork.CoverType.GetAll();
            return Json(new { data = allCategories });
        }

        #endregion
    }
}
