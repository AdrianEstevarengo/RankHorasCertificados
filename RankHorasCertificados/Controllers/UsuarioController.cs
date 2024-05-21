using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RankHorasCertificados.Data;
using RankHorasCertificados.Models;

namespace RankHorasCertificados.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly RankHorasCertificadosContext _context;

        public UsuarioController(RankHorasCertificadosContext context)
        {
            _context = context;
        }

        // GET: UsuarioModels
        public async Task<IActionResult> Index()
        {
            var usuarios = await _context.UsuarioModel.Include(u => u.Cursos).ToListAsync();
            return _context.UsuarioModel != null ?
                          View(await _context.UsuarioModel.ToListAsync()) :
                          Problem("Entity set 'RankHorasCertificadosContext.UsuarioModel'  is null.");
        }

        // GET: UsuarioModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UsuarioModel == null)
            {
                return NotFound();
            }

            var usuarioModel = await _context.UsuarioModel
                .FirstOrDefaultAsync(m => m.Matricula == id);
            if (usuarioModel == null)
            {
                return NotFound();
            }

            return View(usuarioModel);
        }

        // GET: UsuarioModels/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioModel);
        }

        // GET: UsuarioModels/Edit/5
        public async Task<IActionResult> Edit(int? Id)
        {
            
            if (Id == null || _context.UsuarioModel == null)
            {
                return NotFound();
            }
           // var usuarioModel = await _context.UsuarioModel.FindAsync(Id);
            var usuarioModel = await _context.UsuarioModel
               .FirstOrDefaultAsync(m => m.Matricula == Id);

            if (usuarioModel == null)
            {
                return NotFound();
            }
            return View(usuarioModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Matricula,Nome,Setor,Curso")] UsuarioModel usuarioModel)
        {
            if (id != usuarioModel.Matricula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioModelExists(usuarioModel.Matricula))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioModel);
        }

        // GET: UsuarioModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UsuarioModel == null)
            {
                return NotFound();
            }

            var usuarioModel = await _context.UsuarioModel
                .FirstOrDefaultAsync(m => m.Matricula == id);
            if (usuarioModel == null)
            {
                return NotFound();
            }

            return View(usuarioModel);
        }

        // POST: UsuarioModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UsuarioModel == null)
            {
                return Problem("Entity set 'RankHorasCertificadosContext.UsuarioModel'  is null.");
            }
            var usuarioModel = await _context.UsuarioModel.FindAsync(id);
            if (usuarioModel != null)
            {
                _context.UsuarioModel.Remove(usuarioModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioModelExists(int id)
        {
            return (_context.UsuarioModel?.Any(e => e.Matricula == id)).GetValueOrDefault();
        }
    }
}
