package com.petworld.restapi.models.insert;

import javax.validation.constraints.Email;
import javax.validation.constraints.NotBlank;
import javax.validation.constraints.Size;

import com.petworld.restapi.entities.Clinica;
import com.petworld.restapi.repositories.ClinicasRepository;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ClinicaInsert {

    @NotBlank
    private String nome;

    @Email
    private String email;
    
    @Size(min = 6, max = 24)
    private String senha;

    public Clinica toEntity(ClinicasRepository repository) {
        return new Clinica(nome, email, gerarCodigo(repository), senha);
    }

    private String gerarCodigo(ClinicasRepository repository) {
        var letras = "ABCDEFGHJKLMNPQRSTUVWXYZ";
        var numeros = "123456789";
        String codigo = "";

        for (int i = 0; i < 3; i++) {
            int index = (int)Math.floor(Math.random() * letras.length());
            codigo += letras.charAt(index);
            index = (int)Math.floor(Math.random() * numeros.length());
            codigo += numeros.charAt(index);
        }

        if (repository.existsByCodigo(codigo))
            codigo = gerarCodigo(repository);

        return codigo;
    }
}
