USE [master]
GO
/****** Object:  Database [Sunny_School]    Script Date: 01/07/2020 20:25:48 ******/
CREATE DATABASE [Sunny_School]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sunny_School', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Sunny_School.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sunny_School_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Sunny_School_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sunny_School] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sunny_School].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sunny_School] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sunny_School] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sunny_School] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sunny_School] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sunny_School] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sunny_School] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sunny_School] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sunny_School] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sunny_School] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sunny_School] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sunny_School] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sunny_School] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sunny_School] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sunny_School] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sunny_School] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sunny_School] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sunny_School] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sunny_School] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sunny_School] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sunny_School] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sunny_School] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sunny_School] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sunny_School] SET RECOVERY FULL 
GO
ALTER DATABASE [Sunny_School] SET  MULTI_USER 
GO
ALTER DATABASE [Sunny_School] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sunny_School] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sunny_School] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sunny_School] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sunny_School] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Sunny_School', N'ON'
GO
ALTER DATABASE [Sunny_School] SET QUERY_STORE = OFF
GO
USE [Sunny_School]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 01/07/2020 20:25:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[CURP] [varchar](max) NULL,
	[Nacionalidad] [varchar](max) NULL,
	[Fecha_nacimiento] [datetime2](7) NULL,
	[Genero] [nvarchar](max) NULL,
	[Discapacidad] [nvarchar](max) NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alumno_Escolar]    Script Date: 01/07/2020 20:25:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno_Escolar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Nivel_Escolar] [nvarchar](max) NULL,
	[Grado_Escolar] [nvarchar](max) NULL,
	[Nombre_Tutor] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Datos_Economicos]    Script Date: 01/07/2020 20:25:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datos_Economicos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ingresos_Mensuales] [bigint] NULL,
	[Gasto_Alimentacion] [bigint] NULL,
	[Gasto_Escolar] [bigint] NULL,
	[Gasto_Vivienda] [bigint] NULL,
	[Gasto_Servicios] [bigint] NULL,
	[Gasto_Transporte] [bigint] NULL,
	[Otros] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Datos_Familiar_Madre]    Script Date: 01/07/2020 20:25:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datos_Familiar_Madre](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Madre] [nvarchar](max) NULL,
	[CURP] [nvarchar](max) NULL,
	[Nacionalidad] [nvarchar](max) NULL,
	[Fecha_nacimiento] [datetime2](7) NULL,
	[Ocupacion] [nvarchar](max) NULL,
	[Ingresos] [bigint] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Datos_Familiar_Padre]    Script Date: 01/07/2020 20:25:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datos_Familiar_Padre](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Padre] [nvarchar](max) NULL,
	[CURP] [nvarchar](max) NULL,
	[Nacionalidad] [nvarchar](max) NULL,
	[Fecha_nacimiento] [datetime2](7) NULL,
	[Ocupacion] [nvarchar](max) NULL,
	[Ingresos] [bigint] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Datos_Vivienda]    Script Date: 01/07/2020 20:25:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Datos_Vivienda](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Area] [nvarchar](max) NULL,
	[Servicios] [nvarchar](max) NULL,
	[Construccion] [nvarchar](max) NULL,
	[Estatus] [nvarchar](max) NULL,
	[Mobiliario] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Sunny_School] SET  READ_WRITE 
GO
