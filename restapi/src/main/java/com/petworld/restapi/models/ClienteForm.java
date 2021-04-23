package com.petworld.restapi.models;

import com.petworld.restapi.entities.Cliente;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ClienteForm {

    private String nome;
    private String email;
    private String endereco;
    private String telefone;

    public Cliente toEntity() {
        return new Cliente(nome, email, endereco, telefone);
    }
}
