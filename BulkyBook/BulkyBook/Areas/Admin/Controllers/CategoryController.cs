using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using BulkyBook.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(int productPage = 1)
        {
            CategoryVM categoryVm = new CategoryVM()
            {
                Categories = await _unitOfWork.Category.GetAllAsync()
            };

            var count = categoryVm.Categories.Count();
            categoryVm.Categories = categoryVm.Categories.OrderBy(c => c.Name)
                .Skip((productPage-1)*2).Take(2).ToList();
            categoryVm.PagingInfo = new PagingInfo()
            {
                CurrentPage = productPage,
                ItemsPerPage = 2,
                TotalItem = count,
                UrlParam = "/Admin/Category/Index?productPage=:"
            };
            return View(categoryVm);
        }
        public async Task<IActionResult> Upsert(int? id)
        {
            Category category = new Category();

            if (id == null) return View(category);

            category = await _unitOfWork.Category.GetAsync(id.GetValueOrDefault());

            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                    await _unitOfWork.Category.AddAsync(category);
                else
                    _unitOfWork.Category.Update(category);

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }


        #region API CALLS

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allCategories = await _unitOfWork.Category.GetAllAsync();
            return Json(new { data = allCategories });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var categoryFromDb = await _unitOfWork.Category.GetAsync(id);
            if (categoryFromDb == null)
            {
                TempData["Error"] = "Error deleting category";
                return Json(new {success = false, message = "Error while deleting!"});
            }

            await _unitOfWork.Category.RemoveAsync(categoryFromDb);
            _unitOfWork.Save();

            TempData["Success"] = "Category successfully deleted";
            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
