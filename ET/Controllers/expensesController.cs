using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ET.Data;
using ET.Models;

namespace ET.Controllers
{
    public class expensesController : Controller
    {
        private readonly ETContext _context;

        public expensesController(ETContext context)
        {
            _context = context;
        }

        // GET: expenses
        public async Task<IActionResult> Index(string category, DateTime? startDate, DateTime? endDate)
        {
            var expenses = from e in _context.expense select e;

            if (!string.IsNullOrEmpty(category))
                expenses = expenses.Where(e => e.category == category);

            if (startDate.HasValue && endDate.HasValue)
                expenses = expenses.Where(e => e.ExpenseDate >= startDate && e.ExpenseDate <= endDate);

            return View(await expenses.ToListAsync());
        }


        // GET: expenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.expense
                .FirstOrDefaultAsync(m => m.id == id);
            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }

        // GET: expenses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: expenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Title,Amount,ExpenseDate,category,Notes")] expense expense)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expense);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expense);
        }

        // GET: expenses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.expense.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }
            return View(expense);
        }

        // POST: expenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Title,Amount,ExpenseDate,category,Notes")] expense expense)
        {
            if (id != expense.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expense);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!expenseExists(expense.id))
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
            return View(expense);
        }

        // GET: expenses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.expense
                .FirstOrDefaultAsync(m => m.id == id);
            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }

        // POST: expenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expense = await _context.expense.FindAsync(id);
            if (expense != null)
            {
                _context.expense.Remove(expense);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool expenseExists(int id)
        {
            return _context.expense.Any(e => e.id == id);
        }
    }
}
