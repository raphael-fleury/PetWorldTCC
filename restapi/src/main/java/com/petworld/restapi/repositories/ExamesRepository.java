package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Exame;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ExamesRepository extends JpaRepository<Exame, Long> {
    
    Page<Exame> findByConsultaId(Long consultaId, Pageable pageable);
    Page<Exame> findByConsultaPetId(Long petId, Pageable pageable);
}
