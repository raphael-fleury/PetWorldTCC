package com.petworld.restapi.controllers;

import java.net.URI;

import javax.transaction.Transactional;
import javax.validation.Valid;

import com.petworld.restapi.models.detailed.ExameDetailed;
import com.petworld.restapi.models.insert.ExameInsert;
import com.petworld.restapi.models.update.ExameUpdate;
import com.petworld.restapi.services.ExamesService;

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
@RequestMapping("/exames")
public class ExamesController {
    
    private final Long CLINICA_ID = 1L;

    @Autowired private ExamesService service;

    @GetMapping("/{id}")
    @Cacheable(value = "getExame", key = "#id")
    public ResponseEntity<ExameDetailed> getById(@PathVariable Long id) {
        var detailed = service.findById(id, CLINICA_ID);

        if (detailed == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(detailed);
    }

    @PostMapping @Transactional
    public ResponseEntity<ExameDetailed> post(@RequestBody @Valid ExameInsert form, UriComponentsBuilder uriBuilder) { 
        var detailed = service.insert(form, CLINICA_ID);
        URI uri = uriBuilder.path("/exames/{id}").buildAndExpand(detailed.getId()).toUri();
        return ResponseEntity.created(uri).body(detailed);
    }

    @PutMapping("/{id}") @Transactional
    @CacheEvict(value = "getExame", key = "#id")
    public ResponseEntity<ExameDetailed> put(@PathVariable Long id, @RequestBody @Valid ExameUpdate form) {
        var detailed = service.update(id, CLINICA_ID, form);
        return ResponseEntity.ok(detailed);
    }

    @DeleteMapping("/{id}") @Transactional
    @CacheEvict(value = "getExame", key = "#id")
    public ResponseEntity<ExameDetailed> delete(@PathVariable Long id) {
        var detailed = service.delete(id, CLINICA_ID);
        return ResponseEntity.ok(detailed);
    }
}
