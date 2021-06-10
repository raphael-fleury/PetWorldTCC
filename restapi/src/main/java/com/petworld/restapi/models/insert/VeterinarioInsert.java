package com.petworld.restapi.models.insert;

import javax.validation.constraints.Email;
import javax.validation.constraints.NotBlank;

import com.petworld.restapi.entities.Veterinario;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class VeterinarioInsert {

    @NotBlank
    private String nome;

    @Email
    private String email;
    private String endereco;
    private String telefone;

    public Veterinario toEntity() {
        return new Veterinario(nome, email, endereco, telefone);
    }
}
