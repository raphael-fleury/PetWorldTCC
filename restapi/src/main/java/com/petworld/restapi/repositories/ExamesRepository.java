package com.petworld.restapi.repositories;

import java.util.List;

import com.petworld.restapi.entities.Exame;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ExamesRepository extends JpaRepository<Exame, Long> {
    
    List<Exame> findByAtendimentoIdAndAtendimentoClinicaId(Long atendimentoId, Long clinicaId);
    Page<Exame> findByAtendimentoPetIdAndAtendimentoClinicaId(Long petId, Long clinicaId, Pageable pageable);
    
    Exame findByIdAndAtendimentoClinicaId(Long id, Long clinicaId);
}
