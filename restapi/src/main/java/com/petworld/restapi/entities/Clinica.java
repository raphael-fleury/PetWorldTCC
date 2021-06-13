package com.petworld.restapi.entities;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity @Data
@NoArgsConstructor @AllArgsConstructor
public class Clinica {
    
    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;
    private String email;
    private String codigo;
    private String senha;

    public Clinica(String nome, String email, String codigo, String senha) {
        this.nome = nome;
        this.email = email;
        this.codigo = codigo;
        this.senha = senha;
    }
}
