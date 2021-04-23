package com.petworld.restapi.models.detailed;

import java.util.List;

import com.petworld.restapi.entities.Cliente;
import com.petworld.restapi.models.response.PetResponse;

import lombok.Getter;

@Getter
public class ClienteDetailed {
    
    private String nome;
    private String email;
    private String endereco;
    private String telefone;
    private List<PetResponse> pets;

    public ClienteDetailed(Cliente entity) {
        nome = entity.getNome();
        email = entity.getEmail();
        endereco = entity.getEndereco();
        telefone = entity.getTelefone();
        pets = PetResponse.list(entity.getPets());
    }

    public static List<ClienteDetailed> list(List<Cliente> entities) {
        return entities.stream().map(e -> new ClienteDetailed(e)).toList();
    }
}
