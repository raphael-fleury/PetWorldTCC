package com.petworld.restapi.models.detailed;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

import com.petworld.restapi.entities.Atendimento;
import com.petworld.restapi.models.response.PetResponse;
import com.petworld.restapi.models.response.VeterinarioResponse;

import org.springframework.data.domain.Page;

import lombok.Getter;

@Getter
public class AtendimentoDetailed {
    
    private Long id;
    private Date data;
    
    private VeterinarioResponse veterinario;
    private PetResponse pet;

    public AtendimentoDetailed(Atendimento atendimento) {
        id = atendimento.getId();
        data = atendimento.getData();
        veterinario = new VeterinarioResponse(atendimento.getVeterinario());
        pet = new PetResponse(atendimento.getPet());
    }

    public static List<AtendimentoDetailed> list(List<Atendimento> entities) {
        return entities.stream().map(e -> new AtendimentoDetailed(e)).collect(Collectors.toList());
    }

    public static Page<AtendimentoDetailed> page(Page<Atendimento> page) {
        return page.map(AtendimentoDetailed::new);
    }
}
