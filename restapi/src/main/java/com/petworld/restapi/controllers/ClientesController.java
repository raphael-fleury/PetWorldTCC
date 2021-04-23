package com.petworld.restapi.controllers;

import java.net.URI;
import java.util.List;

import javax.validation.Valid;

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
    
    private final Long CLINICA_ID = 1L;

    @Autowired
    private ClientesRepository repository;

    @GetMapping
    public List<ClienteModel> getAll() {
        return ClienteModel.list(repository.findByClinicaId(CLINICA_ID));
    }

    @PostMapping
    public ResponseEntity<ClienteModel> post(@RequestBody @Valid ClienteForm form, UriComponentsBuilder uriBuilder) {
        Cliente cliente = repository.save(form.toEntity());

        URI uri = uriBuilder.path("/clientes/{id}").buildAndExpand(cliente.getId()).toUri();
        return ResponseEntity.created(uri).body(new ClienteModel(cliente));
    }


}
