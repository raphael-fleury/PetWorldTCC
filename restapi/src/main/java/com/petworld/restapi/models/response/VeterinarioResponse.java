package com.petworld.restapi.models.response;

import java.util.List;

import com.petworld.restapi.entities.Veterinario;

import org.springframework.data.domain.Page;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class VeterinarioResponse {
    
    private Long id;
    private String nome;
    private String email;
    private String endereco;
    private String telefone;

    public VeterinarioResponse(Veterinario entity) {
        id = entity.getId();
        nome = entity.getNome();
        email = entity.getEmail();
        endereco = entity.getEndereco();
        telefone = entity.getTelefone();
    }

    public static List<VeterinarioResponse> list(List<Veterinario> entities) {
        return entities.stream().map(e -> new VeterinarioResponse(e)).toList();
    }

    public static Page<VeterinarioResponse> page(Page<Veterinario> page) {
        return page.map(VeterinarioResponse::new);
    }
}
