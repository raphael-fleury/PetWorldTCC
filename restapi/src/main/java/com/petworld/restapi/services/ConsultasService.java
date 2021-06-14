package com.petworld.restapi.services;

import com.petworld.restapi.models.detailed.ConsultaDetailed;
import com.petworld.restapi.models.insert.ConsultaInsert;
import com.petworld.restapi.models.response.ConsultaResponse;
import com.petworld.restapi.models.update.ConsultaUpdate;
import com.petworld.restapi.repositories.AtendimentosRepository;
import com.petworld.restapi.repositories.ConsultasRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;

@Service
public class ConsultasService {
    
    @Autowired private ConsultasRepository repository;
    @Autowired private AtendimentosRepository atendimentosRepository;

    public ConsultaDetailed findById(Long id, Long clinicaId) {
        var entity = repository.findByIdAndAtendimentoClinicaId(id, clinicaId);
        return new ConsultaDetailed(entity);
    }

    public ConsultaResponse findByAtendimento(Long atendimentoId, Long clinicaId) {
        var entity = repository.findByAtendimentoIdAndAtendimentoClinicaId(atendimentoId, clinicaId);
        return new ConsultaResponse(entity);
    }

    public Page<ConsultaResponse> findByPet(Long petId, Long clinicaId, Pageable pageable) {
        var page = repository.findByAtendimentoPetIdAndAtendimentoClinicaId(petId, clinicaId, pageable);
        return ConsultaResponse.page(page);
    }

    public ConsultaDetailed insert(ConsultaInsert form, Long clinicaId) {
        var entity = form.toEntity((id) -> atendimentosRepository.findByIdAndClinicaId(id, clinicaId));
        return new ConsultaDetailed(repository.save(entity));
    }

    public ConsultaDetailed update(Long id, Long clinicaId, ConsultaUpdate form) {
        var entity = repository.findByIdAndAtendimentoClinicaId(id, clinicaId);
        entity = form.update(entity);
        return new ConsultaDetailed(repository.save(entity));
    }

    public ConsultaDetailed delete(Long id, Long clinicaId) {
        var entity = repository.findByIdAndAtendimentoClinicaId(id, clinicaId);
        repository.delete(entity);
        return new ConsultaDetailed(entity);
    }
}
