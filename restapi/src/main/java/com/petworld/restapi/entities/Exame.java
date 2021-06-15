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
public class Exame {
    
    @ManyToOne
    private Atendimento atendimento;

    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String nome;
    private String descricao;
    private Date dataResultado;
    
    public Exame(String nome, String descricao, Date dataResultado, Atendimento atendimento) {
        this.nome = nome;
        this.descricao = descricao;
        this.dataResultado = dataResultado;
        this.atendimento = atendimento;
    }
}
