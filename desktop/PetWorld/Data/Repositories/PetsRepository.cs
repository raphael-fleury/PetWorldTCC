using PetWorld.Data.Entities;
using PetWorld.Data.Repositories.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorld.Data.Repositories
{
    static class PetsRepository
    {
        private static List<Pet> pets = new List<Pet>();
        
        private static uint maxId
        {
            get
            {
                try { return pets.Max(p => p.Id.Value); }
                catch { return 0; }
            }
        }

        public static int Count => pets.Count;

        public static Pet FindById(ulong id)
        {
            Pet pet = pets.Find(p => p.Id == id);

            if (pet == null)
                throw new IdNotFoundException("Nenhum pet com esse ID encontrado");

            return pet;
        }

        public static IEnumerable<Pet> FindAll()
        {
            return pets;
        }

        public static IEnumerable<Pet> FindAll(Func<Pet, bool> predicate)
        {
            return pets.Where(predicate);
        }

        public static bool ExistsWithId(ulong id)
        {
            try
            {
                FindById(id);
                return true;
            }
            catch { return false; }
        }

        public static void Save(Pet pet)
        {
            if (!pet.Id.HasValue)
                pet.Id = maxId + 1;
            else if (ExistsWithId(pet.Id.Value))
                DeleteById(pet.Id.Value);

            pets.Add(pet);
        }

        public static void DeleteById(uint id)
        {
            if (!ExistsWithId(id))
                throw new IdNotFoundException("Nenhum pet com esse ID encontrado");

            pets.RemoveAll(pet => pet.Id == id);
        }
    }
}
