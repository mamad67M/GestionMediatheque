using Business.Layer.DataAccess.BusinessObject;
using DataModel.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediathequeMVC.Controllers
{
    public class LivreController : Controller
    {   //definition des service dans le controller
        public LivreService Livre { get; set; }

        public LivreController()
        {
            Livre = new LivreService();
        }

        // GET: LivreController
        public ActionResult Index()
        {
            List<Livre> livres;
            livres = Livre.GetLivres(); // model bdd

            return View(livres);
        }

        // GET: LivreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LivreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LivreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LivreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LivreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LivreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LivreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
