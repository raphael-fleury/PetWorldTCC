package com.petworld.restapi.repositories;

import java.util.List;

import com.petworld.restapi.entities.Pet;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface PetsRepository extends JpaRepository<Pet, Long> {
    
    List<Pet> findByNomeContainsIgnoreCaseAndClinicaId(String nome, Long clinicaId);
    Page<Pet> findByClinicaId(Long clinicaId, Pageable pageable);
    Pet findByIdAndClinicaId(Long id, Long clinicaId);
}
