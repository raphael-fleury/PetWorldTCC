using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PetWorldWeb.Data.Entities;
using PetWorldWeb.Data.Entities.Page;

namespace PetWorldWeb.Data.Repositories
{
    public class PetsRepository : Repository
    {
        protected override string Href => "pets/";

        public async Task<Page<Pet>> GetPage(int index)
        {
            var response = await client.GetAsync(Href + "?pageNumber=" + index);

            await CheckForError(response);
            return await GetContent<Page<Pet>>(response);
        }

        public async Task<List<Pet>> GetAll()
        {
            var pets = new List<Pet>();
            int pageIndex = 0;
            Page<Pet> page;

            do
            {
                page = await GetPage(pageIndex);
                pets.AddRange(page.Content);
                pageIndex++;
            } 
            while (!page.Last);
            
            return pets;
        }

        public async Task<Pet> GetById(long id)
        {
            var response = await client.GetAsync(Href + id);

            await CheckForError(response);
            return await GetContent<Pet>(response);
        }

        public async Task<Pet> Post(Pet pet)
        {
            if (pet == null)
                throw new ArgumentNullException(nameof(pet));

            // var content = HttpContent
            var response = await client.PostAsync(Href + pet.Id, null);

            await CheckForError(response);
            return await GetContent<Pet>(response);
        }

        public async Task<Pet> Put(Pet pet)
        {
            if (pet == null)
                throw new ArgumentNullException(nameof(pet));

            if (pet.Id < 1)
                throw new ArgumentException(nameof(pet.Id));

            // var content = HttpContent
            var response = await client.PutAsync(Href + pet.Id, null);

            await CheckForError(response);
            return await GetContent<Pet>(response);
        }

        public async Task DeleteById(long id)
        {
            var response = await client.DeleteAsync(Href + id);
            await CheckForError(response);
        }
    }
}