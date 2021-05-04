-- 1
INSERT INTO CLINICA(nome) VALUES('Petz');

INSERT INTO CLIENTE(nome, email, endereco, telefone, clinica_id) VALUES
('Manoel Siqueira', 'manoelsiqueira@gmail.com', 'Rua Batista Pereira, 32 - Santos/SP', '13981446177', 1),
('Laura Alves', 'lalves@gmail.com', 'Rua Ver. Henrique Soler, 64 - Santos/SP', '13981564787', 1),
('José Damasceno', 'jdamasceno3@gmail.com', 'Rua Rangel Pestana, 4 - São Vicente/SP', '13981334617', 1),
('Mariella Campos', 'maricampos@outlook.com', 'Rua Dona Ana Nery, 50 - Santos/SP', '13981956194', 1);

INSERT INTO PET(nome, especie, raca, sexo, castrado, clinica_id, dono_id) VALUES
('Rex', 'Cachorro', 'Labrador', 'MASCULINO', true, 1, 1),
('Mel', 'Gato', '', 'FEMININO', true, 1, 2),
('Tonkay', 'Gato', '', 'MASCULINO', false, 1, 3),
('José', 'Papagaio', '', 'MASCULINO', false, 1, 4);

INSERT INTO VETERINARIO(nome, email, endereco, telefone, clinica_id) VALUES
('Doctor Rey', 'drrey@petz.com.br', 'Rua João Caetano, 112 - Santos/SP', '13971456868', 1),
('Marco dos Anjos', 'mdosanjos@petz.com.br', 'Rua Teixeira de Freitas, 215 - Santos/SP', '1391567777', 1);

INSERT INTO CONSULTA(data, prescricao, sintomas, clinica_id, pet_id, veterinario_id) VALUES
('2022-05-21 16:30:00', 'Dipirona kkkkk', 'Espirro', 1, 1, 1),
('2021-01-13 15:00:00', 'Antibiotico', 'Coceira', 1, 2, 2);

INSERT INTO EXAME(data_resultado, nome, descricao, consulta_id) VALUES
('2022-06-01', 'Exame de sangue', 'Para detectar possíveis vermes', 2);

INSERT INTO VACINACAO(vacina, detalhes, consulta_id) VALUES
('Vacina antirrábica', '', 1);

-- 2
INSERT INTO CLINICA(nome) VALUES('Castro Alves');

INSERT INTO CLIENTE(nome, email, endereco, telefone, clinica_id) VALUES
('João Luiz', 'joaoluiz@gmail.com', 'Rua Santos Dumont, 114 - Santos/SP', '13981578178', 2);

INSERT INTO PET(nome, especie, raca, sexo, castrado, clinica_id, dono_id) VALUES
('Thor', 'Cachorro', 'Vira lata', 'MASCULINO', true, 2, 5),
('Mia', 'Gato', '', 'FEMININO', true, 2, 5);