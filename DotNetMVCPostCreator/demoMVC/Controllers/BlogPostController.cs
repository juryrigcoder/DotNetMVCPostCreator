using System;
using System.Web.Mvc;
using demoMVC.Domain;
using demoMVC.Models;

namespace demoMVC.Controllers
{
    public class BlogPostController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BlogPostForm(string title, string blogpost)
        {
           ArticleModel
            article = new ArticleModel()
            {
                ArticleId = 1,
                ArticleBody = blogpost,
                Title = title,
                Created = DateTime.UtcNow
            };
            Consumables.ConsumablesInsert(article);
            return RedirectToAction("Index");
        }
    }
}