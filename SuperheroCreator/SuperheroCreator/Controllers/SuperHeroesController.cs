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
        // SuperHeroes
        public ActionResult Index(SuperHero superHero)
        {
            SuperHero newSuperhero = context.SuperHeroes.Where(s => s.Id == superHero.Id).FirstOrDefault();
            return View(newSuperhero);
        }

        //SuperHero Details
        public ActionResult Details(int id)
        {
            return View();
        }

        //SuperHero Create
        public ActionResult Create()
        {
            SuperHero superhero = new SuperHero();
            return View();
        }

        //Post (What the viewer will see after methods are called)
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                //you need insert logic
                context.SuperHeroes.Add(superHero);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //Allows you to edit people
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, string name)
        {
            try
            {
                //you need update logic
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //Allows you to delete
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, string name)
        {
            try
            {
                //add delete logic
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}