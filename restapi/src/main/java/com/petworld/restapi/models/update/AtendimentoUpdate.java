package com.petworld.restapi.models.update;

import java.util.Date;

import javax.validation.constraints.NotNull;

import com.petworld.restapi.entities.Atendimento;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class AtendimentoUpdate {
    
    @NotNull
    private Date data;

    public Atendimento update(Atendimento entity) {
        entity.setData(data);
        return entity;
    }
}
