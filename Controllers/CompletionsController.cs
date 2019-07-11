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
using endoREG_MVC.Models.CompletionViewModels;

namespace endoREG_MVC.Controllers
{
    public class CompletionsController : Controller
    {
        public class OrdersController : Controller
        {
            private readonly ApplicationDbContext _context;

            private readonly UserManager<ApplicationUser> _userManager;

            public OrdersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
            {
                _context = context;
                _userManager = userManager;
            }

            // Gives us access to the user that's currently logged in
            private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


            // GET: Completions
            public async Task<IActionResult> Index()
            {
                var applicationDbContext = _context.Completion.Include(o => o.ResponsibleParty).Include(c => c.User);
                return View(await applicationDbContext.ToListAsync());
            }

            // GET: Completions/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var order = await _context.Completion
                    .Include(c => c.CompletionActionItems)
                        .ThenInclude(ca => ca.ActionItem)
                    .Where(c => c.CompletionId == id).SingleOrDefaultAsync();

                if (order == null)
                {
                    return NotFound();
                }

                return View(order);
            }

            // GET: Completions/Create
            [Authorize]
            public IActionResult Create()
            {

                return View();

            }

            // POST: Completions/Create
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(Completion completion)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(completion);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                return View();

            }

            // GET: Completions/Edit/5
            [Authorize]
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                ApplicationUser user = await GetCurrentUserAsync();
                var viewModel = new CompletionDetailViewModel();
                viewModel.Completion = await _context.Completion
                .Include(c => c.CompletionActionItems)
                        .ThenInclude(ca => ca.ActionItem)
                    .Where(c => c.CompletionId == id).SingleOrDefaultAsync();
                viewModel.UserResponsibleParties = new SelectList(_context.ResponsibleParty.Where(rp => rp.UserId == user.Id), "ResponsiblePartyId", "NameOrGroup");

                if (viewModel.Completion == null)
                {
                    return NotFound();
                }

                return View(viewModel);
            }

            // POST: Completions/Edit/5
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, CompletionDetailViewModel vm)
            {

                ModelState.Remove("Completions.User");
                ModelState.Remove("Completions.UserId");
                if (ModelState.IsValid)
                {
                    try
                    {
                        ApplicationUser user = await GetCurrentUserAsync();

                        vm.Completion.DateCompleted = DateTime.Now;
                        vm.Completion.CompletionId = id;
                        vm.Completion.UserId = user.Id;
                        _context.Update(vm.Completion);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CompletionExists(vm.Completion.CompletionId))
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

                ApplicationUser currentUser = await GetCurrentUserAsync();
                vm.UserResponsibleParties = new SelectList(
                    _context.ResponsibleParty
                    .Where(rp => rp.UserId == currentUser.Id),
                    "ResponsiblePartyId",
                    "NameOrGroup");

                return View(vm);
            }

            // GET: Completions/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var completion = await _context.Completion
                .Include(c => c.CompletionActionItems)
                    .Where(c => c.CompletionId == id).SingleOrDefaultAsync();

                if (completion == null)
                {
                    return NotFound();
                }

                if (completion.DateCompleted != null)
                {
                    return RedirectToAction(nameof(CompletionError));
                }

                return View(completion);
            }

            // POST: Completions/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var completion = await _context.Completion.FindAsync(id);
                _context.Completion.Remove(completion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            [Authorize]
            public IActionResult CompletionError()
            {
                return View();
            }

            private bool CompletionExists(int id)
            {
                return _context.Completion.Any(e => e.CompletionId == id);
            }
        }
    }
}
