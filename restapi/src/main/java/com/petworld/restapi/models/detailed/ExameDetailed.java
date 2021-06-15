package com.petworld.restapi.models.detailed;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

import com.petworld.restapi.entities.Exame;
import com.petworld.restapi.models.response.PetResponse;
import com.petworld.restapi.models.response.VeterinarioResponse;

import org.springframework.data.domain.Page;

import lombok.Getter;

@Getter
public class ExameDetailed {
    
    private Long id;
    private Date data;
    private String nome;
    private String descricao;
    private Date dataResultado;
    
    private VeterinarioResponse veterinario;
    private PetResponse pet;

    public ExameDetailed(Exame exame) {
        id = exame.getId();
        data = exame.getAtendimento().getData();
        nome = exame.getNome();
        descricao = exame.getDescricao();
        dataResultado = exame.getDataResultado();
        veterinario = new VeterinarioResponse(exame.getAtendimento().getVeterinario());
        pet = new PetResponse(exame.getAtendimento().getPet());
    }

    public static List<ExameDetailed> list(List<Exame> entities) {
        return entities.stream().map(e -> new ExameDetailed(e)).collect(Collectors.toList());
    }

    public static Page<ExameDetailed> page(Page<Exame> page) {
        return page.map(ExameDetailed::new);
    }
}
