package com.petworld.restapi.models.detailed;

import java.util.List;
import java.util.stream.Collectors;

import com.petworld.restapi.entities.Pet;
import com.petworld.restapi.entities.enums.Sexo;
import com.petworld.restapi.models.response.ClienteResponse;

import org.springframework.data.domain.Page;

import lombok.Getter;

@Getter
public class PetDetailed {
    
    private Long id;
    private String nome;
    private String especie;
    private String raca;
    private Boolean castrado;
    private Sexo sexo;
    private ClienteResponse dono;

    public PetDetailed(Pet entity) {
        id = entity.getId();
        nome = entity.getNome();
        especie = entity.getEspecie();
        raca = entity.getRaca();
        castrado = entity.getCastrado();
        sexo = entity.getSexo();
        dono = new ClienteResponse(entity.getDono());
    }

    public static List<PetDetailed> list(List<Pet> entities) {
        return entities.stream().map(e -> new PetDetailed(e)).collect(Collectors.toList());
    }

    public static Page<PetDetailed> page(Page<Pet> page) {
        return page.map(PetDetailed::new);
    }
}
