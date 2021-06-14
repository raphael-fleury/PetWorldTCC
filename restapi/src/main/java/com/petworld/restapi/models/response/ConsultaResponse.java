package com.petworld.restapi.models.response;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

import com.petworld.restapi.entities.Consulta;

import org.springframework.data.domain.Page;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ConsultaResponse {
    
    private Long id;
    private Long atendimentoId;
    private Date data;
    private String sintomas;
    private String prescricao;

    public ConsultaResponse(Consulta consulta) {
        id = consulta.getId();
        atendimentoId = consulta.getAtendimento().getId();
        data = consulta.getAtendimento().getData();
        sintomas = consulta.getSintomas();
        prescricao = consulta.getPrescricao();
    }

    public static List<ConsultaResponse> list(List<Consulta> entities) {
        return entities.stream().map(e -> new ConsultaResponse(e)).collect(Collectors.toList());
    }

    public static Page<ConsultaResponse> page(Page<Consulta> page) {
        return page.map(ConsultaResponse::new);
    }  
}
