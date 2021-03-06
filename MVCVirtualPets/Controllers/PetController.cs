﻿using Microsoft.AspNetCore.Mvc;
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
        IPetRepository petRepo;
        
        public PetController(IPetRepository petRepo)
        {
            this.petRepo = petRepo;
        }

        public ViewResult Index()
        {
            var model = petRepo.GetAll();
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

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = petRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Pet pet)
        {
            petRepo.Delete(pet);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = petRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Pet pet)
        {
            petRepo.Edit(pet);
            return RedirectToAction("Details/" + pet.PetId);
        }
    }
}
