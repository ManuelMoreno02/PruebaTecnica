USE [master]
GO

IF NOT EXISTS (SELECT * FROM sysdatabases WHERE (name = 'Tareas')) 
BEGIN
	Create database Tareas
	PRINT 'LA BASE DE DATOS CREADA CORRECTAMENTE'
END 



