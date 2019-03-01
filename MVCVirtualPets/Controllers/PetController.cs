using Microsoft.AspNetCore.Mvc;
using MVCVirtualPets.Models;
using MVCVirtualPets.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Controllers
{
    public class PetController : Controller
    {
        //Controller picks the data and then attaches them to the view
        PetRepository petRepo;
        
        public PetController(PetRepository petRepo)
        {
            this.petRepo = petRepo;
        }

        public ViewResult Index()
        {
            IEnumerable<Pet> model = petRepo.GetAll();
            return View(model);
        }
    
        public ViewResult Details(int id)
        {
            var model = petRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pet pet)
        {
            petRepo.Create(pet);
            return RedirectToAction("Index");
        }
    }
}
