using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class AuthenticationController:Controller
{
    [HttpGet]
    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Login(string username, string password)
    {
        if (IsValidUser(username, password))  // Kiểm tra thông tin đăng nhập
        {
            // Lưu thông tin người dùng vào session
            // Session["UserID"] = username;
            // Session["UserRole"] = GetUserRole(username);  // Lưu thêm thông tin vai trò nếu cần

            return RedirectToAction("Index", "Home");
        }
        else
        {
            ViewBag.ErrorMessage = "Invalid username or password.";
            return View();
        }
    }

    private bool IsValidUser(string username, string password)
    {
        // Kiểm tra thông tin từ cơ sở dữ liệu hoặc nguồn khác
        return (username == "admin" && password == "password");  // Demo
    }

    private string GetUserRole(string username)
    {
        // Lấy vai trò người dùng từ cơ sở dữ liệu nếu cần
        return "Admin";
    }
}