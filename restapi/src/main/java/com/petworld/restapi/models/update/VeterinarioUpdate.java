package com.petworld.restapi.models.update;

import javax.validation.constraints.Email;
import javax.validation.constraints.NotBlank;

import com.petworld.restapi.entities.Veterinario;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class VeterinarioUpdate {

    @NotBlank
    private String nome;

    @Email
    private String email;
    private String endereco;
    private String telefone;

    public Veterinario update(Veterinario entity) {
        entity.setNome(nome);
        entity.setEmail(email);
        entity.setEndereco(endereco);
        entity.setTelefone(telefone);

        return entity;
    }
}
