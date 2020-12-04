﻿using PetWorld.Data.Entities.Enums;

namespace PetWorld.Data.Entities
{
    public class Pet
    {
        public uint? Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public bool Castrado { get; set; }
        public Sexo Sexo { get; set; }

        public Cliente Responsavel { get; set; }
        //public Prontuario Prontuario { get; set; }

        public Pet(string nome, string especie, string raca, bool castrado, Sexo sexo, Cliente responsavel)
        {
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Castrado = castrado;
            Sexo = sexo;
            Responsavel = responsavel;
        }
    }
}