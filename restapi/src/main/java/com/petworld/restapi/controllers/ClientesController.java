package com.petworld.restapi.controllers;

import com.petworld.restapi.repositories.ClientesRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class ClientesController {
    
    @Autowired
    private ClientesRepository repository;
}
