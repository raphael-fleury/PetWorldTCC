package com.petworld.restapi.controllers;

import com.petworld.restapi.repositories.PetsRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class PetsController {
    
    @Autowired
    private PetsRepository repository;
}
