package com.petworld.restapi.models.detailed;

import java.util.List;
import java.util.stream.Collectors;

import com.petworld.restapi.entities.Cliente;
import com.petworld.restapi.models.response.PetResponse;

import org.springframework.data.domain.Page;

import lombok.Getter;

@Getter
public class ClienteDetailed {
    
    private Long id;
    private String nome;
    private String email;
    private String endereco;
    private String telefone;
    private List<PetResponse> pets;

    public ClienteDetailed(Cliente entity) {
        id = entity.getId();
        nome = entity.getNome();
        email = entity.getEmail();
        endereco = entity.getEndereco();
        telefone = entity.getTelefone();
        pets = PetResponse.list(entity.getPets());
    }

    public static List<ClienteDetailed> list(List<Cliente> entities) {
        return entities.stream().map(e -> new ClienteDetailed(e)).collect(Collectors.toList());
    }

    public static Page<ClienteDetailed> page(Page<Cliente> page) {
        return page.map(ClienteDetailed::new);
    }
}
