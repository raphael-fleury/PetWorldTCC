package com.petworld.restapi.controllers;

import java.net.URI;
import java.text.ParseException;
import java.util.Date;

import javax.transaction.Transactional;
import javax.validation.Valid;

import com.petworld.restapi.models.detailed.AtendimentoDetailed;
import com.petworld.restapi.models.insert.AtendimentoInsert;
import com.petworld.restapi.models.update.AtendimentoUpdate;
import com.petworld.restapi.services.AtendimentosService;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cache.annotation.CacheEvict;
import org.springframework.cache.annotation.Cacheable;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.format.annotation.DateTimeFormat;
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
@RequestMapping("/atendimentos")
public class AtendimentosController {
    
    private final Long CLINICA_ID = 1L;

    @Autowired private AtendimentosService service;

    @PostMapping("/data")
    public Page<AtendimentoDetailed> getByDate(
        @RequestParam("date") @DateTimeFormat(pattern = "yyyy-MM-dd") Date date,
        Pageable pageable
    ) throws ParseException {
        return service.findByData(date, CLINICA_ID, pageable);
    }

    @GetMapping("/{id}")
    @Cacheable(value = "getAtendimento", key = "#id")
    public ResponseEntity<AtendimentoDetailed> getById(@PathVariable Long id) {
        var detailed = service.findById(id, CLINICA_ID);

        if (detailed == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(detailed);
    }

    @PostMapping @Transactional
    public ResponseEntity<AtendimentoDetailed> post(@RequestBody @Valid AtendimentoInsert form, UriComponentsBuilder uriBuilder) {
        var detailed = service.insert(form, CLINICA_ID);
        URI uri = uriBuilder.path("/atendimentos/{id}").buildAndExpand(detailed.getId()).toUri();
        return ResponseEntity.created(uri).body(detailed);
    }

    @PutMapping("/{id}") @Transactional
    @CacheEvict(value = "getAtendimento", key = "#id")
    public ResponseEntity<AtendimentoDetailed> put(@PathVariable Long id, @RequestBody @Valid AtendimentoUpdate form) {
        var detailed = service.update(id, CLINICA_ID, form);
        return ResponseEntity.ok(detailed);
    }

    @DeleteMapping("/{id}") @Transactional
    @CacheEvict(value = "getAtendimento", key = "#id")
    public ResponseEntity<AtendimentoDetailed> delete(@PathVariable Long id) {
        var detailed = service.delete(id, CLINICA_ID);
        return ResponseEntity.ok(detailed);
    }
}
