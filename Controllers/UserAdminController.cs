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

namespace RazorLibraryProject.Controllers
{
    public class UserAdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserAdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserAdmin
        public async Task<IActionResult> Index()
        {
            return _context.UserAdmin != null ?
                        View(await _context.UserAdmin.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.UserAdmin'  is null.");
        }

        // GET: UserAdmin/Details/#
        public async Task<IActionResult> Details(string id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }        

        // POST: UserAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName","Email","EmailConfirmed","PhoneNumber","PhoneNumberConfirmed")] IdentityUser user,
            string role)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                IdentityRole fullRole = _context.Roles.FirstOrDefault(x => x.Name == role);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: UserAdmin/Edit
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(string id)
        {
            if (_context.UserAdmin == null)
            {
                return NotFound();
            }

            var user = await _context.UserAdmin.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: UserAdmin/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string roleId, 
            [Bind("Username,Email,EmailConfirmed,PhoneNumber,PhoneNumberConfirmed,PasswordHash,LockedOut")] IdentityUser user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
        }

        // GET: UserAdmin/Delete
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.UserAdmin == null)
            {
                return NotFound();
            }

            var user = await _context.UserAdmin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: UserAdmin/Delete
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.UserAdmin == null)
            {
                return Problem("Entity set 'ApplicationDbContext.UserAdmin'  is null.");
            }
            var user = await _context.UserAdmin.FindAsync(id);
            if (user != null)
            {
                _context.UserAdmin.Remove(user);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "admin")]
        private bool UserExists(string id)
        {
            return (_context.UserAdmin?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
