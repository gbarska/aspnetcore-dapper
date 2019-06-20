CREATE DATABASE BaseIndicadores;
GO

USE BaseIndicadores;
GO

CREATE TABLE dbo.Indicadores(
    Sigla VARCHAR(10) NOT NULL,
    NomeIndicador VARCHAR(60) NOT NULL,
    UltimaAtualizacao DATETIME NOT NULL,
    Valor NUMERIC(18,4) NOT NULL,
    CONSTRAINT PK_Indicadores PRIMARY KEY (Sigla)
)
GO


INSERT INTO dbo.Indicadores
    (Sigla
    ,NomeIndicador
    ,UltimaAtualizacao
    ,Valor)
VALUES
    ('SALARIO'
    ,'Salario Minimo'
    ,'2019-01-01'
    ,937.00)

INSERT INTO dbo.Indicadores
    (Sigla
    ,NomeIndicador
    ,UltimaAtualizacao
    ,Valor)
VALUES
    ('IPCA'
    ,'Indice Nacional de Precos'
    ,'2019-04-01'
    ,0.0014)


INSERT INTO dbo.Indicadores
    (Sigla
    ,NomeIndicador
    ,UltimaAtualizacao
    ,Valor)
VALUES
    ('SELIC'
    ,'Taxa Referencial'
    ,'2019-02-01'
    ,0.1114)