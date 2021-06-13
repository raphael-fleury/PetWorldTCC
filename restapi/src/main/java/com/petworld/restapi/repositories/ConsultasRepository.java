package com.petworld.restapi.repositories;

import java.util.Date;

import com.petworld.restapi.entities.Consulta;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ConsultasRepository extends JpaRepository<Consulta, Long> {
    
    Page<Consulta> findByVeterinarioId(Long veterinarioId, Pageable pageable);
    Page<Consulta> findByPetId(Long petId, Pageable pageable);
    Page<Consulta> findByDataBetweenAndClinicaId(Date start, Date end, Long clinicaId, Pageable pageable);

    Consulta findByIdAndClinicaId(Long id, Long clinicaId);
}
