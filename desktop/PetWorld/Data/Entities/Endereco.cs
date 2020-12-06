namespace PetWorld.Data.Entities
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(string logradouro, int? numero, string complemento, string bairro, string cidade, string estado)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public override string ToString()
        {
            string num = Numero.HasValue ? Numero.Value.ToString() : "s/n";
            string com = string.IsNullOrWhiteSpace(Complemento) ? "" : $"({Complemento}) ";
            return $"{Logradouro}, {num} {com}- {Bairro}, {Cidade}/{Estado}";
        }
    }
}
