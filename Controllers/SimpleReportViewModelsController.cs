using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using endoREG_MVC.Data;
using endoREG_MVC.Models.SimpleReportViewModels;
using Microsoft.AspNetCore.Identity;
using endoREG_MVC.Models;
using System.Data.SqlClient;

namespace endoREG_MVC.Controllers
{
    public class SimpleReportViewModelsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public SimpleReportViewModelsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

       protected string _connectionString;

        protected SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        //https://www.c-sharpcorner.com/article/creating-charts-with-asp-net-core/

        //public IActionResult Pie()
        //{
        //    var rnd = new Random();
        //    var lstModel = new List<SimpleReportViewModel>();

        //    lstModel.Add(new SimpleReportViewModel
        //    {
        //        DimensionOne = "Beer",
        //        Quantity = rnd.Next(10)
        //    });
        //    lstModel.Add(new SimpleReportViewModel
        //    {
        //        DimensionOne = "Wine",
        //        Quantity = rnd.Next(10)
        //    });
        //    lstModel.Add(new SimpleReportViewModel
        //    {
        //        DimensionOne = "Whisky",
        //        Quantity = rnd.Next(10)
        //    });
        //    lstModel.Add(new SimpleReportViewModel
        //    {
        //        DimensionOne = "Water",
        //        Quantity = rnd.Next(10)
        //    });
        //    return View(lstModel);

        //}
        public IActionResult Pie()
        {
            //var rnd = new Random();
            var lstModel = new List<SimpleReportViewModel>();

            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Complete",
                Quantity = 1
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Incomplete",
                Quantity = 1
            });

            return View(lstModel);

        }
    }
}
