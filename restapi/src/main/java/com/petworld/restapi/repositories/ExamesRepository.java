package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Exame;

import org.springframework.data.jpa.repository.JpaRepository;

public interface ExamesRepository extends JpaRepository<Exame, Long> {
    
}
