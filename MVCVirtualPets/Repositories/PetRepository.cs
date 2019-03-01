using MVCVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Repositories
{
    public class PetRepository
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
    }
}
