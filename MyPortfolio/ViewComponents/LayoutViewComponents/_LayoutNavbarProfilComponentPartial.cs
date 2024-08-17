using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarProfilComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
