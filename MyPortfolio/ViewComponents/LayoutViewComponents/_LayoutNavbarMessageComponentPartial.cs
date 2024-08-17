using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarMessageComponentPartial:ViewComponent
	{    
		MyPortfolioContext context = new MyPortfolioContext();	
		public IViewComponentResult Invoke()
		{   
			ViewBag.messageCount = context.Messages.Where(x => x.IsRead == false).Count();
			return View();
		}
	}
}
