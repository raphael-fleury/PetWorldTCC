package com.petworld.restapi.models.response;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

import com.petworld.restapi.entities.Atendimento;

import org.springframework.data.domain.Page;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class AtendimentoResponse {
    
    private Long id;
    private Date data;

    public AtendimentoResponse(Atendimento atendimento) {
        id = atendimento.getId();
        data = atendimento.getData();
    }

    public static List<AtendimentoResponse> list(List<Atendimento> entities) {
        return entities.stream().map(e -> new AtendimentoResponse(e)).collect(Collectors.toList());
    }

    public static Page<AtendimentoResponse> page(Page<Atendimento> page) {
        return page.map(AtendimentoResponse::new);
    }  
}
