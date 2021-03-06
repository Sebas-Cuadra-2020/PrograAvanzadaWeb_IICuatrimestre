USE [Proyecto_PrograWebAvanzada]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 8/25/2021 10:46:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[CedulaCliente] [int] NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[NombreCliente] [varchar](50) NOT NULL,
	[CorreoEmpleado] [varchar](50) NOT NULL,
	[Provincia] [varchar](50) NOT NULL,
	[Canton] [varchar](50) NOT NULL,
	[Distrito] [varchar](50) NOT NULL,
	[TelefonoEmpleado] [varchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 8/25/2021 10:46:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[CedulaEmpleado] [int] NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[NombreEmpleado] [varchar](50) NOT NULL,
	[ApellidoEmpleado] [varchar](50) NOT NULL,
	[CorreoEmpleado] [varchar](50) NOT NULL,
	[PasswordEmpleado] [varchar](50) NOT NULL,
	[Provincia] [varchar](50) NOT NULL,
	[Canton] [varchar](50) NOT NULL,
	[Distrito] [varchar](50) NOT NULL,
	[TelefonoEmpleado] [varchar](8) NOT NULL,
	[IdRol] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familia_Producto]    Script Date: 8/25/2021 10:46:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familia_Producto](
	[IdFamilia_Producto] [int] IDENTITY(1,1) NOT NULL,
	[NombreFamilia_Producto] [varchar](50) NOT NULL,
	[CodigoCabys] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFamilia_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialFactura]    Script Date: 8/25/2021 10:46:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialFactura](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[CodigoFactura] [varchar](50) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[FechaFactura] [datetime] NOT NULL,
	[TotalFactura] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 8/25/2021 10:46:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[CodigoBarras] [int] NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[NombreProducto] [varchar](50) NOT NULL,
	[CantidadProducto] [int] NOT NULL,
	[PrecioUnitario] [int] NOT NULL,
	[PrecioVenta] [int] NOT NULL,
	[IdFamilia_Producto] [int] NOT NULL,
	[IdProveedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 8/25/2021 10:46:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[CedulaProveedor] [int] NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[NombreProveedor] [varchar](50) NOT NULL,
	[CorreoProveedor] [varchar](50) NOT NULL,
	[Provincia] [varchar](50) NOT NULL,
	[Canton] [varchar](50) NOT NULL,
	[Distrito] [varchar](50) NOT NULL,
	[TelefonoProveedor] [varchar](8) NOT NULL,
	[CuentaBancariaProveedor] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol_Empleado]    Script Date: 8/25/2021 10:46:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol_Empleado](
	[IdRol] [int] NOT NULL,
	[NombreRol] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol_Empleado] ([IdRol])
GO
ALTER TABLE [dbo].[HistorialFactura]  WITH CHECK ADD FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[HistorialFactura]  WITH CHECK ADD FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([IdFamilia_Producto])
REFERENCES [dbo].[Familia_Producto] ([IdFamilia_Producto])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedor] ([IdProveedor])
GO
/****** Object:  StoredProcedure [dbo].[GET_SEG_USUARIO]    Script Date: 8/25/2021 10:46:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GET_SEG_USUARIO] @usuario VARCHAR (50),
@contrasena VARCHAR (250) 
AS BEGIN
SELECT CorreoEmpleado, PasswordEmpleado, IdRol 
FROM Empleado WHERE CorreoEmpleado = @usuario AND PasswordEmpleado = @contrasena 
END
GO
