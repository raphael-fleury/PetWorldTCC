package com.petworld.restapi.controllers;

import java.net.URI;

import javax.transaction.Transactional;
import javax.validation.Valid;

import com.petworld.restapi.entities.Cliente;
import com.petworld.restapi.entities.Clinica;
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

    @Autowired
    private ClientesRepository repository;

    @Autowired
    private ClinicasRepository clinicasRepository;

    @GetMapping
    @Cacheable(value = "getClientes")
    public Page<ClienteResponse> getAll(Pageable pageable) {
        return ClienteResponse.page(repository.findByClinicaId(CLINICA_ID, pageable));
    }

    @GetMapping("/{id}")
    public ResponseEntity<ClienteDetailed> getById(@PathVariable Long id) {
        var cliente = findByIdAndClinica(id, CLINICA_ID);

        if (cliente == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(new ClienteDetailed(cliente));
    }

    @PostMapping @Transactional
    @CacheEvict(value = "getClientes", allEntries = true)
    public ResponseEntity<ClienteResponse> post(@RequestBody @Valid ClienteInsert form, UriComponentsBuilder uriBuilder) {
        Cliente cliente = repository.save(form.toEntity());
        Clinica clinica = clinicasRepository.findById(CLINICA_ID).get();

        cliente.setClinica(clinica);

        URI uri = uriBuilder.path("/clientes/{id}").buildAndExpand(cliente.getId()).toUri();
        return ResponseEntity.created(uri).body(new ClienteResponse(cliente));
    }

    @PutMapping("/{id}") @Transactional
    @CacheEvict(value = "getClientes", allEntries = true)
    public ResponseEntity<ClienteResponse> put(@PathVariable Long id, @RequestBody @Valid ClienteUpdate form) {
        Cliente cliente = findByIdAndClinica(id, CLINICA_ID);

        if (cliente == null)
            return ResponseEntity.notFound().build();

        return ResponseEntity.ok(new ClienteResponse(form.update(cliente)));
    }

    @DeleteMapping("/{id}") @Transactional
    @CacheEvict(value = "getClientes", allEntries = true)
    public ResponseEntity<?> delete(@PathVariable Long id) {
        Cliente cliente = findByIdAndClinica(id, CLINICA_ID);
        
        if (cliente == null)
            return ResponseEntity.notFound().build();

        repository.delete(cliente);
        return ResponseEntity.ok(new ClienteResponse(cliente));
    }

    private Cliente findByIdAndClinica(Long id, Long clinicaId) {
        var optional = repository.findById(id);

        if (!optional.isPresent() || optional.get().getClinica().getId() != clinicaId)
            return null;
        
        return optional.get();
    }
}
