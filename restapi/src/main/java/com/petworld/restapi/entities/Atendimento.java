package com.petworld.restapi.entities;

import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.ManyToOne;
import javax.persistence.OneToOne;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity @Data
@NoArgsConstructor @AllArgsConstructor
public class Atendimento {
    
    @ManyToOne private Clinica clinica;
    @ManyToOne private Veterinario veterinario;
    @ManyToOne private Pet pet;

    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private Date data;

    public Atendimento(Veterinario veterinario, Pet pet, Date data) {
        this.clinica = veterinario.getClinica();
        this.veterinario = veterinario;
        this.pet = pet;
        this.data = data;
    }

}
