using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using MyPortfolio.DAL.Context;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
	public class LoginPageController : Controller
	{   
		MyPortfolioContext context = new MyPortfolioContext();	

		[HttpGet]
		public IActionResult Index()
		{
			
			
                
			return View();
            
			
			
		}

		[HttpPost]

		public async Task<IActionResult> Index(GetLogin getLogin)
		{

            var value = context.Logins.FirstOrDefault();
            if (value.Username.Equals(getLogin.username) && value.Password.Equals(getLogin.password))
            {
                return RedirectToAction("AboutList", "About");
            }
            else
            {

                string script = "<script>alert('GECERSIZ KULLANICI ADI VEYA SIFRE LUTFEN TEKRAR DENEYINIZ..!'); window.location.href = '/LoginPage/Index';</script>";
                await HttpContext.Response.WriteAsync(script);
                ModelState.AddModelError("", "Geçersiz Kullanıcı Adı veya Şifre");

                return View();
            }


        }
	}
}
