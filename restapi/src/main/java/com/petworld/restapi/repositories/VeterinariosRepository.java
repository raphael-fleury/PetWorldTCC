package com.petworld.restapi.repositories;

import java.util.List;

import com.petworld.restapi.entities.Veterinario;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface VeterinariosRepository extends JpaRepository<Veterinario, Long> {
    
    List<Veterinario> findByNomeContainsIgnoreCaseAndClinicaId(String nome, Long clinicaId);
    Page<Veterinario> findByClinicaId(Long clinicaId, Pageable pageable);
    Veterinario findByIdAndClinicaId(Long id, Long clinicaId);
}
