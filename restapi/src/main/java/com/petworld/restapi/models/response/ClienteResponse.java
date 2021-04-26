package com.petworld.restapi.models.response;

import java.util.List;

import com.petworld.restapi.entities.Cliente;

import org.springframework.data.domain.Page;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ClienteResponse {
    
    private String nome;
    private String email;
    private String endereco;
    private String telefone;

    public ClienteResponse(Cliente entity) {
        nome = entity.getNome();
        email = entity.getEmail();
        endereco = entity.getEndereco();
        telefone = entity.getTelefone();
    }

    public static List<ClienteResponse> list(List<Cliente> entities) {
        return entities.stream().map(e -> new ClienteResponse(e)).toList();
    }

    public static Page<ClienteResponse> page(Page<Cliente> page) {
        return page.map(ClienteResponse::new);
    }
}
