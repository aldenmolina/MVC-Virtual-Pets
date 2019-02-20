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
        //field
        Dictionary<int, Pet> pets = new Dictionary<int, Pet>()
            {
                { 1, new Pet() { Id = 1, Name = "Doofus" } },
                { 2, new Pet() { Id = 2, Name = "Graile" } },
                { 3, new Pet() { Id = 3, Name = "Blue" } }
            };


        public ViewResult Index()
        {
            IEnumerable<Pet> model = pets.Values.ToList();
            return View(model);
        }
    
        public ViewResult Details(int id)
        {           
            var model = pets[id];
            return View(model);
        }
    }
}
