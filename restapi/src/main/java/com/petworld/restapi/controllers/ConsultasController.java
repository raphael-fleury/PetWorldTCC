package com.petworld.restapi.controllers;

import java.net.URI;

import javax.transaction.Transactional;
import javax.validation.Valid;

import com.petworld.restapi.models.detailed.ConsultaDetailed;
import com.petworld.restapi.models.insert.ConsultaInsert;
import com.petworld.restapi.models.response.ConsultaResponse;
import com.petworld.restapi.models.update.ConsultaUpdate;
import com.petworld.restapi.repositories.PetsRepository;
import com.petworld.restapi.repositories.VeterinariosRepository;
import com.petworld.restapi.repositories.ClinicasRepository;
import com.petworld.restapi.repositories.ConsultasRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cache.annotation.CacheEvict;
import org.springframework.cache.annotation.Cacheable;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.util.UriComponentsBuilder;

@RestController
@RequestMapping("/consultas")
public class ConsultasController {
    
    private final Long CLINICA_ID = 1L;

    @Autowired
    private ConsultasRepository repository;

    @Autowired
    private ClinicasRepository clinicasRepository;

    @Autowired
    private VeterinariosRepository veterinariosRepository;

    @Autowired
    private PetsRepository petsRepository;

    @GetMapping("/{id}")
    @Cacheable(value = "getConsulta", key = "#id")
    public ResponseEntity<ConsultaDetailed> getById(@PathVariable Long id) {
        var consulta = repository.findByIdAndClinicaId(id, CLINICA_ID);

        if (consulta == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(new ConsultaDetailed(consulta));
    }

    @PostMapping @Transactional
    public ResponseEntity<?> post(@RequestBody @Valid ConsultaInsert form, UriComponentsBuilder uriBuilder) { 
        var veterinario = veterinariosRepository.findByIdAndClinicaId(form.getVeterinarioId(), CLINICA_ID);
        var pet = petsRepository.findByIdAndClinicaId(form.getPetId(), CLINICA_ID);
        var clinica = clinicasRepository.findById(CLINICA_ID).get();

        if (veterinario == null || pet == null || clinica == null)
            return ResponseEntity.notFound().build();
        
        var consulta = form.toEntity(veterinariosRepository, petsRepository);
        consulta.setClinica(clinica);

        URI uri = uriBuilder.path("/consultas/{id}").buildAndExpand(consulta.getId()).toUri();
        return ResponseEntity.created(uri).body(new ConsultaResponse(consulta));
    }

    @PutMapping("/{id}") @Transactional
    @CacheEvict(value = "getConsulta", key = "#id")
    public ResponseEntity<ConsultaResponse> put(@PathVariable Long id, @RequestBody @Valid ConsultaUpdate form) {
        var consulta = repository.findByIdAndClinicaId(id, CLINICA_ID);

        if (consulta == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(new ConsultaResponse(form.update(consulta)));
    }

    @DeleteMapping("/{id}") @Transactional
    @CacheEvict(value = "getConsulta", key = "#id")
    public ResponseEntity<?> delete(@PathVariable Long id) {
        var consulta = repository.findByIdAndClinicaId(id, CLINICA_ID);
        
        if (consulta == null)
            return ResponseEntity.notFound().build();

        repository.delete(consulta);
        return ResponseEntity.ok(new ConsultaResponse(consulta));
    }
}
