using SuperheroCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperheroCreator.Controllers
{
    public class SuperHeroesController : Controller
    {
        ApplicationDbContext context;

        public SuperHeroesController()
        {
            context = new ApplicationDbContext();
        }
        // GET: SuperHeroes
        public ActionResult Index()
        {
            return View();
        }

        //GET: SuperHero Details
        public ActionResult Details(int id)
        {
            return View();
        }

        //GET: SuperHero Create
        public ActionResult Create()
        {
            SuperHero superhero = new SuperHero();
            return View();
        }

        //Post
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                context.SuperHeroes.Add(superHero);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}