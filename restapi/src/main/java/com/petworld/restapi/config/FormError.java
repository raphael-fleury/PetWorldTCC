package com.petworld.restapi.config;

import lombok.AllArgsConstructor;
import lombok.Getter;

@Getter @AllArgsConstructor
public class FormError {
    
    private String field;
    private String error;
}
