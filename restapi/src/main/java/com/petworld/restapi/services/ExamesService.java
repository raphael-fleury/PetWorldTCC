package com.petworld.restapi.services;

import java.util.List;

import com.petworld.restapi.models.detailed.ExameDetailed;
import com.petworld.restapi.models.insert.ExameInsert;
import com.petworld.restapi.models.response.ExameResponse;
import com.petworld.restapi.models.update.ExameUpdate;
import com.petworld.restapi.repositories.AtendimentosRepository;
import com.petworld.restapi.repositories.ExamesRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;

@Service
public class ExamesService {
    
    @Autowired private ExamesRepository repository;
    @Autowired private AtendimentosRepository atendimentosRepository;

    public ExameDetailed findById(Long id, Long clinicaId) {
        var entity = repository.findByIdAndAtendimentoClinicaId(id, clinicaId);
        return new ExameDetailed(entity);
    }

    public List<ExameResponse> findByAtendimento(Long atendimentoId, Long clinicaId) {
        var list = repository.findByAtendimentoIdAndAtendimentoClinicaId(atendimentoId, clinicaId);
        return ExameResponse.list(list);
    }

    public Page<ExameResponse> findByPet(Long petId, Long clinicaId, Pageable pageable) {
        var page = repository.findByAtendimentoPetIdAndAtendimentoClinicaId(petId, clinicaId, pageable);
        return ExameResponse.page(page);
    }

    public ExameDetailed insert(ExameInsert form, Long clinicaId) {
        var entity = form.toEntity((id) -> atendimentosRepository.findByIdAndClinicaId(id, clinicaId));
        return new ExameDetailed(repository.save(entity));
    }

    public ExameDetailed update(Long id, Long clinicaId, ExameUpdate form) {
        var entity = repository.findByIdAndAtendimentoClinicaId(id, clinicaId);
        entity = form.update(entity);
        return new ExameDetailed(repository.save(entity));
    }

    public ExameDetailed delete(Long id, Long clinicaId) {
        var entity = repository.findByIdAndAtendimentoClinicaId(id, clinicaId);
        repository.delete(entity);
        return new ExameDetailed(entity);
    }
}
