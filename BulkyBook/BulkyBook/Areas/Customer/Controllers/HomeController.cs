using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BulkyBook.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> products = _unitOfWork.Product.GetAll(includeProperties: "Category,CoverType");

            return View(products);
        }

        public IActionResult Details(int id)
        {
            var productFromDb =
                _unitOfWork.Product.GetFirstOrDefault(p => p.Id == id, includeProperties: "Category,CoverType");
            ShoppingCart cart = new ShoppingCart
            {
                Product = productFromDb,
                ProductId = productFromDb.Id,
            };
            return View(cart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Details(ShoppingCart cart)
        {
            cart.Id = 0;
            if (ModelState.IsValid)
            {
                // add to cart
                var claimsIdentity = (ClaimsIdentity) User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                cart.ApplicationUserId = claim.Value;

                ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.GetFirstOrDefault(u =>
                    u.ApplicationUserId == cart.ApplicationUserId
                    && u.ProductId == cart.ProductId, includeProperties: "Product");
                
                if (cartFromDb == null)
                {
                    _unitOfWork.ShoppingCart.Add(cart);
                }
                else
                {
                    cartFromDb.Count += cart.Count;
                    _unitOfWork.ShoppingCart.Update(cartFromDb);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                // return back to the view
                var productFromDb =
                    _unitOfWork.Product.GetFirstOrDefault(p => p.Id == cart.ProductId, includeProperties: "Category,CoverType");
                ShoppingCart cartToReturn = new ShoppingCart
                {
                    Product = productFromDb,
                    ProductId = productFromDb.Id,
                };
                return View(cart);
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
