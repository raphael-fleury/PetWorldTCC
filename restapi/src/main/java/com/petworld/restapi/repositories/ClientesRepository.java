package com.petworld.restapi.repositories;

import java.util.List;

import com.petworld.restapi.entities.Cliente;

import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ClientesRepository extends JpaRepository<Cliente, Long> {
    
    List<Cliente> findByNomeContainsIgnoreCaseAndClinicaId(String nome, Long clinicaId);
    Page<Cliente> findByClinicaId(Long clinicaId, Pageable pageable);
    Cliente findByIdAndClinicaId(Long id, Long clinicaId);
}
