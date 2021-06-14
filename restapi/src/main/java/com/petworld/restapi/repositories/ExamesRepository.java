package com.petworld.restapi.repositories;

import java.util.Date;
import java.util.List;

import com.petworld.restapi.entities.Exame;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ExamesRepository extends JpaRepository<Exame, Long> {
    
    List<Exame> findByAtendimentoId(Long atendimentoId);
    Page<Exame> findByAtendimentoPetId(Long petId, Pageable pageable);
    Page<Exame> findByAtendimentoDataBetweenAndAtendimentoPetId(Date start, Date end, Long petId, Pageable pageable);
    
    Exame findByIdAndAtendimentoClinicaId(Long id, Long clinicaId);
}
