package com.petworld.restapi.models.update;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;

import com.petworld.restapi.entities.Pet;
import com.petworld.restapi.entities.enums.Sexo;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class PetUpdate {
    
    @NotBlank
    private String nome;

    @NotBlank
    private String especie;
    private String raca;
    private Boolean castrado;

    @NotNull
    private Sexo sexo;

    public Pet update(Pet entity) {
        entity.setNome(nome);
        entity.setEspecie(especie);
        entity.setRaca(raca);
        entity.setCastrado(castrado);
        entity.setSexo(sexo);

        return entity;
    }
}
