package com.petworld.restapi.models.update;

import javax.validation.constraints.Email;
import javax.validation.constraints.NotBlank;

import com.petworld.restapi.entities.Cliente;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ClienteUpdate {

    @NotBlank
    private String nome;

    @Email
    private String email;
    private String endereco;
    private String telefone;

    public Cliente update(Cliente entity) {
        entity.setNome(nome);
        entity.setEmail(email);
        entity.setEndereco(endereco);
        entity.setTelefone(telefone);

        return entity;
    }
}
