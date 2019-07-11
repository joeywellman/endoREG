using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using endoREG_MVC.Data;
using endoREG_MVC.Models;
using endoREG_MVC.Models.CompliancePlanViewModels;


namespace endoREG_MVC.Controllers
{
    public class CompliancePlansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompliancePlansController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: CompliancePlans
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompliancePlan.ToListAsync());
        }

        //// GET: ActionItems
        //public async Task<IActionResult> Index(string searchQuery, string filterQuery, int? id)
        //{
        //    var actionItems = from a in _context.ActionItem.Include(a => a.CompliancePlan).Include(a => a.User) select a;
        //    if (!String.IsNullOrEmpty(searchQuery))
        //    {
        //        actionItems = actionItems.Where(s => s.Title.Contains(searchQuery) || s.Location.Contains(searchQuery));
        //    }
        //    ApplicationUser user = await GetCurrentUserAsync();
        //    var applicationDbContext = _context.ActionItem.Include(a => a.CompliancePlan).Include(a => a.User);
        //    return View(await actionItems.ToListAsync());
        //}


        // GET: CompliancePlans/Details/
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CompliancePlanDetailViewModel compliancePlanDetails = new CompliancePlanDetailViewModel();

            var compliancePlan = await _context.CompliancePlan
                .Include(a => a.ActionItems)
                .FirstOrDefaultAsync(c => c.CompliancePlanId == id);
            if (compliancePlan == null)
            {
                return NotFound();
            }

            compliancePlanDetails.CompliancePlan = compliancePlan;

            return View(compliancePlanDetails);
        }


        // GET: CompliancePlans/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: CompliancePlans/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompliancePlanId,Label")] CompliancePlan compliancePlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compliancePlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(compliancePlan);
        }


        // GET: CompliancePlans/Edit/
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compliancePlan = await _context.CompliancePlan.FindAsync(id);
            if (compliancePlan == null)
            {
                return NotFound();
            }
            return View(compliancePlan);
        }


        // POST: CompliancePlans/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompliancePlanId,Label")] CompliancePlan compliancePlan)
        {
            if (id != compliancePlan.CompliancePlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compliancePlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompliancePlanExists(compliancePlan.CompliancePlanId))
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
            return View(compliancePlan);
        }


        // GET: CompliancePlans/Delete/
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compliancePlan = await _context.CompliancePlan
                .FirstOrDefaultAsync(c => c.CompliancePlanId == id);
            if (compliancePlan == null)
            {
                return NotFound();
            }

            return View(compliancePlan);
        }


        // POST: CompliancePlans/Delete/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compliancePlan = await _context.CompliancePlan.FindAsync(id);
            _context.CompliancePlan.Remove(compliancePlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompliancePlanExists(int id)
        {
            return _context.CompliancePlan.Any(e => e.CompliancePlanId == id);
        }
    }
}