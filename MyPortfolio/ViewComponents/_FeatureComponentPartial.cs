using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();    
        public IViewComponentResult Invoke() {
            var values = _context.Features.ToList();
            ViewBag.linkedin = _context.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.github = _context.Contacts.Select(x => x.Description).FirstOrDefault();
            return View(values); 
        }
    }
}
