package com.petworld.restapi.entities;

import javax.persistence.Entity;
import javax.persistence.EnumType;
import javax.persistence.Enumerated;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.ManyToOne;

import com.petworld.restapi.entities.enums.Sexo;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.Setter;

@Entity @Getter @Setter @AllArgsConstructor
public class Pet {
    
    private Clinica clinica;

    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;
    private String especie;
    private String raca;
    private Boolean castrado;

    @Enumerated(EnumType.STRING)
    private Sexo sexo;

    @ManyToOne
    private Cliente dono;
}
