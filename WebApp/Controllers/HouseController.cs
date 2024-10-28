using System.Security.Claims;
using DAO.BaseModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace WebApp.Controllers;

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
        var houses = _houseService.GetHousesByUserId("");
        return View(houses);
    }
    public IActionResult Create()
    {
        return PartialView("Create");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(string name, string location)
    {
        if (ModelState.IsValid)
        {
            var newHouse = _houseService.CreateHouse(name, location);

            return RedirectToAction("Index");
        }
        return PartialView("Create");
    }
    public IActionResult Edit(int id)
    {
        var house = _houseService.GetHousesByUserId("");
        if (house == null) return NotFound();
        return PartialView("Edit", house);
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
        return PartialView("Edit", house);
    }
    public IActionResult Delete(int id)
    {
        _houseService.DeleteHouse(id);
        return RedirectToAction("Index");
    }
}
}