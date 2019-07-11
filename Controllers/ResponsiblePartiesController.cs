using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using endoREG_MVC.Data;
using endoREG_MVC.Models;

namespace endoREG_MVC.Controllers
{
    public class ResponsiblePartiesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ResponsiblePartiesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


        // GET: ResponsibleParties
        public async Task<IActionResult> Index()
        {
            var currentUser = await GetCurrentUserAsync();
            var applicationDbContext = _context.ResponsibleParty
                .Include(rp => rp.User)
                .Where(rp => rp.UserId == currentUser.Id)
                .Where(p => p.Inactive == false);
            return View(await applicationDbContext.ToListAsync());
        }


        // GET: ResponsibleParties/Details/
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var currentUser = await GetCurrentUserAsync();
            var responsibleParty = await _context.ResponsibleParty
                .Include(rp => rp.User)
                .Where(rp => rp.UserId == currentUser.Id)
                .FirstOrDefaultAsync(u => u.ResponsiblePartyId == id);
            if (responsibleParty == null)
            {
                return NotFound();
            }

            return View(responsibleParty);
        }


        // GET: ResponsibleParties/Create
        [Authorize]
        public IActionResult Create()
        {

            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }


        // POST: ResponsibleParties/Create
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DateAssigned,NameOrGroup,NameOrGroupNumber")] ResponsibleParty responsibleParty)
        {
            ModelState.Remove("UserId");
            ModelState.Remove("User");
            if (ModelState.IsValid)
            {
                var currentUser = await GetCurrentUserAsync();
                responsibleParty.UserId = currentUser.Id;
                _context.Add(responsibleParty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", responsibleParty.UserId);
            return View(responsibleParty);
        }


        // GET: ResponsibleParties/Edit/
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsibleParty = await _context.ResponsibleParty.FindAsync(id);
            if (responsibleParty == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", responsibleParty.UserId);
            return View(responsibleParty);
        }

        // POST: ResponsibleParties/Edit/
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ResponsiblePartyId,UserId,NameOrGroup,NameOrGroupNumber,UserId")] ResponsibleParty responsibleParty)
        {
            var currentUser = await GetCurrentUserAsync();
            if (id != responsibleParty.ResponsiblePartyId)
            {
                return NotFound();
            }

            ModelState.Remove("User");
            ModelState.Remove("DateAssigned");
            ModelState.Remove("UserId");
            responsibleParty.UserId = currentUser.Id;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(responsibleParty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentTypeExists(responsibleParty.ResponsiblePartyId))
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
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", responsibleParty.UserId);
            return View(responsibleParty);
        }


        // GET: ResponsibleParties/Delete/
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var currentUser = await GetCurrentUserAsync();
            var paymentType = await _context.ResponsibleParty
                .Include(rp => rp.User)
                .Where(rp => rp.UserId == currentUser.Id)
                .FirstOrDefaultAsync(u => u.ResponsiblePartyId == id);
            if (paymentType == null)
            {
                return NotFound();
            }

            return View(paymentType);
        }


        // POST: ResponsibleParties/Delete/
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var responsibleParty = await _context.ResponsibleParty.FindAsync(id);
            var completionHistory = (_context.Completion
                .Include(c => c.ResponsiblePartyId)
                .Where(c => c.ResponsiblePartyId == id)).Count();
            if (completionHistory > 0)
            {
                responsibleParty.Inactive = true;
            }
            else
            {
                _context.ResponsibleParty.Remove(responsibleParty);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentTypeExists(int id)
        {
            return _context.ResponsibleParty.Any(u => u.ResponsiblePartyId == id);
        }
    }
}
