package com.petworld.restapi.controllers;

import java.net.URI;
import java.util.List;

import javax.transaction.Transactional;
import javax.validation.Valid;

import com.petworld.restapi.models.detailed.ClienteDetailed;
import com.petworld.restapi.models.insert.ClienteInsert;
import com.petworld.restapi.models.response.ClienteResponse;
import com.petworld.restapi.models.update.ClienteUpdate;
import com.petworld.restapi.repositories.ClientesRepository;
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
@RequestMapping("/clientes")
public class ClientesController {
    
    private final Long CLINICA_ID = 1L;

    @Autowired private ClientesRepository repository;
    @Autowired private ClinicasRepository clinicasRepository;

    @GetMapping
    public Page<ClienteDetailed> getAll(Pageable pageable) {
        return ClienteDetailed.page(repository.findByClinicaId(CLINICA_ID, pageable));
    }

    @GetMapping("/nome/{nome}")
    public List<ClienteDetailed> getByName(@PathVariable String nome) {
        return ClienteDetailed.list(repository.findByNomeContainsIgnoreCaseAndClinicaId(nome, CLINICA_ID));
    }

    @GetMapping("/{id}")
    @Cacheable(value = "getCliente", key = "#id")
    public ResponseEntity<ClienteDetailed> getById(@PathVariable Long id) {
        var cliente = repository.findByIdAndClinicaId(id, CLINICA_ID);

        if (cliente == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(new ClienteDetailed(cliente));
    }

    @PostMapping @Transactional
    public ResponseEntity<ClienteResponse> post(@RequestBody @Valid ClienteInsert form, UriComponentsBuilder uriBuilder) {
        var cliente = repository.save(form.toEntity());
        var clinica = clinicasRepository.findById(CLINICA_ID).get();

        cliente.setClinica(clinica);

        URI uri = uriBuilder.path("/clientes/{id}").buildAndExpand(cliente.getId()).toUri();
        return ResponseEntity.created(uri).body(new ClienteResponse(cliente));
    }

    @PutMapping("/{id}") @Transactional
    @CacheEvict(value = "getCliente", key = "#id")
    public ResponseEntity<ClienteResponse> put(@PathVariable Long id, @RequestBody @Valid ClienteUpdate form) {
        var cliente = repository.findByIdAndClinicaId(id, CLINICA_ID);

        if (cliente == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(new ClienteResponse(form.update(cliente)));
    }

    @DeleteMapping("/{id}") @Transactional
    @CacheEvict(value = "getCliente", key = "#id")
    public ResponseEntity<?> delete(@PathVariable Long id) {
        var cliente = repository.findByIdAndClinicaId(id, CLINICA_ID);
        
        if (cliente == null)
            return ResponseEntity.notFound().build();

        repository.delete(cliente);
        return ResponseEntity.ok(new ClienteResponse(cliente));
    }
}
