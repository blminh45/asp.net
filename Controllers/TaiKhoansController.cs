﻿using System;
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
    public class TaiKhoansController : Controller
    {
        private readonly MvcBanHangContext _context;

        public TaiKhoansController(MvcBanHangContext context)
        {
            _context = context;
        }

        // GET: TaiKhoans
        public async Task<IActionResult> Index()
        {
            return View(await _context.TaiKhoan.ToListAsync());
        }

        // GET: TaiKhoans/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan
                .FirstOrDefaultAsync(m => m.id == id);
            if (taiKhoan == null)
            {
                return NotFound();
            }

            return View(taiKhoan);
        }

        // GET: TaiKhoans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaiKhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,matkhau,email,sdt,diachi,hoten,laAdmin,anhdaidien,trangthai")] TaiKhoan taiKhoan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taiKhoan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taiKhoan);
        }

        // GET: TaiKhoans/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            if (taiKhoan == null)
            {
                return NotFound();
            }
            return View(taiKhoan);
        }

        // POST: TaiKhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("id,matkhau,email,sdt,diachi,hoten,laAdmin,anhdaidien,trangthai")] TaiKhoan taiKhoan)
        {
            if (id != taiKhoan.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taiKhoan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiKhoanExists(taiKhoan.id))
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
            return View(taiKhoan);
        }

        // GET: TaiKhoans/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan
                .FirstOrDefaultAsync(m => m.id == id);
            if (taiKhoan == null)
            {
                return NotFound();
            }

            return View(taiKhoan);
        }

        // POST: TaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            _context.TaiKhoan.Remove(taiKhoan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaiKhoanExists(string id)
        {
            return _context.TaiKhoan.Any(e => e.id == id);
        }
    }
}
