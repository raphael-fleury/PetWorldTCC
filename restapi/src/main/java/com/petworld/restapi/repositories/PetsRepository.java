package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Pet;

import org.springframework.data.jpa.repository.JpaRepository;

public interface PetsRepository extends JpaRepository<Pet, Long> {
    
}
