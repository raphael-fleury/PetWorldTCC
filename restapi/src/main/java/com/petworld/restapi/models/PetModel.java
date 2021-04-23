package com.petworld.restapi.models;

import java.util.List;

import com.petworld.restapi.entities.Pet;
import com.petworld.restapi.entities.enums.Sexo;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class PetModel {

    private String nome;
    private String especie;
    private String raca;
    private Boolean castrado;
    private Sexo sexo;
    private ClienteModel dono;

    public PetModel(Pet entity) {
        nome = entity.getNome();
        especie = entity.getEspecie();
        raca = entity.getRaca();
        castrado = entity.getCastrado();
        sexo = entity.getSexo();
        dono = new ClienteModel(entity.getDono());
        //dono.setPets(null);
    }

    public static List<PetModel> list(List<Pet> entities) {
        return entities.stream().map(e -> new PetModel(e)).toList();
    }
}
