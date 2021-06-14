package com.petworld.restapi.repositories;

import java.util.Date;
import java.util.List;

import com.petworld.restapi.entities.Vacinacao;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface VacinacaoRepository extends JpaRepository<Vacinacao, Long> {
    
    List<Vacinacao> findByAtendimentoId(Long atendimentoId);
    Page<Vacinacao> findByAtendimentoPetId(Long petId, Pageable pageable);
    Page<Vacinacao> findByAtendimentoDataBetweenAndAtendimentoPetId(Date start, Date end, Long petId, Pageable pageable);
    
    Vacinacao findByIdAndAtendimentoClinicaId(Long id, Long clinicaId);
}
