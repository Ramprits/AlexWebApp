using AlexWebApp.Data;
using AlexWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlexWebApp.Controllers
{
    public class ClientsController :Controller
    {
        private readonly ApplicationDbContext _context;
        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IActionResult NewClient()
        {
            return View();
        }
        [HttpPost]
         public IActionResult NewClient(Client newClient)
        {
            if (ModelState.IsValid)
            {
            _context.clients.Add(newClient);
            return RedirectToAction("Index","Home");
            }
            return View();
        }


    }
}