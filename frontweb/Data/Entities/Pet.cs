namespace PetWorldWeb.Data.Entities
{
    public class Pet
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public bool Castrado { get; set; }
        public string Sexo { get; set; }

        public Cliente Dono { get; set; }
    }
}