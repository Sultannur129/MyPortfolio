using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class ContactController : Controller
	{   
		MyPortfolioContext context = new MyPortfolioContext();	
		public IActionResult ContactList()
		{   
			var value = context.Contacts.FirstOrDefault();
			ViewBag.Id = value.ContactId;
			ViewBag.linkedin = value.Title;
			ViewBag.github = value.Description;
			ViewBag.phone1 = value.Phone1;
			ViewBag.phone2 = value.Phone2;	
			ViewBag.email1 = value.Email1;
			ViewBag.email2 = value.Email2;
			ViewBag.address = value.Address;	
			return View();
		}

		[HttpGet]

		public IActionResult UpdateContact(int id) { 
		   
			var value = context.Contacts.Find(id);
			return View(value);	
		}
		[HttpPost]
		public IActionResult UpdateContact(Contact contact) { 
		    
			context.Contacts.Update(contact);
			context.SaveChanges();
			return RedirectToAction("ContactList");	
		}
	}
}
