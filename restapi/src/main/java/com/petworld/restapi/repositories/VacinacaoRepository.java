package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Vacinacao;

import org.springframework.data.jpa.repository.JpaRepository;

public interface VacinacaoRepository extends JpaRepository<Vacinacao, Long> {
    
}
