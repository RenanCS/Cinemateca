using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cinemateca.Context;
using Cinemateca.Models;

namespace Cinemateca.Controllers
{
    public class FilmeController : Controller
    {
        private CinefolanciaContext dbCinemateca = new CinefolanciaContext();


        // GET: Filme
        public ActionResult Index()
        {
            return View(dbCinemateca.Filmes.ToList());
        }

        // GET: Filme/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var filme = dbCinemateca.Filmes.Find(id);

            if (filme == null)
            {
                return HttpNotFound();
            }

            return View(filme);
        }

        // GET: Filme/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filme/Create
        [HttpPost]
        public ActionResult Create(Filme filme)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbCinemateca.Filmes.Add(filme);
                    dbCinemateca.SaveChanges();

                    return RedirectToAction("Index");
                }

                return View(filme);

            }
            catch
            {
                return View(filme);
            }
        }

        // GET: Filme/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var filme = dbCinemateca.Filmes.Find(id);

            if (filme == null)
            {
                return HttpNotFound();
            }

            return View(filme);
        }

        // POST: Filme/Edit/5
        [HttpPost]
        public ActionResult Edit(Filme filme)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbCinemateca.Entry(filme).State = EntityState.Modified;
                    dbCinemateca.SaveChanges();

                    return RedirectToAction("Index");
                }

                return View(filme);


            }
            catch
            {
                return View(filme);
            }
        }

        // GET: Filme/Delete/5
        public ActionResult Delete(int id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var filme = dbCinemateca.Filmes.Find(id);

            if (filme == null)
            {
                return HttpNotFound();
            }


            return View(filme);
        }

        // POST: Filme/Delete/5
        [HttpPost]
        public ActionResult Delete(Filme filme)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbCinemateca.Entry(filme).State = EntityState.Deleted;
                    dbCinemateca.SaveChanges();

                    return RedirectToAction("Index");
                }

                return View(filme);                 
                                                    
            }
            catch
            {
                return View(filme);
            }
        }
    }
}
