package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Vacinacao;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface VacinacaoRepository extends JpaRepository<Vacinacao, Long> {
    
    Page<Vacinacao> findByClinicaId(Long clinicaId, Pageable pageable);
    Vacinacao findByIdAndClinicaId(Long id, Long clinicaId);
}
