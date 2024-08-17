using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class ProfileController : Controller
	{   
		MyPortfolioContext context = new MyPortfolioContext();	
		public IActionResult ProfileInfo()
		{
			var value = context.Logins.FirstOrDefault();
			return View(value);
		}

		[HttpGet]
		public IActionResult UpdateProfile(int id) {
			var value = context.Logins.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateProfile(Login login) { 
		    
			context.Logins.Update(login);
			context.SaveChanges();
			return RedirectToAction("ProfileInfo");
		}
	}
}
