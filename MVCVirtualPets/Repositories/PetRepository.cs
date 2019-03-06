using MVCVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Repositories
{
    public class PetRepository : IPetRepository
    {
        PetContext db;

        public PetRepository(PetContext db)
        {
            this.db = db;
        }


        public IEnumerable<Pet> GetAll()
        {
            return db.Pets.ToList();
        }

        public Pet GetById(int id)
        {
            return db.Pets.Single(pet => pet.PetId == id);
        }

        public void Create(Pet pet)
        {
            db.Pets.Add(pet);
            db.SaveChanges();
        }

        public void Delete(Pet pet)
        {
            db.Pets.Remove(pet);
            db.SaveChanges();
        }

        public void Edit(Pet pet)
        {
            db.Update(pet);
            db.SaveChanges();
        }
    }
}
