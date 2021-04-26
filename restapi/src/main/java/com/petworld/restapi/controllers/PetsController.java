package com.petworld.restapi.controllers;

import java.net.URI;

import javax.transaction.Transactional;
import javax.validation.Valid;
import javax.validation.constraints.Min;

import com.petworld.restapi.entities.Clinica;
import com.petworld.restapi.entities.Pet;
import com.petworld.restapi.models.detailed.PetDetailed;
import com.petworld.restapi.models.insert.PetInsert;
import com.petworld.restapi.models.response.PetResponse;
import com.petworld.restapi.models.update.PetUpdate;
import com.petworld.restapi.repositories.ClientesRepository;
import com.petworld.restapi.repositories.ClinicasRepository;
import com.petworld.restapi.repositories.PetsRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Pageable;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
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

    @Autowired
    private ClinicasRepository clinicasRepository;

    @GetMapping
    public Page<PetResponse> getAll(Pageable pageable) {
        return PetResponse.page(repository.findByClinicaId(CLINICA_ID, pageable));
    }

    @GetMapping("/{id}")
    public ResponseEntity<PetDetailed> getById(@PathVariable Long id) {
        Pet pet = findByIdAndClinica(id, CLINICA_ID);

        if (pet == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(new PetDetailed(pet));
    }

    @PostMapping @Transactional
    public ResponseEntity<PetResponse> post(@RequestBody @Valid PetInsert form, UriComponentsBuilder uriBuilder) {
        Pet pet = repository.save(form.toEntity(clientesRepository));
        Clinica clinica = clinicasRepository.findById(CLINICA_ID).get();

        pet.setClinica(clinica);

        URI uri = uriBuilder.path("/pets/{id}").buildAndExpand(pet.getId()).toUri();
        return ResponseEntity.created(uri).body(new PetResponse(pet));
    }

    @PutMapping("/{id}") @Transactional
    public ResponseEntity<PetResponse> put(@PathVariable Long id, @RequestBody @Valid PetUpdate form) {
        Pet pet = findByIdAndClinica(id, CLINICA_ID);

        if (pet == null)
            return ResponseEntity.notFound().build();
        
        return ResponseEntity.ok(new PetResponse(form.update(pet)));
    }

    @DeleteMapping("/{id}") @Transactional
    public ResponseEntity<?> delete(@PathVariable Long id) {
        Pet pet = findByIdAndClinica(id, CLINICA_ID);

        if (pet == null)
            return ResponseEntity.notFound().build();
        
        repository.delete(pet);
        return ResponseEntity.ok(new PetResponse(pet));
    }

    private Pet findByIdAndClinica(Long id, Long clinicaId) {
        var optional = repository.findById(id);

        if (!optional.isPresent() || optional.get().getClinica().getId() != clinicaId)
            return null;

        return optional.get();
    }
}
