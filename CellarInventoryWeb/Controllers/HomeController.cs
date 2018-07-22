using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CellarInventoryWeb.Models;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;

namespace CellarInventoryWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInventoryService _inventoryService;

        public HomeController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public IActionResult Index()
        {
            return View(_inventoryService.GetAllItems());
        }

        public IActionResult Details(string id)
        {
            Inventory item = _inventoryService.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return View(item);
            }
        }
        
        // GET: Item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Inventory NewItem)
        {
            try
            {
                _inventoryService.CreateItem(NewItem);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        public ActionResult Edit(string id)
        {
            Inventory item = _inventoryService.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return View(item);
            }
        }

        // POST: Item/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Inventory EditedItem)
        {
            try
            {
                _inventoryService.EditItem(id, EditedItem);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(string id)
        {
            Inventory item = _inventoryService.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return View(item);
            }
        }

        // POST: Item/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                _inventoryService.DeleteItem(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddSeedData()
        {
            try
            {
                Inventory CentralWatersInventory = new Inventory
                {
                    
                    Id = Guid.NewGuid().ToString(),
                    Manufacturer = "Central Waters",
                    ItemName = "Vanilla Bean Stout",
                    ItemType = "Barrel Aged Stout",
                    Year = 2018,
                    Quantity = 3
                };

                this.Create(CentralWatersInventory);

                Inventory TyranenaInventory = new Inventory
                {
                    Id = Guid.NewGuid().ToString(),
                    Manufacturer = "Tyranena",
                    ItemName = "Wrath of Rocky",
                    ItemType = "Barrel Aged Brown Alre",
                    Year = 2018,
                    Quantity = 4
                };

                this.Create(CentralWatersInventory);

                return RedirectToAction("Index");
                    
            }
            catch (System.Exception)
            {
                
                return View();
            }
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
