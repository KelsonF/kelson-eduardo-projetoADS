#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_Otilio.Models;

namespace Projeto_Otilio.Controllers
{
    public class FormasDePagamentoController : Controller
    {
        private readonly MyDbContext _context;

        public FormasDePagamentoController(MyDbContext context)
        {
            _context = context;
        }

        // GET: FormasDePagamento
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposDePagamento.ToListAsync());
        }

        // GET: FormasDePagamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaDePagamento = await _context.TiposDePagamento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formaDePagamento == null)
            {
                return NotFound();
            }

            return View(formaDePagamento);
        }

        // GET: FormasDePagamento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormasDePagamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeDoCobrado,InformacoesAdicionais")] FormaDePagamento formaDePagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaDePagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formaDePagamento);
        }

        // GET: FormasDePagamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaDePagamento = await _context.TiposDePagamento.FindAsync(id);
            if (formaDePagamento == null)
            {
                return NotFound();
            }
            return View(formaDePagamento);
        }

        // POST: FormasDePagamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeDoCobrado,InformacoesAdicionais")] FormaDePagamento formaDePagamento)
        {
            if (id != formaDePagamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaDePagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormaDePagamentoExists(formaDePagamento.Id))
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
            return View(formaDePagamento);
        }

        // GET: FormasDePagamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaDePagamento = await _context.TiposDePagamento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formaDePagamento == null)
            {
                return NotFound();
            }

            return View(formaDePagamento);
        }

        // POST: FormasDePagamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formaDePagamento = await _context.TiposDePagamento.FindAsync(id);
            _context.TiposDePagamento.Remove(formaDePagamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormaDePagamentoExists(int id)
        {
            return _context.TiposDePagamento.Any(e => e.Id == id);
        }
    }
}
