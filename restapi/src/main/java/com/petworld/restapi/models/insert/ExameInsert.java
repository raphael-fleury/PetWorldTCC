package com.petworld.restapi.models.insert;

import java.util.ArrayList;
import java.util.Date;
import java.util.function.Function;

import javax.validation.constraints.Min;
import javax.validation.constraints.NotNull;

import com.petworld.restapi.entities.Atendimento;
import com.petworld.restapi.entities.Exame;
import com.petworld.restapi.repositories.AtendimentosRepository;
import com.petworld.restapi.repositories.PetsRepository;
import com.petworld.restapi.repositories.VeterinariosRepository;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ExameInsert {

    @NotNull
    private String nome;
    private String descricao;
    private Date dataResultado;
    
    @NotNull @Min(1)
    private Long atendimentoId;
    
    public Exame toEntity(Function<Long, Atendimento> getAtendimento) {
        var atendimento = getAtendimento.apply(atendimentoId);
        return new Exame(nome, descricao, dataResultado, atendimento);
    }
}
