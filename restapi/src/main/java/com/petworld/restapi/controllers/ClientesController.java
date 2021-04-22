package com.petworld.restapi.controllers;

import java.util.List;

import com.petworld.restapi.models.ClienteModel;
import com.petworld.restapi.repositories.ClientesRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/clientes")
public class ClientesController {
    
    @Autowired
    private ClientesRepository repository;

    @GetMapping
    public List<ClienteModel> getAll(Long clinicaId) {
        return ClienteModel.list(repository.findByClinicaId(clinicaId));
    }
}
