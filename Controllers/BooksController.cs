using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using RazorLibraryProject.Models;
using RazorLibraryProject.Data;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace RazorLibraryProject.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            return _context.Book != null ?
                        View(await _context.Book.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Book'  is null.");
        }

        // GET: Books/Details/#
        public async Task<IActionResult> Details(int id)
        {
            if (_context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int id)
        {
            var book = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }        

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,AuthorLast,AuthorFirst,Description,isAvailable")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // POST: Books/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,Title,AuthorLast,AuthorFirst,Description,isAvailable,whoHas")] Book book)
        {
            if (ModelState.IsValid)
            {
                try { 
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    if (!BookExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw ex;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // POST: Books/Index/#
        [HttpPost]
        [Authorize(Roles = "borrower, admin")]
        public async Task<IActionResult> Index(int id)
        {
            Book book = _context.Book.FirstOrDefault(x => x.Id == id);
            if (ModelState.IsValid)
            {
                if (book.whoHas == "admin" && book.isAvailable)
                {
                    book.whoHas = "borrower";
                    book.isAvailable = false;
                }
                else if (book.whoHas == "borrower" && !book.isAvailable)
                {
                    book.whoHas = "admin";
                    book.isAvailable = !book.isAvailable;
                } else //Weird cases where bogus left us with admin having checked out a book... librarians read!
                {
                    book.whoHas = "admin";
                    book.isAvailable = true;
                }
                _context.Update(book);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Books/Delete
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, string roleId)
        {
            if (_context.Book == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Book'  is null.");
            }
            var book = await _context.Book.FindAsync(id);
            if (book != null)
            {
                _context.Book.Remove(book);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return (_context.Book?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
