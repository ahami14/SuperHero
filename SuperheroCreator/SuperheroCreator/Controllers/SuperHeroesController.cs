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
        public ActionResult Index()
        {
            var heroes = context.SuperHeroes;
            return View(heroes);
        }

        //SuperHero Details
        public ActionResult Details(int id)
        {
            var superHero1 = context.SuperHeroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superHero1);
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
                SuperHero newSuperhero = context.SuperHeroes.Where(s => s.Id == superHero.Id).FirstOrDefault();
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
            var superHero1 = context.SuperHeroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superHero1);
        }

        [HttpPost]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                //you need update logic
                var editSuperHero1 = context.SuperHeroes.Where(s => s.Id == id).FirstOrDefault();
                editSuperHero1.superheroName = superHero.superheroName;
                editSuperHero1.firstName = superHero.firstName;
                editSuperHero1.lastName = superHero.lastName;
                editSuperHero1.primaryAbility = superHero.primaryAbility;
                editSuperHero1.secondaryAbility = superHero.secondaryAbility;
                editSuperHero1.catchPhrase = superHero.catchPhrase;
                
                context.SaveChanges();

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
            var superHero1 = context.SuperHeroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superHero1);
        }

        [HttpPost]
        public ActionResult Delete(int id, SuperHero superHero)
        {
            try
            {
                //add delete logic
                var deleteSuperHero1 = context.SuperHeroes.Where(s => s.Id == id).FirstOrDefault();
                deleteSuperHero1.superheroName = superHero.superheroName;
                deleteSuperHero1.firstName = superHero.firstName;
                deleteSuperHero1.lastName = superHero.lastName;
                deleteSuperHero1.primaryAbility = superHero.primaryAbility;
                deleteSuperHero1.secondaryAbility = superHero.secondaryAbility;
                deleteSuperHero1.catchPhrase = superHero.catchPhrase;
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