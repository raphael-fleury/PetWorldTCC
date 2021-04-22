package com.petworld.restapi.controllers;

import java.util.List;

import com.petworld.restapi.models.PetModel;
import com.petworld.restapi.repositories.PetsRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/pets")
public class PetsController {

    @Autowired
    private PetsRepository repository;

    @GetMapping
    public List<PetModel> getAll(Long clinicaId) {
        return PetModel.list(repository.findByClinicaId(clinicaId));
    }
}
