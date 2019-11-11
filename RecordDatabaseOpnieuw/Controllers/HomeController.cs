using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecordDatabaseOpnieuw.Models;
using RecordDatabaseOpnieuw.Repositories;
using RecordDB;

namespace RecordDatabaseOpnieuw.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVinylplatenRepository vinylRepo;
        

        public HomeController(ILogger<HomeController> logger, IVinylplatenRepository vinylrepo)
        {
            _logger = logger;
            vinylRepo = vinylrepo;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Vinylplaten()
        {
            return View(vinylRepo.GetAllVinylPlaten());
        }

        

        public IActionResult Create()
        {
            return View(new VinylplatenModel());
        }

        [HttpPost]
        public IActionResult Create(VinylplatenModel vinylplaat)
        {

            if (!ModelState.IsValid)
                return View(vinylplaat);

            vinylRepo.CreateNewVinyl(vinylplaat);


            return RedirectToAction("Vinylplaten");
        }

        public ActionResult Edit(int vinylID)
        {
            var vinylplatenModel = vinylRepo.GetOneVinyplaat(vinylID);
            return View(vinylplatenModel);
        }

        [HttpPost]
        public ActionResult Edit(VinylplatenModel plaat)
        {
            vinylRepo.EditVinylPlaat(plaat);
            return RedirectToAction("Vinylplaten");
        }

        public ActionResult Delete(int vinylID)
        {
            var vinylplatenModel = vinylRepo.GetOneVinyplaat(vinylID);
            return View(vinylplatenModel);
        }

        [HttpPost]
        public ActionResult Delete(VinylplatenModel plaat)
        {
            vinylRepo.DeleteVinyl(plaat);
            return RedirectToAction("Vinylplaten");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        
    }
}
