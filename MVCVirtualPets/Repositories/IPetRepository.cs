using MVCVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Repositories
{
    public interface IPetRepository
    {

        IEnumerable<Pet> GetAll();
        Pet GetById(int id);
        void Create(Pet pet);
        void Delete(Pet pet);
        void Edit(Pet pet);
    }
}
