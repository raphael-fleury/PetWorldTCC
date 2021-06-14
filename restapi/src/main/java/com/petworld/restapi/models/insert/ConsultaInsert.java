package com.petworld.restapi.models.insert;

import java.util.ArrayList;
import java.util.Date;
import java.util.function.Function;

import javax.validation.constraints.Min;
import javax.validation.constraints.NotNull;

import com.petworld.restapi.entities.Atendimento;
import com.petworld.restapi.entities.Consulta;
import com.petworld.restapi.repositories.AtendimentosRepository;
import com.petworld.restapi.repositories.PetsRepository;
import com.petworld.restapi.repositories.VeterinariosRepository;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ConsultaInsert {

    @NotNull
    private String sintomas;
    private String prescricao;
    
    @NotNull @Min(1)
    private Long atendimentoId;
    
    public Consulta toEntity(Function<Long, Atendimento> getAtendimento) {
        var atendimento = getAtendimento.apply(atendimentoId);
        return new Consulta(atendimento, sintomas, prescricao);
    }
}
