package com.petworld.restapi.entities;

import java.util.List;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;

import lombok.Data;

@Entity @Data
public class Cliente {
    
    @ManyToOne
    private Clinica clinica;

    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;
    private String email;
    private String endereco;
    private String telefone;

    @OneToMany(mappedBy = "dono")
    private List<Pet> pets;
}
