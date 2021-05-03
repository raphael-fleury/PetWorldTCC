package com.petworld.restapi.models.detailed;

import java.util.Date;
import java.util.List;

import com.petworld.restapi.entities.Consulta;
import com.petworld.restapi.entities.Pet;
import com.petworld.restapi.entities.Veterinario;

import org.springframework.data.domain.Page;

import lombok.Getter;

@Getter
public class ConsultaDetailed {
    
    private Long id;
    private Date data;
    private String sintomas;
    private String prescricao;
    
    private Veterinario veterinario;
    private Pet pet;

    public ConsultaDetailed(Consulta consulta) {
        id = consulta.getId();
        data = consulta.getData();
        sintomas = consulta.getSintomas();
        prescricao = consulta.getPrescricao();
        veterinario = consulta.getVeterinario();
        pet = consulta.getPet();
    }

    public static List<ConsultaDetailed> list(List<Consulta> entities) {
        return entities.stream().map(e -> new ConsultaDetailed(e)).toList();
    }

    public static Page<ConsultaDetailed> page(Page<Consulta> page) {
        return page.map(ConsultaDetailed::new);
    }
}
