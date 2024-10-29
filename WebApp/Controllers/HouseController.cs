using System.Security.Claims;
using DAO.BaseModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace WebApp.Controllers
{

    public class HouseController : Controller
    {
        private readonly IHouseService _houseService;
        private readonly IUserService _userService;

        public HouseController(IHouseService houseService, IUserService userService)
        {
            _houseService = houseService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
            return View(houses);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string name, string location)
        {
            if (ModelState.IsValid)
            {
                var newHouse = _houseService.CreateHouse(name, location);
                _houseService.AddHouseMember(_userService.GetCurrentUserId(),newHouse.ID, "Owner");
                return RedirectToAction("Index");
            }
            return PartialView("Create");
        }
        public IActionResult Edit(int id)
        {
            return View("Edit", _houseService.GetHouseById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(House house)
        {
            if (ModelState.IsValid)
            {
                _houseService.EditHouse(house);
                return RedirectToAction("Index");
            }
            return View("Edit", house);
        }

    }
}