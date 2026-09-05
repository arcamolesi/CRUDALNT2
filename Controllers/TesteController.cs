using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUDALNT2.Data;
using CRUDALNT2.Models;


namespace CRUDALNT2.Controllers
{
    public class TesteController: Controller
    {
        private readonly AppDbContext contexto;


        public TesteController(AppDbContext context)
        {
            this.contexto = context;
        }

        public IActionResult Mostrar ()
        {
            return View();
        }

       // GET: Alunos
        public async Task<IActionResult> Index()
        {
            var appDbContext = contexto.Alunos.Include(a => a.curso);
            return View(await appDbContext.ToListAsync());
        }

       // GET: Alunos/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["cursoid"] = new SelectList(contexto.Cursos, "id", "descricao");
            return View();
        }

       // POST: Teste/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nome,idade,cursoid,nota")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                
                contexto.Add(aluno);
                await contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["cursoid"] = new SelectList(contexto.Cursos, "id", "descricao", aluno.cursoid);
            return View(aluno);
        }

    }
}