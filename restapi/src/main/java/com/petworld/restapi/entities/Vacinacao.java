package com.petworld.restapi.entities;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.ManyToOne;

import lombok.AllArgsConstructor;
import lombok.Data;

@Entity @Data
@AllArgsConstructor
public class Vacinacao {
    
    @ManyToOne
    private Atendimento atendimento;

    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String vacina;
    private String detalhes;

}
