package com.petworld.restapi.controllers;

import java.net.URI;
import java.util.List;

import javax.validation.Valid;

import com.petworld.restapi.entities.Pet;
import com.petworld.restapi.models.PetForm;
import com.petworld.restapi.models.PetModel;
import com.petworld.restapi.repositories.ClientesRepository;
import com.petworld.restapi.repositories.PetsRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.util.UriComponentsBuilder;

@RestController
@RequestMapping("/pets")
public class PetsController {

    private final Long CLINICA_ID = 1L;

    @Autowired
    private PetsRepository repository;

    @Autowired
    private ClientesRepository clientesRepository;

    @GetMapping
    public List<PetModel> getAll() {
        return PetModel.list(repository.findByClinicaId(CLINICA_ID));
    }

    @PostMapping
    public ResponseEntity<PetModel> post(@RequestBody @Valid PetForm form, UriComponentsBuilder uriBuilder) {
        Pet pet = repository.save(form.toEntity(clientesRepository));

        URI uri = uriBuilder.path("/pets/{id}").buildAndExpand(pet.getId()).toUri();
        return ResponseEntity.created(uri).body(new PetModel(pet));
    }
}
