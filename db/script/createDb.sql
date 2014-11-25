DECLARE @PRIZMA_DB_NAME nvarchar(255) = 'Prizm',
		@PRIZMA_DB_PATH nvarchar (1000) =  CAST (SERVERPROPERTY('instancedefaultdatapath') AS nvarchar(1000))

DECLARE @CREATE_DB nvarchar(MAX)

SET @CREATE_DB = 'CREATE DATABASE {DBNAME} CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = {DBNAME}, FILENAME = ''{DBPATH}{DBNAME}.mdf'' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = {DBNAME}_log, FILENAME = ''{DBPATH}{DBNAME}_log.ldf'' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
ALTER DATABASE {DBNAME} SET COMPATIBILITY_LEVEL = 110
IF (1 = FULLTEXTSERVICEPROPERTY(''IsFullTextInstalled''))
begin
EXEC [{DBNAME}].[dbo].[sp_fulltext_database] @action = ''enable''
end
ALTER DATABASE [{DBNAME}] SET ANSI_NULL_DEFAULT OFF 
ALTER DATABASE [{DBNAME}] SET ANSI_NULLS OFF 
ALTER DATABASE [{DBNAME}] SET ANSI_PADDING OFF 
ALTER DATABASE [{DBNAME}] SET ANSI_WARNINGS OFF 
ALTER DATABASE [{DBNAME}] SET ARITHABORT OFF 
ALTER DATABASE [{DBNAME}] SET AUTO_CLOSE OFF 
ALTER DATABASE [{DBNAME}] SET AUTO_CREATE_STATISTICS ON 
ALTER DATABASE [{DBNAME}] SET AUTO_SHRINK OFF 
ALTER DATABASE [{DBNAME}] SET AUTO_UPDATE_STATISTICS ON 
ALTER DATABASE [{DBNAME}] SET CURSOR_CLOSE_ON_COMMIT OFF 
ALTER DATABASE [{DBNAME}] SET CURSOR_DEFAULT  GLOBAL 
ALTER DATABASE [{DBNAME}] SET CONCAT_NULL_YIELDS_NULL OFF 
ALTER DATABASE [{DBNAME}] SET NUMERIC_ROUNDABORT OFF 
ALTER DATABASE [{DBNAME}] SET QUOTED_IDENTIFIER OFF 
ALTER DATABASE [{DBNAME}] SET RECURSIVE_TRIGGERS OFF 
ALTER DATABASE [{DBNAME}] SET  DISABLE_BROKER 
ALTER DATABASE [{DBNAME}] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
ALTER DATABASE [{DBNAME}] SET DATE_CORRELATION_OPTIMIZATION OFF 
ALTER DATABASE [{DBNAME}] SET TRUSTWORTHY OFF 
ALTER DATABASE [{DBNAME}] SET ALLOW_SNAPSHOT_ISOLATION OFF 
ALTER DATABASE [{DBNAME}] SET PARAMETERIZATION SIMPLE 
ALTER DATABASE [{DBNAME}] SET READ_COMMITTED_SNAPSHOT OFF 
ALTER DATABASE [{DBNAME}] SET HONOR_BROKER_PRIORITY OFF 
ALTER DATABASE [{DBNAME}] SET RECOVERY SIMPLE 
ALTER DATABASE [{DBNAME}] SET  MULTI_USER 
ALTER DATABASE [{DBNAME}] SET PAGE_VERIFY CHECKSUM  
ALTER DATABASE [{DBNAME}] SET DB_CHAINING OFF 
ALTER DATABASE [{DBNAME}] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
ALTER DATABASE [{DBNAME}] SET TARGET_RECOVERY_TIME = 0 SECONDS '

DECLARE @SQL_SCRIPT nvarchar(MAX)
SET @SQL_SCRIPT = REPLACE(@CREATE_DB, '{DBNAME}', @PRIZMA_DB_NAME)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DBPATH}', @PRIZMA_DB_PATH)
EXECUTE (@SQL_SCRIPT)
GO

DECLARE @SQL_SCRIPT nvarchar(MAX),
		@PRIZMA_DB_NAME nvarchar(255) = 'Prizm'
SET @SQL_SCRIPT = 
'USE [{DBNAME}]
/****** Object:  Table [dbo].[ChemicalComposition]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[ChemicalComposition](
	[id] [uniqueidentifier] NOT NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_chemicalComposition] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Heat]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Heat](
	[id] [uniqueidentifier] NOT NULL,
	[number] [nvarchar](20) NULL,
	[steelGrade] [nvarchar](20) NULL,
	[plateManufacturer] [uniqueidentifier] NULL,
	[chemicalCompositionId] [uniqueidentifier] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_heat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[Inspector]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Inspector](
	[id] [uniqueidentifier] NOT NULL,
	[firstName] [nvarchar](20) NULL,
	[lastName] [nvarchar](20) NULL,
	[middleName] [nvarchar](20) NULL,
	[certificate] [nvarchar](20) NULL,
	[certificateExpiration] [date] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_Inspector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[Pipe]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Pipe](
	[id] [uniqueidentifier] NOT NULL,
	[wallThickness] [int] NULL,
	[diameter] [int] NULL,
	[weight] [int] NULL,
	[mill] [nvarchar](250) NULL,
	[pipeMillStatus] [nvarchar](20) NULL,
	[typeId] [uniqueidentifier] NULL,
	[plateId] [uniqueidentifier] NULL,
	[purchaseOrderId] [uniqueidentifier] NULL,
	[railcarId] [uniqueidentifier] NULL,

	[chemicalCompositionId] [uniqueidentifier] NULL,

	[length] [int] NULL,
	[number] [nvarchar](20) NULL,
	[isActive] [bit] NULL,
	[inspectionStatus] [nvarchar](15) NULL,
	[constructionStatus] [nvarchar](15) NULL,
 CONSTRAINT [PK_Pipe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[PipeMillSizeType]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[PipeMillSizeType](
	[id] [uniqueidentifier] NOT NULL,
	[type] [nvarchar](50) NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_PipeMillSizeType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[PipeTest]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[PipeTest](
	[id] [uniqueidentifier] NOT NULL,
	[code] [nvarchar](20) NULL,
	[name] [nvarchar](20) NULL,
	[testSubject] [nvarchar](50) NULL,
	[controlType] [nchar](15) NULL,
	[resultType] [nvarchar](10) NULL,
	[minExpected] [decimal](5, 2) NULL,
	[maxExpected] [decimal](5, 2) NULL,
	[boolExpected] [bit] NULL,
	[isRequired] [bit] NULL,
	[pipeMillSizeTypeId] [uniqueidentifier] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_PipeTest] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[PipeTestResult]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[PipeTestResult](
	[id] [uniqueidentifier] NOT NULL,
	[testResultId] [uniqueidentifier] NULL,
	[pipeId] [uniqueidentifier] NULL,
	[pipeTestId] [uniqueidentifier] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_PipeTestResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Plate]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Plate](
	[id] [uniqueidentifier] NOT NULL,
	[number] [nvarchar](20) NULL,
	[thickness] [int] NULL,
	[chemicalCompositionId] [uniqueidentifier] NULL,
	[heatId] [uniqueidentifier] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_Plate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Project](
	[id] [uniqueidentifier] NOT NULL,
	[isActive] [bit] NOT NULL,
	[client] [nvarchar](100) NULL,
	[designer] [nvarchar](100) NULL,
	[documentSizeLimit] [int] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF



/****** Object:  Table [dbo].[PurchaseOrder]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[PurchaseOrder](
	[id] [uniqueidentifier] NOT NULL,
	[number] [nvarchar](20) NULL,
	[date] [date] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_PurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[PlateManufacturer]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[PlateManufacturer](
	[id] [uniqueidentifier]NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[isActive] [bit] NOT NULL,
 CONSTRAINT [PK_PlateManufacturer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
SET ANSI_PADDING OFF




/****** Object:  Table [dbo].[Railcar]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Railcar](
	[id] [uniqueidentifier] NOT NULL,
	[number] [nvarchar](20) NULL,
	[certificate] [nvarchar](20) NULL,
	[destination] [nvarchar](50) NULL,
	[shippingDate] [date] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_Railcar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[TestResult]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[TestResult](
	[id] [uniqueidentifier] NOT NULL,
	[date] [date] NULL,
	[value] [nvarchar](25) NULL,
	[status] [nvarchar](25) NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_TestResult] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_PADDING OFF
/****** Object:  Table [dbo].[TestResult_Inspector]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[TestResult_Inspector](
	[id] [uniqueidentifier] NOT NULL,
	[inspectorId] [uniqueidentifier] NULL,
	[resultId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_TestResult_Inspector] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Weld]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[Weld](
	[id] [uniqueidentifier] NOT NULL,
	[date] [date] NULL,

	[isActive] [bit] NULL,
CONSTRAINT [PK_weld] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Weld_Welder]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[Weld_Welder](
	[id] [uniqueidentifier] NOT NULL,
	[weldId] [uniqueidentifier] NULL,
	[welderId] [uniqueidentifier] NULL,
	[pipeId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Weld_Welder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Welder]    Script Date: 11/4/2014 4:35:49 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
SET ANSI_PADDING ON
CREATE TABLE [dbo].[Welder](
	[id] [uniqueidentifier] NOT NULL,
	[firstName] [nvarchar](20) NULL,
	[lastName] [nvarchar](20) NULL,
	[middleName] [nvarchar](20) NULL,
	[certificate] [nvarchar](20) NULL,
	[certificateExpiration] [date] NULL,
	[stamp] [nvarchar](10) NULL,
	[grade] [int] NULL,

	[isActive] [bit] NULL,
 CONSTRAINT [PK_welder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
SET ANSI_PADDING OFF

ALTER TABLE [dbo].[Heat]  WITH CHECK ADD  CONSTRAINT [FK_heat_chemicalComposition] FOREIGN KEY([chemicalCompositionId])
REFERENCES [dbo].[ChemicalComposition] ([id])
ALTER TABLE [dbo].[Heat] CHECK CONSTRAINT [FK_heat_chemicalComposition]
ALTER TABLE [dbo].[Pipe]  WITH CHECK ADD  CONSTRAINT [FK_Pipe_chemicalComposition] FOREIGN KEY([chemicalCompositionId])
REFERENCES [dbo].[ChemicalComposition] ([id])
ALTER TABLE [dbo].[Pipe] CHECK CONSTRAINT [FK_Pipe_chemicalComposition]
ALTER TABLE [dbo].[Pipe]  WITH CHECK ADD  CONSTRAINT [FK_Pipe_PipeMillSizeType] FOREIGN KEY([typeId])
REFERENCES [dbo].[PipeMillSizeType] ([id])
ALTER TABLE [dbo].[Pipe] CHECK CONSTRAINT [FK_Pipe_PipeMillSizeType]
ALTER TABLE [dbo].[Pipe]  WITH CHECK ADD  CONSTRAINT [FK_Pipe_Plate] FOREIGN KEY([plateId])
REFERENCES [dbo].[Plate] ([id])
ALTER TABLE [dbo].[Pipe] CHECK CONSTRAINT [FK_Pipe_Plate]
ALTER TABLE [dbo].[Pipe]  WITH CHECK ADD  CONSTRAINT [FK_Pipe_PurchaseOrder] FOREIGN KEY([purchaseOrderId])
REFERENCES [dbo].[PurchaseOrder] ([id])
ALTER TABLE [dbo].[Pipe] CHECK CONSTRAINT [FK_Pipe_PurchaseOrder]
ALTER TABLE [dbo].[Pipe]  WITH CHECK ADD  CONSTRAINT [FK_Pipe_Railcar] FOREIGN KEY([railcarId])
REFERENCES [dbo].[Railcar] ([id])
ALTER TABLE [dbo].[Pipe] CHECK CONSTRAINT [FK_Pipe_Railcar]
ALTER TABLE [dbo].[PipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_PipeTestResult_Pipe] FOREIGN KEY([pipeId])
REFERENCES [dbo].[Pipe] ([id])
ALTER TABLE [dbo].[PipeTestResult] CHECK CONSTRAINT [FK_PipeTestResult_Pipe]
ALTER TABLE [dbo].[PipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_PipeTestResult_PipeTest] FOREIGN KEY([pipeTestId])
REFERENCES [dbo].[PipeTest] ([id])
ALTER TABLE [dbo].[PipeTestResult] CHECK CONSTRAINT [FK_PipeTestResult_PipeTest]
ALTER TABLE [dbo].[PipeTestResult]  WITH CHECK ADD  CONSTRAINT [FK_PipeTestResult_TestResult] FOREIGN KEY([testResultId])
REFERENCES [dbo].[TestResult] ([id])
ALTER TABLE [dbo].[PipeTestResult] CHECK CONSTRAINT [FK_PipeTestResult_TestResult]
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_chemicalComposition] FOREIGN KEY([chemicalCompositionId])
REFERENCES [dbo].[ChemicalComposition] ([id])
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_chemicalComposition]
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_heat] FOREIGN KEY([heatId])
REFERENCES [dbo].[Heat] ([id])
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_heat]
ALTER TABLE [dbo].[TestResult_Inspector]  WITH CHECK ADD  CONSTRAINT [FK_TestResult_Inspector_Inspector] FOREIGN KEY([inspectorId])
REFERENCES [dbo].[Inspector] ([id])
ALTER TABLE [dbo].[TestResult_Inspector] CHECK CONSTRAINT [FK_TestResult_Inspector_Inspector]
ALTER TABLE [dbo].[TestResult_Inspector]  WITH CHECK ADD  CONSTRAINT [FK_TestResult_Inspector_TestResult] FOREIGN KEY([resultId])
REFERENCES [dbo].[TestResult] ([id])
ALTER TABLE [dbo].[TestResult_Inspector] CHECK CONSTRAINT [FK_TestResult_Inspector_TestResult]
ALTER TABLE [dbo].[Weld_Welder]  WITH CHECK ADD  CONSTRAINT [FK_Weld_Welder_Pipe] FOREIGN KEY([pipeId])
REFERENCES [dbo].[Pipe] ([id])
ALTER TABLE [dbo].[Weld_Welder] CHECK CONSTRAINT [FK_Weld_Welder_Pipe]
ALTER TABLE [dbo].[Weld_Welder]  WITH CHECK ADD  CONSTRAINT [FK_Weld_Welder_weld] FOREIGN KEY([weldId])
REFERENCES [dbo].[Weld] ([id])
ALTER TABLE [dbo].[Weld_Welder] CHECK CONSTRAINT [FK_Weld_Welder_weld]
ALTER TABLE [dbo].[Weld_Welder]  WITH CHECK ADD  CONSTRAINT [FK_Weld_Welder_welder] FOREIGN KEY([welderId])
REFERENCES [dbo].[Welder] ([id])
ALTER TABLE [dbo].[Weld_Welder] CHECK CONSTRAINT [FK_Weld_Welder_welder]

CREATE TABLE [Prizm].[dbo].[Coat](
	[id] [uniqueidentifier] NOT NULL,
	[date] [DateTime] NOT NULL,
	[type] [nvarchar](20) NOT NULL,
	[pipeId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Coat] PRIMARY KEY CLUSTERED ([id] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Coat_Pipe_FK] FOREIGN KEY (pipeId) REFERENCES [Prizm].[dbo].[Pipe] (id)
) ON [PRIMARY]

USE [master]
ALTER DATABASE [{DBNAME}] SET  READ_WRITE '
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DBNAME}', @PRIZMA_DB_NAME)
EXECUTE (@SQL_SCRIPT)
