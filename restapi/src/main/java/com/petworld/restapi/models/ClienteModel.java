package com.petworld.restapi.models;

import java.util.List;

import com.petworld.restapi.entities.Cliente;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ClienteModel {
    
    private String nome;
    private String email;
    private String endereco;
    private String telefone;
    private List<PetModel> pets;

    public ClienteModel(Cliente entity) {
        nome = entity.getNome();
        email = entity.getEmail();
        endereco = entity.getEndereco();
        telefone = entity.getTelefone();
        // pets = PetModel.list(entity.getPets());
        // pets.forEach(p -> p.setDono(null));
    }

    public static List<ClienteModel> list(List<Cliente> entities) {
        return entities.stream().map(e -> new ClienteModel(e)).toList();
    }
}
