package com.petworld.restapi.models.response;

import java.util.List;

import com.petworld.restapi.entities.Pet;
import com.petworld.restapi.entities.enums.Sexo;

import org.springframework.data.domain.Page;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class PetResponse {

    private String nome;
    private String especie;
    private String raca;
    private Boolean castrado;
    private Sexo sexo;

    public PetResponse(Pet entity) {
        nome = entity.getNome();
        especie = entity.getEspecie();
        raca = entity.getRaca();
        castrado = entity.getCastrado();
        sexo = entity.getSexo();
    }

    public static List<PetResponse> list(List<Pet> entities) {
        return entities.stream().map(e -> new PetResponse(e)).toList();
    }

    public static Page<PetResponse> page(Page<Pet> page) {
        return page.map(PetResponse::new);
    }
}
