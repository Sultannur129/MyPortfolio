using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {   
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult PortfolioList()
        {   
            var values = _context.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
		public IActionResult CreatePortfolio()
		{
			return View();
		}
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio) {
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult DeletePortfolio(int id) {
            var value = _context.Portfolios.Find(id);
            _context.Portfolios.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = _context.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio) { 
           _context.Portfolios.Update(portfolio);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");   
        }

	}
}
