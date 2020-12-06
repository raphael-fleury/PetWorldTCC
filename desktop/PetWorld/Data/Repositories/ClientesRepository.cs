using PetWorld.Data.Entities;
using PetWorld.Data.Repositories.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorld.Data.Repositories
{
    static class ClientesRepository
    {
        private static List<Cliente> clientes = new List<Cliente>();
        
        private static uint maxId
        {
            get
            {
                try { return clientes.Max(c => c.Id.Value); }
                catch { return 0; }
            }
        }

        public static int Count => clientes.Count;

        public static Cliente FindById(ulong id)
        {
            Cliente cliente = clientes.Find(c => c.Id == id);

            if (cliente == null)
                throw new IdNotFoundException("Nenhum cliente com esse ID encontrado");

            return cliente;
        }

        public static IEnumerable<Cliente> FindAll()
        {
            return clientes;
        }

        public static IEnumerable<Cliente> FindAll(Func<Cliente, bool> predicate)
        {
            return clientes.Where(predicate);
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

        public static void Save(Cliente cliente)
        {
            if (!cliente.Id.HasValue)
                cliente.Id = maxId + 1;
            else if (ExistsWithId(cliente.Id.Value))
                DeleteById(cliente.Id.Value);

            clientes.Add(cliente);
        }

        public static void DeleteById(uint id)
        {
            if (!ExistsWithId(id))
                throw new IdNotFoundException("Nenhum pet com esse ID encontrado");

            clientes.RemoveAll(pet => pet.Id == id);
        }
    }
}
