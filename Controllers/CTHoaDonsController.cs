using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBanHang.Data;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class CTHoaDonsController : Controller
    {
        private readonly MvcBanHangContext _context;

        public CTHoaDonsController(MvcBanHangContext context)
        {
            _context = context;
        }

        // GET: CTHoaDons
        public async Task<IActionResult> Index()
        {
            return View(await _context.CTHoaDon.ToListAsync());
        }

        // GET: CTHoaDons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTHoaDon = await _context.CTHoaDon
                .FirstOrDefaultAsync(m => m.id == id);
            if (cTHoaDon == null)
            {
                return NotFound();
            }

            return View(cTHoaDon);
        }

        // GET: CTHoaDons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CTHoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,mahd,masp,soluong,dongia")] CTHoaDon cTHoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cTHoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cTHoaDon);
        }

        // GET: CTHoaDons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTHoaDon = await _context.CTHoaDon.FindAsync(id);
            if (cTHoaDon == null)
            {
                return NotFound();
            }
            return View(cTHoaDon);
        }

        // POST: CTHoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,mahd,masp,soluong,dongia")] CTHoaDon cTHoaDon)
        {
            if (id != cTHoaDon.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cTHoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CTHoaDonExists(cTHoaDon.id))
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
            return View(cTHoaDon);
        }

        // GET: CTHoaDons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTHoaDon = await _context.CTHoaDon
                .FirstOrDefaultAsync(m => m.id == id);
            if (cTHoaDon == null)
            {
                return NotFound();
            }

            return View(cTHoaDon);
        }

        // POST: CTHoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cTHoaDon = await _context.CTHoaDon.FindAsync(id);
            _context.CTHoaDon.Remove(cTHoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CTHoaDonExists(int id)
        {
            return _context.CTHoaDon.Any(e => e.id == id);
        }
    }
}
