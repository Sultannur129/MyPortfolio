using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class TestimonialController : Controller
	{   
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult TestimonialList()
		{   
			var values = context.Testimonials.ToList();
			return View(values);
		}

		public IActionResult DeleteTestimonial(int id)
		{
			var value = context.Testimonials.Find(id);
			context.Testimonials.Remove(value);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");	
		}

		[HttpGet]
		public IActionResult CreateTestimonial() { 
		    
			return View();
		}

		[HttpPost]
		public IActionResult CreateTestimonial(Testimonial testimonial) { 
		   
			context.Testimonials.Add(testimonial);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}

		[HttpGet]
		public ActionResult UpdateTestimonial(int id) {

			var value = context.Testimonials.Find(id);
			return View(value);
		
		}

		[HttpPost]
		public IActionResult UpdateTestimonial(Testimonial testimonial) { 
		    
			context.Testimonials.Update(testimonial);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
	}
}
