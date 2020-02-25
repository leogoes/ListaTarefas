using ListaDeTarefas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListaDeTarefas.Controllers
{
    public class TarefasController : Controller
    {
        TarefasDb _db = new TarefasDb();
        // GET: Tarefas
        public ActionResult Index(string termoPesquisa)
        {
            //var model = _db.Tarefas.ToList();

            //Using Lambda para Formar Query
            var model = _db.Tarefas
                            .OrderBy(tare => tare.Id)
                            .Where(tare => termoPesquisa == null || tare.Nome.StartsWith(termoPesquisa));


            //Forma Query usando LINQ
            var model2 = from tare in _db.Tarefas
                         orderby tare.Nome
                         select tare;

            return View(model);

        }

        // GET: Tarefas/Details/5
        public ActionResult Details(int id)
        {
            Tarefas tarefas = _db.Tarefas.Find(id);
            return View(tarefas);
        }

        // GET: Tarefas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarefas/Create
        [HttpPost]
        public ActionResult Create(Tarefas tarefa)
        {
            try
            {
                _db.Tarefas.Add(tarefa);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tarefas/Edit/5
        public ActionResult Edit(int id)
        {
            Tarefas tarefas = _db.Tarefas.Find(id);
            return View(tarefas);
        }

        // POST: Tarefas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tarefas tarefa)
        {
            try
            {
                //var oldTarefa = _db.Tarefas.Find(id);
                _db.Entry(tarefa).State = EntityState.Modified;
                _db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tarefas/Delete/5
        public ActionResult Delete(int id)
        {
            Tarefas tarefas = _db.Tarefas.Find(id);
            return View(tarefas);
        }

        // POST: Tarefas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Tarefas tarefa)
        {
            try
            {
                Tarefas tarefas = _db.Tarefas.Find(id);
                _db.Tarefas.Remove(tarefas);
                _db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
