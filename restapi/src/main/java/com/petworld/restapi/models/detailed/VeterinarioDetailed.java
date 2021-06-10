package com.petworld.restapi.models.detailed;

import java.util.List;
import java.util.stream.Collectors;

import com.petworld.restapi.entities.Veterinario;

import org.springframework.data.domain.Page;

import lombok.Getter;

@Getter
public class VeterinarioDetailed {
    
    private Long id;
    private String nome;
    private String email;
    private String endereco;
    private String telefone;

    public VeterinarioDetailed(Veterinario entity) {
        id = entity.getId();
        nome = entity.getNome();
        email = entity.getEmail();
        endereco = entity.getEndereco();
        telefone = entity.getTelefone();
    }

    public static List<VeterinarioDetailed> list(List<Veterinario> entities) {
        return entities.stream().map(e -> new VeterinarioDetailed(e)).collect(Collectors.toList());
    }

    public static Page<VeterinarioDetailed> page(Page<Veterinario> page) {
        return page.map(VeterinarioDetailed::new);
    }
}
