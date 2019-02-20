using Microsoft.AspNetCore.Mvc;
using MVCVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Controllers
{
    public class PetController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    
        public ViewResult Details(int id)
        {
          
            var pets = new Dictionary<int, Pet>()
            {
                { 1, new Pet() { Name = "Doofus" } },
                { 2, new Pet() { Name = "Graile" } }
            };
            
            var model = pets[id];
            return View(model);

        }
    }
}
