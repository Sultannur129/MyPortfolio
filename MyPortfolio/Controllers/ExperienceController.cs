using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {   
        MyPortfolioContext _context = new MyPortfolioContext();

        public IActionResult ExperienceList()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }

        [HttpGet] // Sayfa yüklenince çalışacak
        public IActionResult CreateExperience() { 
             return View();
        }

		[HttpPost] // Sayfada bir butona basınca çalışacak
		public IActionResult CreateExperience(Experience experience)
		{   
            _context.Experiences.Add(experience);
            _context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

        public IActionResult DeleteExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            _context.Experiences.Remove(value);
          _context.SaveChanges();
          return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id) {
            var value = _context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience) { 
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
	}
}
