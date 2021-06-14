package com.petworld.restapi.repositories;

import java.util.Date;

import com.petworld.restapi.entities.Atendimento;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface AtendimentosRepository extends JpaRepository<Atendimento, Long> {
    
    Page<Atendimento> findByVeterinarioIdAndClinicaId(Long veterinarioId, Long clinicaId, Pageable pageable);
    Page<Atendimento> findByPetIdAndClinicaId(Long petId, Long clinicaId, Pageable pageable);
    Page<Atendimento> findByDataBetweenAndClinicaId(Date start, Date end, Long clinicaId, Pageable pageable);

    Atendimento findByIdAndClinicaId(Long id, Long clinicaId);
}
