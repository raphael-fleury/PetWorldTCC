package com.petworld.restapi.controllers;

import java.net.URI;
import java.util.List;

import com.petworld.restapi.entities.Cliente;
import com.petworld.restapi.models.ClienteForm;
import com.petworld.restapi.models.ClienteModel;
import com.petworld.restapi.repositories.ClientesRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.util.UriComponentsBuilder;

@RestController
@RequestMapping("/clientes")
public class ClientesController {
    
    @Autowired
    private ClientesRepository repository;

    @GetMapping
    public List<ClienteModel> getAll(Long clinicaId) {
        return ClienteModel.list(repository.findByClinicaId(clinicaId));
    }

    @PostMapping
    public ResponseEntity<ClienteModel> post(@RequestBody ClienteForm form, UriComponentsBuilder uriBuilder) {
        Cliente cliente = repository.save(form.toEntity());

        URI uri = uriBuilder.path("/clientes/{id}").buildAndExpand(cliente.getId()).toUri();
        return ResponseEntity.created(uri).body(new ClienteModel(cliente));
    }
}
