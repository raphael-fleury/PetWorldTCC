package com.petworld.restapi.entities;

import java.util.List;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;

import lombok.Data;

@Entity @Data
public class Clinica {
    
    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;

    @OneToMany(mappedBy = "clinica")
    private List<Pet> pets;

    @OneToMany(mappedBy = "clinica")
    private List<Cliente> clientes;
}
