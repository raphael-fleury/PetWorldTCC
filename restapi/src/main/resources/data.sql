-- 1
INSERT INTO CLINICA(nome) VALUES('Petz');

INSERT INTO CLIENTE(nome, email, endereco, telefone, clinica_id) VALUES('Manoel Siqueira', 'manoelsiqueira@gmail.com', 'Rua Batista Pereira, 32 - Santos/SP', '13981446177', 1);
INSERT INTO CLIENTE(nome, email, endereco, telefone, clinica_id) VALUES('Laura Alves', 'lalves@gmail.com', 'Rua Ver. Henrique Soler, 64 - Santos/SP', '13981564787', 1);
INSERT INTO CLIENTE(nome, email, endereco, telefone, clinica_id) VALUES('José Damasceno', 'jdamasceno3@gmail.com', 'Rua Rangel Pestana, 4 - São Vicente/SP', '13981334617', 1);
INSERT INTO CLIENTE(nome, email, endereco, telefone, clinica_id) VALUES('Mariella Campos', 'maricampos@outlook.com', 'Rua Dona Ana Nery, 50 - Santos/SP', '13981956194', 1);

INSERT INTO PET(nome, especie, raca, sexo, castrado, clinica_id, dono_id) VALUES('Rex', 'Cachorro', 'Labrador', 'MASCULINO', true, 1, 1);
INSERT INTO PET(nome, especie, raca, sexo, castrado, clinica_id, dono_id) VALUES('Mel', 'Gato', '', 'FEMININO', true, 1, 2);
INSERT INTO PET(nome, especie, raca, sexo, castrado, clinica_id, dono_id) VALUES('Tonkay', 'Gato', '', 'MASCULINO', false, 1, 3);
INSERT INTO PET(nome, especie, raca, sexo, castrado, clinica_id, dono_id) VALUES('José', 'Papagaio', '', 'MASCULINO', false, 1, 4);

-- 2
INSERT INTO CLINICA(nome) VALUES('Castro Alves');

INSERT INTO CLIENTE(nome, email, endereco, telefone, clinica_id) VALUES('João Luiz', 'joaoluiz@gmail.com', 'Rua Santos Dumont, 114 - Santos/SP', '13981578178', 2);
INSERT INTO PET(nome, especie, raca, sexo, castrado, clinica_id, dono_id) VALUES('Thor', 'Cachorro', 'Vira lata', 'MASCULINO', true, 2, 5);
INSERT INTO PET(nome, especie, raca, sexo, castrado, clinica_id, dono_id) VALUES('Mia', 'Gato', '', 'FEMININO', true, 2, 5);