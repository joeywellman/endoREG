//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Authorization;
//using endoREG_MVC.Data;
//using endoREG_MVC.Models;
//using endoREG_MVC.Models.ActionItemViewModels;

//namespace endoREG_MVC.Controllers
//{
//    public class ActionItemsController : Controller
//    {
//        private readonly ApplicationDbContext _context;
//        private readonly UserManager<ApplicationUser> _userManager;

//        public ActionItemsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
//        {
//            _userManager = userManager;
//            _context = context;
//        }
//        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

//        protected string _connectionString;

//        protected SqlConnection Connection
//        {
//            get
//            {
//                return new SqlConnection(_connectionString);
//            }
//        }


//         GET: ActionItems
//        [Authorize]
//        public async Task<IActionResult> Index(string searchString)
//        {

//            var actionItems = from a in _context.ActionItem.Include(a => a.CompliancePlan).Include(a => a.User)
//                           select a;

//            if (!String.IsNullOrEmpty(searchString))
//            {
//                actionItems = actionItems.Where(ai => ai.Title.Contains(searchString) || ai.Location.Contains(searchString));
//            }

//            ApplicationUser user = await GetCurrentUserAsync();
//            var applicationDbContext = _context.ActionItem.Include(ai => ai.CompliancePlan).Include(cp => cp.User);
//            return View(await actionItems.ToListAsync());
//        }


//         GET: ActionItems/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            ApplicationUser user = await GetCurrentUserAsync();
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var actionItem = await _context.ActionItem
//                .Include(ai => ai.CompliancePlan)
//                .Include(ai => ai.User)
//                .FirstOrDefaultAsync(m => m.ActionItemId == id);
//            if (actionItem == null)
//            {
//                return NotFound();
//            }

//            return View(actionItem);
//        }


//         GET: ActionItems/Create
//        [Authorize]
//        public IActionResult Create()
//        {

//            ActionItemViewModel actionItemModel = new ActionItemViewModel();

//            SelectList compliancePlans = new SelectList(_context.CompliancePlan, "CompliancePlanId", "Label");
//             Add a 0 option to the select list
//            SelectList compliancePlans0 = CompliancePlanDropdown(compliancePlans);

//            actionItemModel.compliancePlans = compliancePlans0;

//            return View(actionItemModel);
//        }

//         POST: ActionItems/Create
//         To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//         more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create(ActionItemViewModel actionItemModel)
//        {
//            ModelState.Remove("actionItem.User");
//            ModelState.Remove("actionItem.UserId");

//            if (ModelState.IsValid)
//            {
//                using (var memoryStream = new MemoryStream())
//                {
//                    await actionItemModel.ActionItemImage.CopyToAsync(memoryStream);
//                    actionItemModel.actionItem.ActionItemImage = memoryStream.ToArray();
//                }


//                var currentUser = await GetCurrentUserAsync();

//                actionItemModel.actionItem.UserId = currentUser.Id;

//                using (var memoryStream = new MemoryStream())
//                {
//                    await actionItemModel.ActionItemImage.CopyToAsync(memoryStream);
//                    actionItemModel.actionItem.ActionItemImage = memoryStream.ToArray();
//                }

//                _context.Add(actionItemModel.actionItem);
//                await _context.SaveChangesAsync();
//                return RedirectToAction("Details", new { id = actionItemModel.actionItem.ActionItemId });
//            }


//            SelectList compliancePlans = new SelectList(_context.CompliancePlan, "CompliancePlanId", "Label");
//             Add a 0 option to the select list
//            SelectList compliancePlans0 = CompliancePlanDropdown(compliancePlans);

//            actionItemModel.compliancePlans = compliancePlans0;

//            return View(actionItemModel);
//        }

//         GET: ActionItems/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var actionItem = await _context.ActionItem.FindAsync(id);
//            if (actionItem == null)
//            {
//                return NotFound();
//            }
//            ViewData["CompliancePlanId"] = new SelectList(_context.CompliancePlan, "CompliancePlanId", "Label", actionItem.CompliancePlanId);
//            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", actionItem.UserId);
//            return View(actionItem);
//        }

//         POST: ActionItems/Edit/5
//         To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//         more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        Removed "ActionItemImage" from Selection Below:
//        public async Task<IActionResult> Edit(int id, [Bind("ActionItemId,DateAssigned,Description,Title,Weight,DaysToComplete,UserId,Location,Complete,IsActive,CompliancePlanId")] ActionItem actionItem)
//        {
//            if (id != actionItem.ActionItemId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {

//                    _context.Update(actionItem);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ActionItemExists(actionItem.ActionItemId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["CompliancePlanId"] = new SelectList(_context.CompliancePlan, "CompliancePlanId", "Label", actionItem.CompliancePlanId);
//            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", actionItem.UserId);
//            return View(actionItem);
//        }

//         GET: ActionItems/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var actionItem = await _context.ActionItem
//                .Include(ai => ai.CompliancePlan)
//                .Include(ai => ai.User)
//                .FirstOrDefaultAsync(m => m.ActionItemId == id);
//            if (actionItem == null)
//            {
//                return NotFound();
//            }

//            return View(actionItem);
//        }

//         POST: ActionItems/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var actionItem = await _context.ActionItem.FindAsync(id);
//            _context.ActionItem.Remove(actionItem);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ActionItemExists(int id)
//        {
//            return _context.ActionItem.Any(e => e.ActionItemId == id);
//        }

//        public static SelectList CompliancePlanDropdown(SelectList selectList)
//        {

//            SelectListItem firstItem = new SelectListItem()
//            {
//                Text = "Select a Compliance Plan"
//            };
//            List<SelectListItem> newList = selectList.ToList();
//            newList.Insert(0, firstItem);

//            var selectedItem = newList.FirstOrDefault(item => item.Selected);
//            var selectedItemValue = String.Empty;
//            if (selectedItem != null)
//            {
//                selectedItemValue = selectedItem.Value;
//            }

//            return new SelectList(newList, "Value", "Text", selectedItemValue);
//        }
//    }
//}
