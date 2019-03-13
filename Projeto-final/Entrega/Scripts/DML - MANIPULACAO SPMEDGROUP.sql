
USE SPMEDGROUP


INSERT INTO TIPO_USUARIOS(TIPO)
					VALUES ('MEDICO'),('PACIENTE'),('ADMINSTRADOR')

SELECT * FROM TIPO_USUARIOS

UPDATE TIPO_USUARIOS
SET TIPO = 'ADMINISTRADOR'
WHERE ID = 3;

INSERT INTO AREA_CLINICA(ESPECIALIDADE)
	VALUES ('ACUPUNTURA'), ('ANESTESIOLOGIA'), ('ANGIOLOGIA'), ('CARDIOLOGIA')
	, ('CIRURGIA CARDIOVASCULAR'), ('CIRURGIA DE MAO'), ('CIRURGIA DO APARELHO DIGESTIVO'), ('CIRURGIA GERAL')
	, ('CIRURGIA PEDIATRICA'), ('CIRURGIA PLASTICA'), ('CIRURGIA TORACICA'), ('CIRURGIA VASCULAR')
	, ('DERMATOLOGIA'), ('RADIOTERAPIA'), ('UROLOGIA'), ('PEDIATRIA'), ('PSIQUIATRIA')   

SELECT * FROM AREA_CLINICA

INSERT INTO STATUS_CONSULTA(STATUS)
					VALUES ('AGENDADA'), ('REALIZADA'), ('CANCELADA')

SELECT * FROM STATUS_CONSULTA

INSERT INTO USUARIOS		(NOME, EMAIL, SENHA,
							 RG, CPF, TELEFONE_CONTATO, DATA_NASCIMENTO, ID_TIPO_USUARIO,
							 ENDERECO)
					VALUES ('RICARDO LEMOS', 'ricardo.lemos@spmedicalgroup.com.br', 'LEMOS',
					       '8640090230', '8640090230', '986400230', '2019-02-11', 1
						   , 'Av. Barão Limeira, 532, São Paulo, SP')
					   	, ('ROBERTO POSSARLE', 'roberto.possarle@spmedicalgroup.com.br', 'POSSARLE',
						   '8640090230', '8640090230', '986400230', '2019-02-11', 1
						   , 'Av. Barão Limeira, 532, São Paulo, SP')
						, ('HELENA STRADA', 'helena.souza@spmedicalgroup.com.br', 'STRADA',
						   '8640090230', '8640090230', '986400230', '2019-02-11', 1
						   , 'Av. Barão Limeira, 532, São Paulo, SP')
						, ('LIGIA', 'ligia@gmail.com', 'LIGIA',
						   '435225435', '94839859000', '1134567654', '1983-10-13', 2
						   , 'Av. Barão Limeira, 532, São Paulo, SP')
						, ('ALEXANDRE', 'alexandre@gmail.com', 'ALEXANDRE',
						   '326543457', '73556944057', '11987656543', '2001-07-23', 2
						   , 'Av. Barão Limeira, 532, São Paulo, SP')
						, ('FERNANDO', 'fernando@gmail.com', 'FERNANDO',
						   '546365253', '16839338002', '11972084453', '1978-10-10', 2
						   , 'Lá na casa do Pedrinho')
						, ('HENRIQUE', 'henrique@gmail.com', 'HENRIQUE',
						   '543663625', '14332654765', '1134566543', '1985-10-13', 2
						   , 'Av. Barão Limeira, 532, São Paulo, SP')
						, ('JOAO', 'joao@hotmail.com', 'JOAO',
						   '325444441', '91305348010', '1176566377', '1975-08-27', 2
						   , 'Av. Barão Limeira, 532, São Paulo, SP')
						, ('BRUNO', 'bruno@gmail.com', 'BRUNO',
						   '545662667', '79799299004', '11954368769', '1972-03-21', 2
						   , 'Av. Barão Limeira, 532, São Paulo, SP')
						, ('MARIANA', 'mariana@outlook.com', 'MARIANA',
						   '545662668', '13771913039', '', '2018-03-05', 2
						   , 'Av. Barão Limeira, 532, São Paulo, SP'),
						   ('Esqelectellus','RemoveEs') 


SELECT * FROM USUARIOS

INSERT INTO PRONTUARIO_PACIENTE(ID_USUARIO, NOTAS, DOENCAS, REMEDIOS)
						VALUES(18, 'EBOLA', 'EBOLA', 'CHAZINHO'),
							  (19, '', 'ESTRESSE', 'CHAZINHO'),
							  (20, '', 'ESTRESSE', 'CHAZINHO'),
							  (21, '', 'ESTRESSE', 'CHAZINHO'),		
							  (22, '', 'ESTRESSE', 'CHAZINHO'),
							  (23, '', 'ESTRESSE', 'CHAZINHO'),
							  (24, '', 'ESTRESSE', 'CHAZINHO')

SELECT * FROM PRONTUARIO_PACIENTE
SELECT * FROM AREA_CLINICA

INSERT INTO TIPO_MEDICO (CRM, ID_AREA_CLINICA, ID_USUARIO)
				VALUES('54356-SP', 2, 15)
				,	  ('53452-SP', 17, 16)
				,	  ('65463-SP', 16, 17)

SELECT * FROM TIPO_MEDICO

INSERT INTO CONSULTA(ID_STATUS_CONSULTA, DATA_AGENDAMENTO, ID_MEDICO, ID_PACIENTE, DESCRICAO) 
		VALUES		 (2, '20/01/2019 15:00:00', 3, 7, '')
					,(3, '06/01/2018 10:00:00', 2, 2, '')
					,(2, '07/02/2019 11:00:00', 2, 3, '')
					,(2, '06/02/2018 10:00:00', 2, 2, '')
					,(3, '07/02/2019 11:00:00', 1, 4, 'PEGOU EBOLA')
					,(1, '08/02/2019 15:00:00', 3, 7, '')
					,(1, '09/02/2019 11:00:00', 1, 4, 'NO CEU TEM PAO?')

SELECT * FROM CONSULTA

INSERT INTO CLINICA(CNPJ, ENDERECO,
 DATA_INICIO, RAZAO_SOCIAL, NOME_FANTASIA, HORARIO_FUNCIONAMENTO)
VALUES ('132132132', 'Alameda Barão de Limeira, 539 - Santa Cecilia, São Paulo - SP, 01202-001',
 '2019-02-11', 'SP Medical Group', 'SP Medical Group', 700)

SELECT * FROM CLINICA


