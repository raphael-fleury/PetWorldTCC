package com.petworld.restapi.entities;

import java.util.List;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;

import lombok.Data;
import lombok.NoArgsConstructor;
import lombok.AllArgsConstructor;

@Entity @Data
@NoArgsConstructor @AllArgsConstructor
public class Veterinario {
    
    @ManyToOne
    private Clinica clinica;

    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;
    private String email;
    private String endereco;
    private String telefone;

    public Veterinario(String nome, String email, String endereco, String telefone) {
        this.nome = nome;
        this.email = email;
        this.endereco = endereco;
        this.telefone = telefone;
    }
}
