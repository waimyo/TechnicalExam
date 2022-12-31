using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TechnicalExam.Models;

namespace TechnicalExam.Controllers
{
    public class InventoryController : Controller
    {
        private readonly RepositoryContext _db;

        public InventoryController(RepositoryContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Inventory> inventory = new List<Inventory>();
            inventory = _db.Inventories.ToList();
            return View(inventory);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
