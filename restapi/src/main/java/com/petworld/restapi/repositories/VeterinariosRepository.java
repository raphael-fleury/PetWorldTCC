package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Veterinario;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface VeterinariosRepository extends JpaRepository<Veterinario, Long> {
    
    Page<Veterinario> findByClinicaId(Long clinicaId, Pageable pageable);
}
