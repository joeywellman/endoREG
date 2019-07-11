using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using endoREG_MVC.Data;
using endoREG_MVC.Models;


namespace endoREG_MVC.Controllers
{
    public class ActionItemCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActionItemCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: ActionItemCategories
        public async Task<IActionResult> Index(string searchQuery, string filterQuery, int? id)
        {

            var model = await _context.CompliancePlan.Include(ai => ai.ActionItems).ToListAsync();
            foreach (CompliancePlan compliancePlan in model)
            {
                compliancePlan.DaysToComplete = compliancePlan.ActionItems.Count();
                //If you want to limit list, use "Take(#).ToList();"
                ICollection<ActionItem> updatedActionItemList = compliancePlan.ActionItems.ToList();
                compliancePlan.ActionItems = updatedActionItemList;
            }
            return View(model);
        }

        // GET: ActionItemCategories/Details/
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var compliancePlan = await _context.CompliancePlan
                .FirstOrDefaultAsync(m => m.CompliancePlanId == id);
            if (compliancePlan == null)
            {
                return NotFound();
            }
            return View(compliancePlan);
        }


        // GET: ActionItemCategories/Create
        public IActionResult Create()
        {
            return View();
        }
        private bool CompliancePlanExists(int id)
        {
            return _context.CompliancePlan.Any(e => e.CompliancePlanId == id);
        }
    }
}
