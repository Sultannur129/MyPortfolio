using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {   
        MyPortfolioContext context = new MyPortfolioContext();
        
        public IViewComponentResult Invoke() {

            var message = new Message();
            ViewBag.linkedin = context.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.github = context.Contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone1 = context.Contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.phone2 = context.Contacts.Select(x => x.Phone2).FirstOrDefault();
            ViewBag.email1 = context.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.email2 = context.Contacts.Select(x => x.Email2).FirstOrDefault();
            ViewBag.address = context.Contacts.Select(x => x.Address).FirstOrDefault();
            var splittable = ViewBag.address.Split(',');
            ViewBag.adres1 = splittable[0];
            ViewBag.adres2 = splittable[1];
            ViewBag.adres3 = splittable[2];
            
            return View(message); 
        }
     
    }


    



}
