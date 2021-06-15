package com.petworld.restapi.models.update;

import java.util.Date;

import javax.validation.constraints.NotNull;

import com.petworld.restapi.entities.Exame;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ExameUpdate {
    
    private String nome;
    private String descricao;
    private Date dataResultado;

    public Exame update(Exame entity) {
        entity.setNome(nome);
        entity.setDescricao(descricao);
        entity.setDataResultado(dataResultado);

        return entity;
    }
}
