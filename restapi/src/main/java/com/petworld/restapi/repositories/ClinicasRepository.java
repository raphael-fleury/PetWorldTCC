package com.petworld.restapi.repositories;

import com.petworld.restapi.entities.Clinica;

import org.springframework.data.jpa.repository.JpaRepository;

public interface ClinicasRepository extends JpaRepository<Clinica, Long> {
    
    public Clinica findByCodigoAndSenha(String codigo, String senha);
    public Boolean existsByCodigo(String codigo);
}
