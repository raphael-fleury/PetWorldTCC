package com.petworld.restapi.repositories;

import java.util.List;

import com.petworld.restapi.entities.Pet;

import org.springframework.data.jpa.repository.JpaRepository;

public interface PetsRepository extends JpaRepository<Pet, Long> {
    
    List<Pet> findByClinicaId(Long clinicaId);
}
