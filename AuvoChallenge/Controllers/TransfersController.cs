﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuvoChallenge.Models;

namespace AuvoChallenge.Controllers
{
    public class TransfersController : Controller
    {
        private readonly AuvoChallengeContext _context;

        public TransfersController(AuvoChallengeContext context)
        {
            _context = context;
        }

        // GET: Transfers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transfer.ToListAsync());
        }

        // GET: Transfers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transfer = await _context.Transfer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transfer == null)
            {
                return NotFound();
            }

            return View(transfer);
        }

        // GET: Transfers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transfers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Value,Date,Observation,Type")] Transfer transfer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transfer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transfer);
        }

        // GET: Transfers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transfer = await _context.Transfer.FindAsync(id);
            if (transfer == null)
            {
                return NotFound();
            }
            return View(transfer);
        }

        // POST: Transfers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Value,Date,Observation,Type")] Transfer transfer)
        {
            if (id != transfer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transfer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransferExists(transfer.Id))
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
            return View(transfer);
        }

        // GET: Transfers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transfer = await _context.Transfer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transfer == null)
            {
                return NotFound();
            }

            return View(transfer);
        }

        // POST: Transfers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transfer = await _context.Transfer.FindAsync(id);
            _context.Transfer.Remove(transfer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransferExists(int id)
        {
            return _context.Transfer.Any(e => e.Id == id);
        }
    }
}
