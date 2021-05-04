package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Consulta;

import org.springframework.data.jpa.repository.JpaRepository;

public interface ConsultasRepository extends JpaRepository<Consulta, Long> {
    
}
