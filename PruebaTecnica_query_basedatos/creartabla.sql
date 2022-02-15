USE [Tareas]
GO

CREATE TABLE Tarea  
   (ProductID int IDENTITY (1,1) NOT NULL ,  
   NTarea varchar(25) NOT NULL,  
   Descripcion varchar(25) NULL,  
   Estado bit not null,
   TiempoEstimado int  null,
   FechaCreacion DATETIME  null,
   FechaFinal DATETIME  null,
   Prioridad int not null,
   Responsable varchar(50)null,
   FechaEstimado DATETIME not null)
GO 