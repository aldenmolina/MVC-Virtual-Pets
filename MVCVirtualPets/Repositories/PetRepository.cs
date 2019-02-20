using MVCVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVirtualPets.Repositories
{
    public class PetRepository
    {
        Dictionary<int, Pet> pets = new Dictionary<int, Pet>()
            {
                { 1, new Pet() { Id = 1, Name = "Doofus" } },
                { 2, new Pet() { Id = 2, Name = "Graile" } },
                { 3, new Pet() { Id = 3, Name = "Blue" } }
            };

        public IEnumerable<PetRepository> GetAll()
        {
            return pets.Values.ToList();
        }

        public Pet GetById(int id)
        {
            return pets[id];
        }
    }
}
