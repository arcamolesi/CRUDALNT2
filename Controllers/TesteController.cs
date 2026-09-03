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


    }
}