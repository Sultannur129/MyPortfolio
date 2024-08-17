using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {   
        MyPortfolioContext context = new MyPortfolioContext();  
        public IViewComponentResult Invoke() { 
            ViewBag.linkedin = context.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.github = context.Contacts.Select(x => x.Description).FirstOrDefault();

            return View(); 
        }
    }
}
