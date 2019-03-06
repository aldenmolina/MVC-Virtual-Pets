using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCVirtualPets.Models;

namespace MVCVirtualPets.Repositories
{
    public class MockPetRepository : IPetRepository
    {
        public void Create(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void Delete(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void Edit(Pet pet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pet> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pet GetById(int id)
        {
            return new Pet() { PetId = id };
        }
    }
}
