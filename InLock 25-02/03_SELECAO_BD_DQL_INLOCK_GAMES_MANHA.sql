
USE InLock_Games_Manha

SELECT * FROM USUARIOS

SELECT * FROM ESTUDIOS

SELECT * FROM JOGOS

SELECT * FROM JOGOS INNER JOIN ESTUDIOS ON JOGOS.ESTUDIOID = ESTUDIOS.ESTUDIOID

SELECT * FROM ESTUDIOS LEFT JOIN JOGOS ON ESTUDIOS.ESTUDIOID = JOGOS.ESTUDIOID

SELECT EMAIL, SENHA FROM USUARIOS

SELECT * FROM JOGOS WHERE JOGOID BETWEEN 1 AND 9

SELECT * FROM ESTUDIOS WHERE ESTUDIOID BETWEEN 1 AND 9


