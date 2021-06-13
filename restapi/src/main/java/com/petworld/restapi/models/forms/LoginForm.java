package com.petworld.restapi.models.forms;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.Size;

import lombok.Getter;
import lombok.Setter;

@Getter @Setter
public class LoginForm {
   
    @NotBlank
    private String codigo;

    @Size(min = 6, max = 24)
    private String senha;
}
