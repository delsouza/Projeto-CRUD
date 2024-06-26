﻿using EmprestimoJogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmprestimoJogos.Context;

namespace EmprestimoJogos.Controllers
{
    public class EmprestimoJogoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmprestimoJogoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IList<EmprestimoViewModel> emprestimos = _db.Emprestimos.ToList();
            return View(emprestimos);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public ActionResult Editar(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            EmprestimoViewModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

            if (emprestimo == null)
            {
                return NotFound();
            }

            return View("Edit", emprestimo);
        }

        public ActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            EmprestimoViewModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

            if (emprestimo == null)
            {
                return NotFound();
            }

            return View(emprestimo);
        }
        [HttpPost]
        public ActionResult Adicionar(EmprestimoViewModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Add(emprestimo);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Editar(EmprestimoViewModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Update(emprestimo);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(emprestimo);
        }

        [HttpPost]
        public IActionResult Excluir(EmprestimoViewModel emprestimo)
        {
            if (emprestimo == null)
            {
                return NotFound();
            }

            _db.Emprestimos.Remove(emprestimo);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
