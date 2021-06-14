package com.petworld.restapi.services;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import com.petworld.restapi.models.detailed.AtendimentoDetailed;
import com.petworld.restapi.models.insert.AtendimentoInsert;
import com.petworld.restapi.models.response.AtendimentoResponse;
import com.petworld.restapi.models.update.AtendimentoUpdate;
import com.petworld.restapi.repositories.AtendimentosRepository;
import com.petworld.restapi.repositories.ClinicasRepository;
import com.petworld.restapi.repositories.PetsRepository;
import com.petworld.restapi.repositories.VeterinariosRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;

@Service
public class AtendimentosService {
    
    @Autowired private AtendimentosRepository repository;
    @Autowired private PetsRepository petsRepository;
    @Autowired private VeterinariosRepository veterinariosRepository;
    @Autowired private ClinicasRepository clinicasRepository;

    public AtendimentoDetailed findById(Long id, Long clinicaId) {
        var entity = repository.findByIdAndClinicaId(id, clinicaId);
        return new AtendimentoDetailed(entity);
    }

    public Page<AtendimentoDetailed> findByData(Date date, Long clinicaId, Pageable pageable) throws ParseException {
        var start = date;
        var dateFormatted = new SimpleDateFormat("yyyy-MM-dd").format(date);
        var end = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss").parse(dateFormatted + " 23:59:00");
        
        var page = repository.findByDataBetweenAndClinicaId(start, end, clinicaId, pageable);
        return AtendimentoDetailed.page(page);
    }

    public Page<AtendimentoResponse> findByVeterinario(Long veterinarioId, Long clinicaId, Pageable pageable) {
        var page = repository.findByVeterinarioIdAndClinicaId(veterinarioId, clinicaId, pageable);
        return AtendimentoResponse.page(page);
    }

    public Page<AtendimentoResponse> findByPet(Long petId, Long clinicaId, Pageable pageable) {
        var page = repository.findByPetIdAndClinicaId(petId, clinicaId, pageable);
        return AtendimentoResponse.page(page);
    }

    public AtendimentoDetailed insert(AtendimentoInsert form, Long clinicaId) {
        var entity = form.toEntity(
            (id) -> veterinariosRepository.findByIdAndClinicaId(id, clinicaId),
            (id) -> petsRepository.findByIdAndClinicaId(id, clinicaId)
        );
        var clinica = clinicasRepository.findById(clinicaId).get();
        entity.setClinica(clinica);
        return new AtendimentoDetailed(repository.save(entity));
    }

    public AtendimentoDetailed update(Long id, Long clinicaId, AtendimentoUpdate form) {
        var entity = repository.findByIdAndClinicaId(id, clinicaId);
        entity = form.update(entity);
        return new AtendimentoDetailed(repository.save(entity));
    }

    public AtendimentoDetailed delete(Long id, Long clinicaId) {
        var entity = repository.findByIdAndClinicaId(id, clinicaId);
        repository.delete(entity);
        return new AtendimentoDetailed(entity);
    }
}
