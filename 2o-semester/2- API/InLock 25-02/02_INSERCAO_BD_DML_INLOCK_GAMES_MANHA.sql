
USE InLock_Games_Manha

INSERT INTO USUARIOS (EMAIL, SENHA, TIPOUSUARIO)
 VALUES ('admin@admin.com','admin','ADMINISTRADOR'),
        ('cliente@cliente.com','cliente','CLIENTE')

INSERT INTO ESTUDIOS (NOMEESTUDIO)
 VALUES ('BLIZZARD'), ('ROCKSTAR STUDIOS'), ('SQUARE ENIX'), ('SANTA MONICA'), ('CIPSOFT')

 INSERT INTO JOGOS (NOMEJOGO, DESCRICAO, DATALANCAMENTO, VALOR, ESTUDIOID)
 VALUES      ('DIABLO 3','é um jogo que contém bastante ação e é viciante, seja você um novato ou um fã','2012-05-15','99.99',1),
			 ('Red Dead Redemption II','jogo eletrônico de ação-aventura western','2018-10-26','120.00', 2),
			 ('GOD OF WAR IV','Vencedor do GotY 2018','2018-01-01','120.00', 4),
			 ('TIBIA', 'MMRPG COM MAIS DE 20 ANOS E AINDA SEM SOM!', '1997-01-01', '0.00', 5)        

