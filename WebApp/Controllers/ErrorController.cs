using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	public class ErrorController : Controller
	{
		// Action cho lỗi chung
		[Route("Error/GeneralError")]
		public IActionResult GeneralError()
		{
			Console.WriteLine("GeneralError");
			return View();
		}

		// Action cho lỗi 404
		[Route("Error/404")]
		public IActionResult NotFound()
		{
			Console.WriteLine("GeneralError 40404040");
			Response.StatusCode = 404;
			return View();
		}

		// Action cho lỗi 403
		[Route("Error/403")]
		public IActionResult Forbidden()
		{
			Console.WriteLine("GeneralError 4030403043");
			Response.StatusCode = 403;
			return View();
		}
		public IActionResult BadRequest()
		{
			Response.StatusCode = 400;
			return View();
		}
		public IActionResult Unauthorized()
		{
			Response.StatusCode = 401;
			return View();
		}
        public IActionResult InternalServerError()
        {
            Response.StatusCode = 500;
            return View();
        }
        public IActionResult ServiceUnavailable()
        {
            Response.StatusCode = 503;
            return View();
        }
        public IActionResult GatewayTimeout()
        {
            Response.StatusCode = 504;
            return View();
        }
    }
}
