package com.petworld.restapi.models.update;

import java.util.Date;

import javax.validation.constraints.NotNull;

import com.petworld.restapi.entities.Consulta;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ConsultaUpdate {
    
    private String sintomas;
    private String prescricao;

    public Consulta update(Consulta entity) {
        entity.setSintomas(sintomas);
        entity.setPrescricao(prescricao);

        return entity;
    }
}
