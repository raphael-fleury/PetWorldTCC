package com.petworld.restapi.models;

import com.petworld.restapi.entities.Cliente;
import com.petworld.restapi.entities.Pet;
import com.petworld.restapi.entities.enums.Sexo;
import com.petworld.restapi.repositories.ClientesRepository;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class PetForm {
    
    private String nome;
    private String especie;
    private String raca;
    private Boolean castrado;
    private Sexo sexo;
    private Long donoId;

    public Pet toEntity(ClientesRepository clientesRepository) {
        Cliente dono = clientesRepository.findById(donoId).get();
        return new Pet(nome, especie, raca, castrado, sexo, dono);
    }
}
