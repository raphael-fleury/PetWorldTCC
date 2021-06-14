package com.petworld.restapi.models.insert;

import java.util.Date;
import java.util.function.Function;

import javax.validation.constraints.Min;
import javax.validation.constraints.NotNull;

import com.petworld.restapi.entities.Atendimento;
import com.petworld.restapi.entities.Pet;
import com.petworld.restapi.entities.Veterinario;
import com.petworld.restapi.repositories.PetsRepository;
import com.petworld.restapi.repositories.VeterinariosRepository;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class AtendimentoInsert {
    
    @NotNull
    private Date data;
    
    @NotNull @Min(1)
    private Long veterinarioId;
    
    @NotNull @Min(1)
    private Long petId;
    
    public Atendimento toEntity(
        Function<Long, Veterinario> getVeterinario,
        Function<Long, Pet> getPet
    ) {
        var veterinario = getVeterinario.apply(veterinarioId);
        var pet = getPet.apply(petId);
        return new Atendimento(veterinario, pet, data);
    }
}
