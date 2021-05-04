package com.petworld.restapi.models.insert;

import java.util.Date;

import javax.validation.constraints.Min;
import javax.validation.constraints.NotNull;

import com.petworld.restapi.entities.Consulta;
import com.petworld.restapi.repositories.PetsRepository;
import com.petworld.restapi.repositories.VeterinariosRepository;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class ConsultaInsert {
    
    @NotNull
    private Date data;
    private String sintomas;
    private String prescricao;
    
    @NotNull @Min(1)
    private Long veterinarioId;
    
    @NotNull @Min(1)
    private Long petId;
    
    public Consulta toEntity(
        VeterinariosRepository veterinariosRepository,
        PetsRepository petsRepository
    ) {
        var veterinario = veterinariosRepository.findById(veterinarioId).get();
        var pet = petsRepository.findById(petId).get();
        return new Consulta(veterinario, pet, data, sintomas, prescricao);
    }
}
