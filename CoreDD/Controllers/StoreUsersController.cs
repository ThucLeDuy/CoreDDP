using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreDD.Models;

namespace CoreDD.Controllers
{
    public class StoreUsersController : Controller
    {
        private readonly DBFoodContext _context;

        public StoreUsersController(DBFoodContext context)
        {
            _context = context;
        }

        // GET: StoreUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.StoreUsers.ToListAsync());
        }

        // GET: StoreUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeUser = await _context.StoreUsers
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (storeUser == null)
            {
                return NotFound();
            }

            return View(storeUser);
        }

        // GET: StoreUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StoreUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Email,Password,FullName,Gender,Dob,Phonenumber,Address,Image")] StoreUser storeUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storeUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(storeUser);
        }

        // GET: StoreUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeUser = await _context.StoreUsers.FindAsync(id);
            if (storeUser == null)
            {
                return NotFound();
            }
            return View(storeUser);
        }

        // POST: StoreUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Email,Password,FullName,Gender,Dob,Phonenumber,Address,Image")] StoreUser storeUser)
        {
            if (id != storeUser.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(storeUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoreUserExists(storeUser.UserId))
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
            return View(storeUser);
        }

        // GET: StoreUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeUser = await _context.StoreUsers
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (storeUser == null)
            {
                return NotFound();
            }

            return View(storeUser);
        }

        // POST: StoreUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var storeUser = await _context.StoreUsers.FindAsync(id);
            _context.StoreUsers.Remove(storeUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoreUserExists(int id)
        {
            return _context.StoreUsers.Any(e => e.UserId == id);
        }
    }
}
