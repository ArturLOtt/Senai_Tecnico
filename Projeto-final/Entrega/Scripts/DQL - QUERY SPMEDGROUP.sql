
USE SPMEDGROUP


--Mostrou a quantidade de usuários após realizar a importação do banco de dados
SELECT COUNT (ID) AS QUANTIDADE_DE_USUARIOS FROM USUARIOS;

--Converteu a data de nascimento do usuário para o formato (mm-dd-yyyy)
SELECT convert(varchar, getdate(), 101)	 DATA_NASCIMENTO FROM USUARIOS INNER JOIN PRONTUARIO_PACIENTE
 ON USUARIOS.ID = PRONTUARIO_PACIENTE.ID_USUARIO; 

--Calculou a idade do usuário a partir da data de nascimento

SELECT DATEDIFF(DAY, DATA_NASCIMENTO, GETDATE()) / 365 AS IDADE FROM USUARIOS

--evento para que a idade do usuário seja calculada todos os dias
--NULL

--Criou uma função para retornar à quantidade de médicos de uma determinada especialidade

SELECT COUNT (*) FROM USUARIOS INNER JOIN TIPO_MEDICO
 ON USUARIOS.ID = TIPO_MEDICO.ID_USUARIO
 -- WHERE ...

--retorne a idade do usuário a partir de uma determinada stored procedure

CREATE FUNCTION FUN_IDADE_USUARIO()
RETURNS TABLE 
AS
RETURN (SELECT DATEDIFF(DAY, DATA_NASCIMENTO, GETDATE()) / 365 AS IDADE FROM USUARIOS)

DROP FUNCTION FUN_IDADE_USUARIO
SELECT * FROM FUN_IDADE_USUARIO()

