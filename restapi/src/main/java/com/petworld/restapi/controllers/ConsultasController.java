package com.petworld.restapi.controllers;

import java.net.URI;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

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
@RequestMapping("/consultas")
public class ConsultasController {
    
    private final Long CLINICA_ID = 1L;

    @Autowired private ConsultasRepository repository;
    @Autowired private ClinicasRepository clinicasRepository;
    @Autowired private VeterinariosRepository veterinariosRepository;
    @Autowired private PetsRepository petsRepository;

    @PostMapping("/data")
    public Page<ConsultaDetailed> getByDate(
        @RequestParam("date") @DateTimeFormat(pattern = "yyyy-MM-dd") Date date,
        Pageable pageable
    ) throws ParseException {
        var start = date;
        var dateFormatted = new SimpleDateFormat("yyyy-MM-dd").format(date);
        var end = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss").parse(dateFormatted + " 23:59:00");
        return ConsultaDetailed.page(repository.findByDataBetweenAndClinicaId(start, end, CLINICA_ID, pageable));
    }

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
        
        if (veterinario == null || pet == null)
            return ResponseEntity.notFound().build();
        
        var consulta = form.toEntity(veterinariosRepository, petsRepository);   
        var clinica = clinicasRepository.findById(CLINICA_ID).get();
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
