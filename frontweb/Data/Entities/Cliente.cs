using System.Collections.Generic;

namespace PetWorldWeb.Data.Entities
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public List<Pet> Pets { get; set; }
    }
}