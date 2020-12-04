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
        private static List<Pet> pets;
        private static uint maxId => pets.Max(p => p.Id);

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
            if (ExistsWithId(pet.Id))
                DeleteById(pet.Id);

            pets.Add(pet);
        }

        public static void DeleteById(uint id)
        {
            pets.RemoveAll(pet => pet.Id == id);
        }
    }
}
