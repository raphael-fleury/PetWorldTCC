package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Consulta;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ConsultasRepository extends JpaRepository<Consulta, Long> {
    
    Page<Consulta> findByVeterinarioId(Long veterinarioId, Pageable pageable);
    Page<Consulta> findByPetId(Long petId, Pageable pageable);

    Consulta findByIdAndClinicaId(Long id, Long clinicaId);
}
