package com.petworld.restapi.models;

import javax.validation.constraints.Email;
import javax.validation.constraints.NotBlank;

import com.petworld.restapi.entities.Cliente;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ClienteForm {

    @NotBlank
    private String nome;

    @Email
    private String email;
    private String endereco;
    private String telefone;

    public Cliente toEntity() {
        return new Cliente(nome, email, endereco, telefone);
    }
}
