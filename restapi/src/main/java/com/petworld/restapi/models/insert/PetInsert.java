package com.petworld.restapi.models.insert;

import javax.validation.constraints.Min;
import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;

import com.petworld.restapi.entities.Cliente;
import com.petworld.restapi.entities.Pet;
import com.petworld.restapi.entities.enums.Sexo;
import com.petworld.restapi.repositories.ClientesRepository;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class PetInsert {
    
    @NotBlank
    private String nome;

    @NotBlank
    private String especie;
    private String raca;
    private Boolean castrado;

    @NotNull
    private Sexo sexo;

    @NotNull @Min(1)
    private Long donoId;

    public Pet toEntity(ClientesRepository clientesRepository) {
        Cliente dono = clientesRepository.findById(donoId).get();
        return new Pet(nome, especie, raca, castrado, sexo, dono);
    }
}
