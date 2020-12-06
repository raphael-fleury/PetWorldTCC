namespace PetWorld.Data.Entities
{
    public class Cliente
    {
        public uint? Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Cliente(string nome, string cpf, string telefone, Endereco endereco)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
