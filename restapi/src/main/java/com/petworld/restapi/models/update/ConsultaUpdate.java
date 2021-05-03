package com.petworld.restapi.models.update;

import java.util.Date;

import com.petworld.restapi.entities.Consulta;

public class ConsultaUpdate {
    
    private Date data;
    private String sintomas;
    private String prescricao;

    public Consulta update(Consulta entity) {
        entity.setData(data);
        entity.setSintomas(sintomas);
        entity.setPrescricao(prescricao);

        return entity;
    }
}
