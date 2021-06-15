package com.petworld.restapi.models.response;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

import com.petworld.restapi.entities.Exame;

import org.springframework.data.domain.Page;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ExameResponse {
    
    private Long id;
    private Long atendimentoId;
    private Date data;
    private String nome;
    private String descricao;
    private Date dataResultado;

    public ExameResponse(Exame exame) {
        id = exame.getId();
        atendimentoId = exame.getAtendimento().getId();
        data = exame.getAtendimento().getData();
        nome = exame.getNome();
        descricao = exame.getDescricao();
        dataResultado = exame.getDataResultado();
    }

    public static List<ExameResponse> list(List<Exame> entities) {
        return entities.stream().map(e -> new ExameResponse(e)).collect(Collectors.toList());
    }

    public static Page<ExameResponse> page(Page<Exame> page) {
        return page.map(ExameResponse::new);
    }  
}
