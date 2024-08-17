
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;




namespace MyPortfolio.Controllers
{
    public class DefaultController : Controller
    {   

        MyPortfolioContext context = new MyPortfolioContext();
        

        [HttpGet]
        public IActionResult Index()
        {
            Message message = new Message();
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


        [HttpPost]
        public async Task<IActionResult> Index(Message msg)
        {

             msg.SendDate = DateTime.Now;
             msg.IsRead = false;
            if (msg != null)
            {
                context.Messages.Add(msg);
                context.SaveChanges();
                string script = "<script>alert('MESAJINIZ BASARI ILE GONDERILDI..!'); window.location.href = '/Default/Index';</script>";
                await HttpContext.Response.WriteAsync(script);
                //Response.WriteAsync("<script>confirm('MESAJINIZ BASARI ILE GONDERILDI..!')</script>");
                return RedirectToAction("Index");   
            }
             
             return View();
            
            
            
            
        }

        


    }
}
