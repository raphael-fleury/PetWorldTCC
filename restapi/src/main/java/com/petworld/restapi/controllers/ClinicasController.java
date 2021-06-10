package com.petworld.restapi.controllers;

import com.petworld.restapi.repositories.ClinicasRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class ClinicasController {
    
    @Autowired
    private ClinicasRepository repository;
}
