USE [INVENTARIOS1]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Proc_Productos'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Proc_Productos'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Proc_Productos'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Proc_Control'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Proc_Control'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProductosVendidos', @level2type=N'COLUMN',@level2name=N'Tipo'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Productos', @level2type=N'COLUMN',@level2name=N'ValorAgregado'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Productos', @level2type=N'COLUMN',@level2name=N'Precio_3'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Productos', @level2type=N'COLUMN',@level2name=N'Precio_2'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Productos', @level2type=N'COLUMN',@level2name=N'Precio_1'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturasVtas', @level2type=N'COLUMN',@level2name=N'Impreso'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturasVtas', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturasVtas', @level2type=N'COLUMN',@level2name=N'Tipo'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Clientes', @level2type=N'COLUMN',@level2name=N'NivelPrecio'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Clientes', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Clientes', @level2type=N'COLUMN',@level2name=N'Tipo'
GO
ALTER TABLE [dbo].[Proveedores] DROP CONSTRAINT [FK_Proveedores_Estados]
GO
ALTER TABLE [dbo].[Proveedores] DROP CONSTRAINT [FK_Proveedores_Ciudades]
GO
ALTER TABLE [dbo].[ProductosVendidos] DROP CONSTRAINT [FK_ProductosVendidos_FacturasVtas]
GO
ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [FK_Productos_Proveedores]
GO
ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [FK_Productos_Lineas]
GO
ALTER TABLE [dbo].[FacturasVtas] DROP CONSTRAINT [FK_FacturasVtas_Clientes]
GO
ALTER TABLE [dbo].[Control] DROP CONSTRAINT [FK_Control_Estados]
GO
ALTER TABLE [dbo].[Control] DROP CONSTRAINT [FK_Control_Ciudades]
GO
ALTER TABLE [dbo].[Ciudades] DROP CONSTRAINT [FK_Ciudades_Estados]
GO
ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [DF_Productos_ValorAgregado]
GO
ALTER TABLE [dbo].[FacturasVtas] DROP CONSTRAINT [DF_FacturasVtas_Impreso]
GO
ALTER TABLE [dbo].[FacturasVtas] DROP CONSTRAINT [DF_FacturasVtas_Status]
GO
ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [DF_Clientes_NivelPrecio]
GO
ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [DF_Clientes_Status]
GO
ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [DF_Clientes_Tipo]
GO
/****** Object:  Table [dbo].[ProductosVendidos]    Script Date: 4/9/2022 10:36:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductosVendidos]') AND type in (N'U'))
DROP TABLE [dbo].[ProductosVendidos]
GO
/****** Object:  Table [dbo].[FacturasVtas]    Script Date: 4/9/2022 10:36:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FacturasVtas]') AND type in (N'U'))
DROP TABLE [dbo].[FacturasVtas]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 4/9/2022 10:36:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Clientes]') AND type in (N'U'))
DROP TABLE [dbo].[Clientes]
GO
/****** Object:  View [dbo].[Proc_Control]    Script Date: 4/9/2022 10:36:12 PM ******/
DROP VIEW [dbo].[Proc_Control]
GO
/****** Object:  Table [dbo].[Control]    Script Date: 4/9/2022 10:36:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Control]') AND type in (N'U'))
DROP TABLE [dbo].[Control]
GO
/****** Object:  View [dbo].[Proc_Productos]    Script Date: 4/9/2022 10:36:12 PM ******/
DROP VIEW [dbo].[Proc_Productos]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 4/9/2022 10:36:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Productos]') AND type in (N'U'))
DROP TABLE [dbo].[Productos]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 4/9/2022 10:36:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proveedores]') AND type in (N'U'))
DROP TABLE [dbo].[Proveedores]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 4/9/2022 10:36:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ciudades]') AND type in (N'U'))
DROP TABLE [dbo].[Ciudades]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 4/9/2022 10:36:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Estados]') AND type in (N'U'))
DROP TABLE [dbo].[Estados]
GO
/****** Object:  Table [dbo].[Lineas]    Script Date: 4/9/2022 10:36:12 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Lineas]') AND type in (N'U'))
DROP TABLE [dbo].[Lineas]
GO
USE [master]
GO
/****** Object:  Database [INVENTARIOS1]    Script Date: 4/9/2022 10:36:12 PM ******/
DROP DATABASE [INVENTARIOS1]
GO
/****** Object:  Database [INVENTARIOS1]    Script Date: 4/9/2022 10:36:12 PM ******/
CREATE DATABASE [INVENTARIOS1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'INVENTARIOS1', FILENAME = N'/var/opt/mssql/data/INVENTARIOS1.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'INVENTARIOS1_log', FILENAME = N'/var/opt/mssql/data/INVENTARIOS1_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [INVENTARIOS1] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [INVENTARIOS1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [INVENTARIOS1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET ARITHABORT OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [INVENTARIOS1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [INVENTARIOS1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [INVENTARIOS1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [INVENTARIOS1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET RECOVERY FULL 
GO
ALTER DATABASE [INVENTARIOS1] SET  MULTI_USER 
GO
ALTER DATABASE [INVENTARIOS1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [INVENTARIOS1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [INVENTARIOS1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [INVENTARIOS1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [INVENTARIOS1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [INVENTARIOS1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'INVENTARIOS1', N'ON'
GO
ALTER DATABASE [INVENTARIOS1] SET QUERY_STORE = OFF
GO
USE [INVENTARIOS1]
GO
/****** Object:  Table [dbo].[Lineas]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lineas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Descuento] [float] NOT NULL,
 CONSTRAINT [PK_Lineas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEdo] [int] NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Domicilio] [nvarchar](50) NOT NULL,
	[Ciudad] [int] NOT NULL,
	[Estado] [int] NOT NULL,
	[CodigoPostal] [decimal](5, 0) NOT NULL,
	[Telefono] [decimal](10, 0) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL,
	[RFC] [nvarchar](13) NOT NULL,
	[NombreComercial] [nvarchar](50) NOT NULL,
	[Contacto] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreCorto] [nvarchar](20) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Linea] [int] NOT NULL,
	[Costo] [float] NOT NULL,
	[Precio_1] [float] NOT NULL,
	[Precio_2] [float] NOT NULL,
	[Precio_3] [float] NOT NULL,
	[Descuento] [float] NOT NULL,
	[Foto] [image] NULL,
	[Proveedor] [int] NOT NULL,
	[Existencia] [float] NOT NULL,
	[Ubicacion] [nvarchar](50) NOT NULL,
	[CantMax] [float] NOT NULL,
	[CantMin] [float] NOT NULL,
	[CantReorden] [float] NOT NULL,
	[Caducidad] [date] NOT NULL,
	[ValorAgregado] [nchar](1) NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Proc_Productos]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Proc_Productos]
AS
SELECT        dbo.Productos.*, dbo.Proveedores.Nombre, dbo.Lineas.Nombre AS Expr1, dbo.Estados.Nombre AS Expr2, dbo.Ciudades.Nombre AS Expr3
FROM            dbo.Productos INNER JOIN
                         dbo.Proveedores ON dbo.Productos.Proveedor = dbo.Proveedores.Id INNER JOIN
                         dbo.Lineas ON dbo.Productos.Linea = dbo.Lineas.Id INNER JOIN
                         dbo.Estados ON dbo.Proveedores.Estado = dbo.Estados.Id INNER JOIN
                         dbo.Ciudades ON dbo.Proveedores.Ciudad = dbo.Ciudades.Id AND dbo.Estados.Id = dbo.Ciudades.IdEdo
GO
/****** Object:  Table [dbo].[Control]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Control](
	[NombreEmpresa] [nvarchar](50) NOT NULL,
	[Domicilio] [nvarchar](50) NOT NULL,
	[Estado] [int] NOT NULL,
	[Ciudad] [int] NOT NULL,
	[RFC] [nvarchar](13) NOT NULL,
	[Telefono] [nvarchar](30) NOT NULL,
	[CodigoPostal] [nvarchar](5) NOT NULL,
	[Correo] [nvarchar](30) NOT NULL,
	[PasswordCorreo] [nvarchar](20) NOT NULL,
	[FolioVtasCredito] [int] NOT NULL,
	[FolioVtasContado] [int] NOT NULL,
	[FolioVtasRemision] [int] NOT NULL,
	[FolioCompras] [int] NOT NULL,
	[FolioCotizacion] [int] NOT NULL,
	[Usuario] [nvarchar](10) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[IVA] [float] NULL,
	[Logo] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Proc_Control]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Proc_Control]
AS
SELECT        dbo.Control.NombreEmpresa, dbo.Control.Domicilio, dbo.Control.Estado, dbo.Control.Ciudad, dbo.Control.RFC, dbo.Control.Telefono, dbo.Control.CodigoPostal, dbo.Control.Correo, dbo.Control.Logo, dbo.Control.FolioVtasCredito, 
                         dbo.Control.FolioVtasContado, dbo.Control.FolioVtasRemision, dbo.Control.FolioCompras, dbo.Control.Usuario, dbo.Control.Password, dbo.Estados.Nombre, dbo.Ciudades.Nombre AS Nomciudad
FROM            dbo.Control INNER JOIN
                         dbo.Estados ON dbo.Control.Estado = dbo.Estados.Id INNER JOIN
                         dbo.Ciudades ON dbo.Control.Ciudad = dbo.Ciudades.Id AND dbo.Estados.Id = dbo.Ciudades.IdEdo
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocial] [nvarchar](80) NOT NULL,
	[NombreComercial] [nvarchar](50) NOT NULL,
	[Domicilio] [nvarchar](50) NOT NULL,
	[Estado] [int] NOT NULL,
	[Ciudad] [int] NOT NULL,
	[CodigoPostal] [decimal](5, 0) NOT NULL,
	[RFC] [nvarchar](13) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL,
	[Contacto] [nvarchar](30) NOT NULL,
	[Telefono] [decimal](10, 0) NOT NULL,
	[Tipo] [nchar](1) NOT NULL,
	[Status] [nchar](1) NOT NULL,
	[LimiteCredito] [float] NOT NULL,
	[Descuento] [float] NOT NULL,
	[NivelPrecio] [nchar](1) NOT NULL,
	[FechaNac] [date] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturasVtas]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasVtas](
	[Folio] [int] NOT NULL,
	[Tipo] [nchar](1) NOT NULL,
	[Cliente] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Observacion] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
	[EnvioFactura] [bit] NOT NULL,
	[Impreso] [bit] NOT NULL,
	[Timbrado] [bit] NOT NULL,
 CONSTRAINT [PK_FacturasVtas] PRIMARY KEY CLUSTERED 
(
	[Folio] ASC,
	[Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductosVendidos]    Script Date: 4/9/2022 10:36:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductosVendidos](
	[Folio] [int] NOT NULL,
	[Tipo] [nchar](1) NULL,
	[Producto] [int] NOT NULL,
	[Cantidad] [float] NOT NULL,
	[Descuento] [float] NOT NULL,
	[Precio] [float] NOT NULL,
	[Costo] [float] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF_Clientes_Tipo]  DEFAULT ((1)) FOR [Tipo]
GO
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF_Clientes_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF_Clientes_NivelPrecio]  DEFAULT ((1)) FOR [NivelPrecio]
GO
ALTER TABLE [dbo].[FacturasVtas] ADD  CONSTRAINT [DF_FacturasVtas_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[FacturasVtas] ADD  CONSTRAINT [DF_FacturasVtas_Impreso]  DEFAULT ((1)) FOR [Impreso]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF_Productos_ValorAgregado]  DEFAULT ('G') FOR [ValorAgregado]
GO
ALTER TABLE [dbo].[Ciudades]  WITH CHECK ADD  CONSTRAINT [FK_Ciudades_Estados] FOREIGN KEY([IdEdo])
REFERENCES [dbo].[Estados] ([Id])
GO
ALTER TABLE [dbo].[Ciudades] CHECK CONSTRAINT [FK_Ciudades_Estados]
GO
ALTER TABLE [dbo].[Control]  WITH CHECK ADD  CONSTRAINT [FK_Control_Ciudades] FOREIGN KEY([Ciudad])
REFERENCES [dbo].[Ciudades] ([Id])
GO
ALTER TABLE [dbo].[Control] CHECK CONSTRAINT [FK_Control_Ciudades]
GO
ALTER TABLE [dbo].[Control]  WITH CHECK ADD  CONSTRAINT [FK_Control_Estados] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estados] ([Id])
GO
ALTER TABLE [dbo].[Control] CHECK CONSTRAINT [FK_Control_Estados]
GO
ALTER TABLE [dbo].[FacturasVtas]  WITH CHECK ADD  CONSTRAINT [FK_FacturasVtas_Clientes] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[FacturasVtas] CHECK CONSTRAINT [FK_FacturasVtas_Clientes]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Lineas] FOREIGN KEY([Linea])
REFERENCES [dbo].[Lineas] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Lineas]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Proveedores] FOREIGN KEY([Proveedor])
REFERENCES [dbo].[Proveedores] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Proveedores]
GO
ALTER TABLE [dbo].[ProductosVendidos]  WITH CHECK ADD  CONSTRAINT [FK_ProductosVendidos_FacturasVtas] FOREIGN KEY([Folio], [Tipo])
REFERENCES [dbo].[FacturasVtas] ([Folio], [Tipo])
GO
ALTER TABLE [dbo].[ProductosVendidos] CHECK CONSTRAINT [FK_ProductosVendidos_FacturasVtas]
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_Proveedores_Ciudades] FOREIGN KEY([Ciudad])
REFERENCES [dbo].[Ciudades] ([Id])
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_Ciudades]
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_Proveedores_Estados] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estados] ([Id])
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_Estados]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1=Contado
2=Credito' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Clientes', @level2type=N'COLUMN',@level2name=N'Tipo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1=Libre
2=Controlado
3=Suspendido
4=Cancelado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Clientes', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1=Precio de Lista
2=Precio de Mayoreo
3=Precio de Menudeo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Clientes', @level2type=N'COLUMN',@level2name=N'NivelPrecio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1=Contado
2=Credito' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturasVtas', @level2type=N'COLUMN',@level2name=N'Tipo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0=Activa
1=Inactiva' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturasVtas', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0=Impresa
1=No Impresa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FacturasVtas', @level2type=N'COLUMN',@level2name=N'Impreso'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Precio de Lista' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Productos', @level2type=N'COLUMN',@level2name=N'Precio_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Precio de Mayoreo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Productos', @level2type=N'COLUMN',@level2name=N'Precio_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Precio de Menudeo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Productos', @level2type=N'COLUMN',@level2name=N'Precio_3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'G=Gravado con IVA
E=Excento de IVA' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Productos', @level2type=N'COLUMN',@level2name=N'ValorAgregado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1=Contado
2=Credito' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProductosVendidos', @level2type=N'COLUMN',@level2name=N'Tipo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Control"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Estados"
            Begin Extent = 
               Top = 132
               Left = 346
               Bottom = 228
               Right = 516
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ciudades"
            Begin Extent = 
               Top = 15
               Left = 577
               Bottom = 128
               Right = 747
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Proc_Control'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Proc_Control'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[59] 4[24] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -480
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Productos"
            Begin Extent = 
               Top = 8
               Left = 32
               Bottom = 138
               Right = 202
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Proveedores"
            Begin Extent = 
               Top = 0
               Left = 547
               Bottom = 130
               Right = 734
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Lineas"
            Begin Extent = 
               Top = 143
               Left = 444
               Bottom = 256
               Right = 614
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Estados"
            Begin Extent = 
               Top = 214
               Left = 636
               Bottom = 310
               Right = 806
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ciudades"
            Begin Extent = 
               Top = 220
               Left = 14
               Bottom = 333
               Right = 184
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Proc_Productos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Proc_Productos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Proc_Productos'
GO
USE [master]
GO
ALTER DATABASE [INVENTARIOS1] SET  READ_WRITE 
GO
