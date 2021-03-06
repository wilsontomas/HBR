USE [PracticaWeb]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreCategoria] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[IdCategoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](255) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Apellido] [varchar](255) NOT NULL,
	[Clave] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[Buscar_Categoria]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Buscar_Categoria] @IdC int
as
begin
SELECT * FROM Categoria WHERE Id = @IdC
end

GO
/****** Object:  StoredProcedure [dbo].[Buscar_Producto]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Buscar_Producto] @IdProducto int
as
begin
SELECT * FROM Producto WHERE Producto.Id =@IdProducto
end

GO
/****** Object:  StoredProcedure [dbo].[Buscar_Producto_Categoria]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Buscar_Producto_Categoria] @IdC int
as
begin
SELECT * FROM Producto WHERE IdCategoria =@IdC
end

GO
/****** Object:  StoredProcedure [dbo].[Consulta_Producto_Categoria]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Consulta_Producto_Categoria]
as
begin
select Producto.Id, Producto.Nombre, Categoria.NombreCategoria from Producto inner join Categoria on Producto.IdCategoria = Categoria.Id 
end
GO
/****** Object:  StoredProcedure [dbo].[Crear_Categoria]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Crear_Categoria] @NombreC varchar(255)
as
begin
INSERT INTO Categoria (NombreCategoria) VALUES (@NombreC)
end

GO
/****** Object:  StoredProcedure [dbo].[Crear_Producto]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Crear_Producto] @NombreP varchar(255), @CategoriaP int 
as
begin
INSERT INTO Producto (Nombre,IdCategoria) VALUES (@NombreP,@CategoriaP)
end

GO
/****** Object:  StoredProcedure [dbo].[Editar_Categoria]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Editar_Categoria] @IdC int, @NombreC varchar(255)
as
begin
UPDATE Categoria SET NombreCategoria = @NombreC WHERE Id = @IdC
end

GO
/****** Object:  StoredProcedure [dbo].[Editar_Perfil]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Editar_Perfil] @Id int, @Nombre varchar(255), @Apellido varchar(255)
as
begin
UPDATE Usuario SET Nombre=@Nombre, Apellido=@Apellido WHERE Id=@Id
end

GO
/****** Object:  StoredProcedure [dbo].[Editar_Producto]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Editar_Producto] @IdP int, @NombreP varchar(255), @CategoriaP int 
as
begin
UPDATE Producto SET Nombre=@NombreP, IdCategoria=@CategoriaP WHERE Producto.Id =@IdP
end

GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Categoria]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_Categoria] @IdC int
as
begin
DELETE FROM Producto WHERE Producto.IdCategoria = @IdC
DELETE FROM Categoria WHERE Categoria.Id =@IdC
end

GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Producto]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_Producto] @IdP int
as
begin
DELETE FROM Producto WHERE Producto.Id =@IdP
end

GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Categoria]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Mostrar_Categoria]
as
begin
SELECT * FROM Categoria
end

GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Productos_Categoria]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Mostrar_Productos_Categoria]
as
begin
select Producto.Id, Producto.Nombre, Categoria.NombreCategoria FROM Producto INNER JOIN Categoria ON Producto.IdCategoria = Categoria.Id
end

GO
/****** Object:  StoredProcedure [dbo].[Registrar_Usuario]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Registrar_Usuario] @Nombre varchar(255), @NombreUsuario varchar(255),@Apellido varchar(255), @Clave varchar(255)
as
begin

INSERT INTO Usuario (Nombre, NombreUsuario, Apellido ,Clave) VALUES (@Nombre, @NombreUsuario, @Apellido, @Clave)

end

GO
/****** Object:  StoredProcedure [dbo].[Validar_Usuario]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Validar_Usuario] @NombreC varchar(255), @ClaveC varchar(255)
as
begin
select * from Usuario where NombreUsuario=@NombreC and Clave=@ClaveC
end

GO
/****** Object:  StoredProcedure [dbo].[Verificar_Usuario]    Script Date: 8/30/2020 11:05:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Verificar_Usuario] @NombreUsuario varchar(255)
as
begin

SELECT * FROM Usuario WHERE NombreUsuario = @NombreUsuario

end

GO
