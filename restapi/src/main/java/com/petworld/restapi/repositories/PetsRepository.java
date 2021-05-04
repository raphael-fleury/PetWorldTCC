package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Pet;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface PetsRepository extends JpaRepository<Pet, Long> {
    
    Page<Pet> findByClinicaId(Long clinicaId, Pageable pageable);
    Pet findByIdAndClinicaId(Long id, Long clinicaId);
}
