package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Cliente;

import org.springframework.data.jpa.repository.JpaRepository;

public interface ClientesRepository extends JpaRepository<Cliente, Long> {
    
}
