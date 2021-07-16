
CREATE DATABASE Armeria

USE Armeria

CREATE TABLE Cuerpos (
    CuerpoId int IDENTITY(1,1) PRIMARY KEY,
    Nombre varchar(255),
    Material varchar(255)
);
