using System.Security.Claims;
using DAO.BaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using WebApp.Models;

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

        [Authorize]
        public IActionResult Index()
        {
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId())
                .Take(10) // Load only the first 10 items initially
                .ToList();
            return View(houses);
        }

        public IActionResult HouseFilter(string? keyword)
        {
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
            if (!string.IsNullOrEmpty(keyword))
            {
                houses = houses.Where(h => h.Name.ToLower().Contains(keyword)).ToList();
            }

            return PartialView("HouseSection", houses);
        }

        public IActionResult LoadMoreHouses(int skip, int take)
        {
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId())
                .Skip(skip)
                .Take(take)
                .ToList();
            return PartialView("HouseSection", houses);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string name, string location)
        {
            if (ModelState.IsValid)
            {
                var newHouse = _houseService.CreateHouse(name, location);
                _houseService.AddHouseMember(_userService.GetCurrentUserId(), newHouse.ID, "Owner");
                return RedirectToAction("Index");
            }

            return PartialView("Create");
        }
        
        [Authorize]
        [HttpGet]
        public IActionResult Edit(int houseId)
        {
            Console.WriteLine("House ID: " + houseId + " User ID: " + _userService.GetCurrentUserId());
            if (!_houseService.IsHouseOwner(_userService.GetCurrentUserId(), houseId))
                return RedirectToAction("AccessDenied", "Account");

            return View("Edit", _houseService.GetHouseById(houseId));
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

        public IActionResult Delete(int houseId)
        {
            if (!_houseService.IsHouseOwner(_userService.GetCurrentUserId(), houseId))
                return RedirectToAction("AccessDenied", "Account");
            
            return View( _houseService.GetHouseById(houseId));
        }
        
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteHouse(int houseId)
        {
            var houseMembers = _houseService.GetHouseMembers(houseId);
            Console.WriteLine("House ID: " + houseId + " User ID: " + _userService.GetCurrentUserId());
            // get the current user role in the house
            var userRole = houseMembers.FirstOrDefault(hm => hm.UserID == _userService.GetCurrentUserId())?.Role;
            if (userRole == "Owner")
            {
                _houseService.DeleteHouse(houseId);
            }
            else
            {
                _houseService.RemoveHouseMember(_userService.GetCurrentUserId(), houseId);
            }

            return RedirectToAction("Index");
        }
    }
}