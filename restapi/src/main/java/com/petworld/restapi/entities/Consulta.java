package com.petworld.restapi.entities;

import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.ManyToOne;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity @Data
@NoArgsConstructor @AllArgsConstructor
public class Consulta {
    
    @ManyToOne
    private Clinica clinica;

    @ManyToOne
    private Veterinario veterinario;

    @ManyToOne
    private Pet pet;

    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private Date data;
    private String sintomas;
    private String prescricao;

    public Consulta(Veterinario veterinario, Pet pet, Date data, String sintomas, String prescricao) {
        this.veterinario = veterinario;
        this.pet = pet;
        this.data = data;
        this.sintomas = sintomas;
        this.prescricao = prescricao;
    }

}
