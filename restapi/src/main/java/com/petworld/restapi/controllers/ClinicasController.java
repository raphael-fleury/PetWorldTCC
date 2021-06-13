package com.petworld.restapi.controllers;

import javax.validation.Valid;

import com.petworld.restapi.models.forms.LoginForm;
import com.petworld.restapi.models.insert.ClinicaInsert;
import com.petworld.restapi.repositories.ClinicasRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class ClinicasController {
    
    @Autowired
    private ClinicasRepository repository;

    @PostMapping("/login")
    public ResponseEntity<Long> login(@RequestBody @Valid LoginForm form) {
        var clinica = repository.findByCodigoAndSenha(form.getCodigo(), form.getSenha());
        return clinica != null ? ResponseEntity.ok(clinica.getId()) : ResponseEntity.notFound().build();
    }

    @PostMapping("/registrar")
    public ResponseEntity<String> registrar(@RequestBody @Valid ClinicaInsert form) {
        var clinica = repository.save(form.toEntity(repository));
        return ResponseEntity.ok(clinica.getCodigo());
    }
}
