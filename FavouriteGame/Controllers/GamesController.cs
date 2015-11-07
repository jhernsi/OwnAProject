using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

using GameDBModel;

namespace FavouriteGame.Controllers
{
    public class GamesController : Controller
    {

        private DBModelContainer DB = new DBModelContainer();
        // GET: Game

        public ActionResult Index()
        {
            
            return View(DB.Games.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create( [Bind(Include="Title,Platform")] Game g)
        {
            if (ModelState.IsValid)
            {
                DB.Games.Add(g);
                    DB.SaveChanges();
                    return RedirectToAction("Index");

            }
            else
                return View();
        }
        

        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            else
            {
                Game g = DB.Games.Find(id);
                if (g == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(g);
                }
            }
             
        }


        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            else
            {
                Game g = DB.Games.Find(id);
                if(g== null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(g); 
                }
            }
        }
        
        [HttpPost]
        public ActionResult Edit([Bind(Include= "id,Title,Platform")] Game g)
        {
            if(ModelState.IsValid)
            {
                DB.Entry(g).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
              return  View(g);
            }
        }

    }
}