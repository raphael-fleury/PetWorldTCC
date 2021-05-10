package com.petworld.restapi.models.response;

import java.util.List;
import java.util.stream.Collectors;

import com.petworld.restapi.entities.Cliente;

import org.springframework.data.domain.Page;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ClienteResponse {
    
    private Long id;
    private String nome;
    private String email;
    private String endereco;
    private String telefone;

    public ClienteResponse(Cliente entity) {
        id = entity.getId();
        nome = entity.getNome();
        email = entity.getEmail();
        endereco = entity.getEndereco();
        telefone = entity.getTelefone();
    }

    public static List<ClienteResponse> list(List<Cliente> entities) {
        return entities.stream().map(e -> new ClienteResponse(e)).collect(Collectors.toList());
    }

    public static Page<ClienteResponse> page(Page<Cliente> page) {
        return page.map(ClienteResponse::new);
    }
}
