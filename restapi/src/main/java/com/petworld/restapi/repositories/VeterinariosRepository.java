package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Veterinario;

import org.springframework.data.jpa.repository.JpaRepository;

public interface VeterinariosRepository extends JpaRepository<Veterinario, Long> {
    
}
