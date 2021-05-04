package com.petworld.restapi.controllers;

import java.net.URI;

import javax.transaction.Transactional;
import javax.validation.Valid;

import com.petworld.restapi.models.detailed.VeterinarioDetailed;
import com.petworld.restapi.models.insert.VeterinarioInsert;
import com.petworld.restapi.models.response.VeterinarioResponse;
import com.petworld.restapi.models.update.VeterinarioUpdate;
import com.petworld.restapi.repositories.VeterinariosRepository;
import com.petworld.restapi.repositories.ClinicasRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cache.annotation.CacheEvict;
import org.springframework.cache.annotation.Cacheable;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
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
@RequestMapping("/veterinarios")
public class VeterinariosController {
    
    private final Long CLINICA_ID = 1L;

    @Autowired private VeterinariosRepository repository;
    @Autowired private ClinicasRepository clinicasRepository;

    @GetMapping
    public Page<VeterinarioDetailed> getAll(Pageable pageable) {
        return VeterinarioDetailed.page(repository.findByClinicaId(CLINICA_ID, pageable));
    }

    @GetMapping("/{id}")
    @Cacheable(value = "getVeterinario", key = "#id")
    public ResponseEntity<VeterinarioDetailed> getById(@PathVariable Long id) {
        var veterinario = repository.findByIdAndClinicaId(id, CLINICA_ID);

        if (veterinario == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(new VeterinarioDetailed(veterinario));
    }

    @PostMapping @Transactional
    public ResponseEntity<VeterinarioResponse> post(@RequestBody @Valid VeterinarioInsert form, UriComponentsBuilder uriBuilder) {
        var veterinario = repository.save(form.toEntity());
        var clinica = clinicasRepository.findById(CLINICA_ID).get();

        veterinario.setClinica(clinica);

        URI uri = uriBuilder.path("/veterinarios/{id}").buildAndExpand(veterinario.getId()).toUri();
        return ResponseEntity.created(uri).body(new VeterinarioResponse(veterinario));
    }

    @PutMapping("/{id}") @Transactional
    @CacheEvict(value = "getVeterinario", key = "#id")
    public ResponseEntity<VeterinarioResponse> put(@PathVariable Long id, @RequestBody @Valid VeterinarioUpdate form) {
        var veterinario = repository.findByIdAndClinicaId(id, CLINICA_ID);

        if (veterinario == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(new VeterinarioResponse(form.update(veterinario)));
    }

    @DeleteMapping("/{id}") @Transactional
    @CacheEvict(value = "getVeterinario", key = "#id")
    public ResponseEntity<?> delete(@PathVariable Long id) {
        var veterinario = repository.findByIdAndClinicaId(id, CLINICA_ID);
        
        if (veterinario == null)
            return ResponseEntity.notFound().build();

        repository.delete(veterinario);
        return ResponseEntity.ok(new VeterinarioResponse(veterinario));
    }
}
