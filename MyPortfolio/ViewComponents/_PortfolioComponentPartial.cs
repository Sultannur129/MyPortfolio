using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {   
        MyPortfolioContext _context = new MyPortfolioContext(); 
        public IViewComponentResult Invoke() {  
            var values = _context.Portfolios.ToList();
            return View(values); 
        }    
    }
}
