
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='DB_SOF_01')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'DB_SOF_01') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [DB_SOF_01]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [DB_SOF_01]
GO

USE [DB_SOF_01]
GO

USE [DB_SOF_01]
GO

/****** Object:  Table [dbo].[TABLE]    Script Date: 5/21/2019 11:17:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TABLE](
	[ID_TAB] [nvarchar](10) NOT NULL,
	[NUMBER] [nvarchar](10) NOT NULL,
	[AREA] [nvarchar](10) NOT NULL,
	[LIMIT] [int] NOT NULL,
	[STATUS] [int] NOT NULL,
 CONSTRAINT [PK_TABLE] PRIMARY KEY CLUSTERED 
(
	[ID_TAB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [DB_SOF_01]
GO

/****** Object:  Table [dbo].[USER]    Script Date: 5/14/2019 10:08:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[USER](
	[ID_EMP] [nvarchar](10) NOT NULL,
	[NAME] [nvarchar](50) NOT NULL,
	[TYPE] [nvarchar](50) NOT NULL,
	[USERNAME] [nvarchar](50) NOT NULL,
	[PASSWORD] [nvarchar](10) NOT NULL,
	[DATESTART] [datetime2](7) NOT NULL,
	[ADDRESS] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[ID_EMP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [DB_SOF_01]
GO

USE [DB_SOF_01]
GO

/****** Object:  Table [dbo].[FOOD]    Script Date: 5/17/2019 7:51:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FOOD](
	[ID_FOD] [nvarchar](10) NOT NULL,
	[ID_CAT] [nvarchar](10) NOT NULL,
	[DISPLAYNAME] [nvarchar](50) NOT NULL,
	[OUTPUTPRICE] [money] NOT NULL
) ON [PRIMARY]
GO


USE [DB_SOF_01]
GO

/****** Object:  Table [dbo].[FOOD_CATEGORY]    Script Date: 5/17/2019 7:51:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FOOD_CATEGORY](
	[ID_CAT] [nvarchar](10) NOT NULL,
	[DISPLAYNAME] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

USE [DB_SOF_01]
GO

/****** Object:  Table [dbo].[UNIT]    Script Date: 5/14/2019 4:13:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UNIT](
	[ID_UNI] [nvarchar](11) NOT NULL,
	[DISPLAYNAME] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_UNIT] PRIMARY KEY CLUSTERED 
(
	[ID_UNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[SUPLIER]    Script Date: 5/14/2019 4:13:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SUPLIER](
	[ID_SUP] [nvarchar](11) NOT NULL,
	[DISPLAYNAME] [nvarchar](40) NOT NULL,
	[ADDRESS] [nvarchar](50) NOT NULL,
	[PHONENUMBER] [nvarchar](11) NOT NULL,
	[CONTRACTDATE] [datetime] NOT NULL,
 CONSTRAINT [PK_SUPLIER] PRIMARY KEY CLUSTERED 
(
	[ID_SUP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[OBJECT]    Script Date: 5/14/2019 4:13:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OBJECT](
	[ID_OBJ] [nvarchar](11) NOT NULL,
	[DISPLAYNAME] [nvarchar](30) NOT NULL,
	[ID_SUP] [nvarchar](11) NOT NULL,
	[ID_UNI] [nvarchar](11) NOT NULL,
	[NUM_REPO] [int] NOT NULL,
 CONSTRAINT [PK_OBJECT] PRIMARY KEY CLUSTERED 
(
	[ID_OBJ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OBJECT]  WITH CHECK ADD  CONSTRAINT [FK_OBJECT_SUPLIER] FOREIGN KEY([ID_SUP])
REFERENCES [dbo].[SUPLIER] ([ID_SUP])
GO

/****** Object:  Table [dbo].[INPUT]    Script Date: 5/14/2019 4:14:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[INPUT](
	[ID_INP] [nvarchar](11) NOT NULL,
	[DATEINPUT] [datetime] NOT NULL,
 CONSTRAINT [PK_INPUT] PRIMARY KEY CLUSTERED 
(
	[ID_INP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[INPUT_INFO]    Script Date: 5/14/2019 4:14:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[INPUT_INFO](
	[ID_INF] [nvarchar](11) NOT NULL,
	[ID_INP] [nvarchar](11) NOT NULL,
	[ID_OBJ] [nvarchar](11) NOT NULL,
	[ID_EMP] [nvarchar](11) NOT NULL,
	[COUNT] [int] NOT NULL,
	[INPUTPRICE] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_INPUT_INFO] PRIMARY KEY CLUSTERED 
(
	[ID_INF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[INPUT_INFO]  WITH CHECK ADD  CONSTRAINT [FK_INPUT_INFO_INPUT] FOREIGN KEY([ID_INP])
REFERENCES [dbo].[INPUT] ([ID_INP])
GO

ALTER TABLE [dbo].[INPUT_INFO] CHECK CONSTRAINT [FK_INPUT_INFO_INPUT]
GO

ALTER TABLE [dbo].[INPUT_INFO]  WITH CHECK ADD  CONSTRAINT [FK_INPUT_INFO_OBJECT] FOREIGN KEY([ID_OBJ])
REFERENCES [dbo].[OBJECT] ([ID_OBJ])
GO

ALTER TABLE [dbo].[INPUT_INFO] CHECK CONSTRAINT [FK_INPUT_INFO_OBJECT]
GO


USE [DB_SOF_01]
GO

/****** Object:  Table [dbo].[BILL]    Script Date: 5/17/2019 7:52:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BILL](
	[ID_BIL] [nvarchar](10) NOT NULL,
	[DATETIME] [datetime2](7) NOT NULL,
	[ID_EMP] [nvarchar](10) NOT NULL,
	[ID_TAB] [nvarchar](10) NOT NULL,
	[STATUS] [nvarchar](10) NULL,
	[SUMPRICE] [money] NOT NULL,
	[SUBPRICE] [money] NOT NULL,
 CONSTRAINT [PK_BILL] PRIMARY KEY CLUSTERED 
(
	[ID_BIL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [DB_SOF_01]
GO

/****** Object:  Table [dbo].[BILL_INFO]    Script Date: 5/17/2019 7:52:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BILL_INFO](
	[ID_BILF] [nvarchar](10) NOT NULL,
	[ID_FOD] [nvarchar](10) NOT NULL,
	[ID_BIL] [nvarchar](10) NOT NULL,
	[COUNT] [int] NOT NULL,
	[PRICE] [money] NOT NULL,
 CONSTRAINT [PK_BILL_INFO] PRIMARY KEY CLUSTERED 
(
	[ID_BILF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--insert value

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[UNIT] ([ID_UNI], [DISPLAYNAME]) VALUES ('UN01','Kilogam')
GO
INSERT INTO [dbo].[UNIT] ([ID_UNI], [DISPLAYNAME]) VALUES ('UN02','gam')
GO
INSERT INTO [dbo].[UNIT] ([ID_UNI], [DISPLAYNAME]) VALUES ('UN03','Miligam')
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB01', '01', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB02', '02', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB03', '03', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB04', '04', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB05', '05', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB06', '06', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB07', '07', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB08', '08', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB09', '09', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB10', '10', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB11', '11', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB12', '12', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB13', '13', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB14', '14', 'AR1', 2, 0)
GO
INSERT INTO [dbo].[TABLE] ([ID_TAB], [NUMBER], [AREA], [LIMIT], [STATUS])
     VALUES ('TB15', '15', 'AR1', 2, 0)
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[USER]
           ([ID_EMP]
           ,[NAME]
           ,[TYPE]
           ,[USERNAME]
           ,[PASSWORD]
           ,[DATESTART]
           ,[ADDRESS])
     VALUES ('U01', 'Arina', 'E01', 'em01', '1', '9/9/2019', 'HCM')
GO

INSERT INTO [dbo].[USER]
           ([ID_EMP]
           ,[NAME]
           ,[TYPE]
           ,[USERNAME]
           ,[PASSWORD]
           ,[DATESTART]
           ,[ADDRESS])
     VALUES ('U02', 'Nami', 'E02', 'em02', '2', '9/9/2019', 'HCM')
GO

INSERT INTO [dbo].[USER]
           ([ID_EMP]
           ,[NAME]
           ,[TYPE]
           ,[USERNAME]
           ,[PASSWORD]
           ,[DATESTART]
           ,[ADDRESS])
     VALUES ('U03', 'Dari', 'E03', 'em03', '3', '9/9/2019', 'HCM')
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[SUPLIER]
           ([ID_SUP]
           ,[DISPLAYNAME]
           ,[ADDRESS]
           ,[PHONENUMBER]
           ,[CONTRACTDATE])
     VALUES
           ('SU04'
           ,'SUP_SUGAR'
           ,'HCM'
           ,'0123456789'
           ,'1/1/2018')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[SUPLIER]
           ([ID_SUP]
           ,[DISPLAYNAME]
           ,[ADDRESS]
           ,[PHONENUMBER]
           ,[CONTRACTDATE])
     VALUES
           ('SU01'
           ,'SUP_SUGAR'
           ,'HCM'
           ,'0123456789'
           ,'1/1/2018')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[SUPLIER]
           ([ID_SUP]
           ,[DISPLAYNAME]
           ,[ADDRESS]
           ,[PHONENUMBER]
           ,[CONTRACTDATE])
     VALUES
           ('SU02'
           ,'SUP_MILK'
           ,'HCM'
           ,'0123456789'
           ,'1/1/2018')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[SUPLIER]
           ([ID_SUP]
           ,[DISPLAYNAME]
           ,[ADDRESS]
           ,[PHONENUMBER]
           ,[CONTRACTDATE])
     VALUES
           ('SU03'
           ,'SUP_TEA'
           ,'HCM'
           ,'0123456789'
           ,'1/1/2018')
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[OBJECT]
           ([ID_OBJ]
           ,[DISPLAYNAME]
           ,[ID_SUP]
           ,[ID_UNI]
           ,[NUM_REPO])
     VALUES
           ('OB01'
           ,'Sugar_A'
           ,'SU01'
           ,'UN01'
           ,15)
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[OBJECT]
           ([ID_OBJ]
           ,[DISPLAYNAME]
           ,[ID_SUP]
           ,[ID_UNI]
           ,[NUM_REPO])
     VALUES
           ('OB02'
           ,'Sugar_B'
           ,'SU01'
           ,'UN01'
           ,15)
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[OBJECT]
           ([ID_OBJ]
           ,[DISPLAYNAME]
           ,[ID_SUP]
           ,[ID_UNI]
           ,[NUM_REPO])
     VALUES
           ('OB03'
           ,'Milk_A'
           ,'SU02'
           ,'UN02'
           ,15)
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[OBJECT]
           ([ID_OBJ]
           ,[DISPLAYNAME]
           ,[ID_SUP]
           ,[ID_UNI]
           ,[NUM_REPO])
     VALUES
           ('OB04'
           ,'Milk_B'
           ,'SU02'
           ,'UN02'
           ,15)
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[OBJECT]
           ([ID_OBJ]
           ,[DISPLAYNAME]
           ,[ID_SUP]
           ,[ID_UNI]
           ,[NUM_REPO])
     VALUES
           ('OB05'
           ,'Tea_A'
           ,'SU03'
           ,'UN02'
           ,15)
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[OBJECT]
           ([ID_OBJ]
           ,[DISPLAYNAME]
           ,[ID_SUP]
           ,[ID_UNI]
           ,[NUM_REPO])
     VALUES
           ('OB06'
           ,'Tea_B'
           ,'SU03'
           ,'UN02'
           ,15)
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[OBJECT]
           ([ID_OBJ]
           ,[DISPLAYNAME]
           ,[ID_SUP]
           ,[ID_UNI]
           ,[NUM_REPO])
     VALUES
           ('OB07'
           ,'Sugar_C'
           ,'SU01'
           ,'UN01'
           ,15)
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[INPUT]
           ([ID_INP]
           ,[DATEINPUT])
     VALUES
           ('IP001'
           ,'6/1/2019')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[INPUT]
           ([ID_INP]
           ,[DATEINPUT])
     VALUES
           ('IP002'
           ,'6/1/2019')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[INPUT]
           ([ID_INP]
           ,[DATEINPUT])
     VALUES
           ('IP003'
           ,'6/1/2019')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[INPUT]
           ([ID_INP]
           ,[DATEINPUT])
     VALUES
           ('IP004'
           ,'6/1/2019')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[INPUT]
           ([ID_INP]
           ,[DATEINPUT])
     VALUES
           ('IP005'
           ,'6/1/2019')
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[INPUT_INFO]
           ([ID_INF]
           ,[ID_INP]
           ,[ID_OBJ]
           ,[ID_EMP]
           ,[COUNT]
           ,[INPUTPRICE])
     VALUES
           ('IF001'
           ,'IP001'
           ,'OB01'
           ,'U02'
           ,10
           ,'100000')
GO

INSERT INTO [dbo].[INPUT_INFO]
           ([ID_INF]
           ,[ID_INP]
           ,[ID_OBJ]
           ,[ID_EMP]
           ,[COUNT]
           ,[INPUTPRICE])
     VALUES
           ('IF003'
           ,'IP001'
           ,'OB02'
           ,'U02'
           ,10
           ,'100000')
GO


INSERT INTO [dbo].[INPUT_INFO]
           ([ID_INF]
           ,[ID_INP]
           ,[ID_OBJ]
           ,[ID_EMP]
           ,[COUNT]
           ,[INPUTPRICE])
     VALUES
           ('IF003'
           ,'IP001'
           ,'OB02'
           ,'U02'
           ,10
           ,'100000')
GO


INSERT INTO [dbo].[INPUT_INFO]
           ([ID_INF]
           ,[ID_INP]
           ,[ID_OBJ]
           ,[ID_EMP]
           ,[COUNT]
           ,[INPUTPRICE])
     VALUES
           ('IF004'
           ,'IP002'
           ,'OB02'
           ,'U02'
           ,10
           ,'100000')
GO

INSERT INTO [dbo].[INPUT_INFO]
           ([ID_INF]
           ,[ID_INP]
           ,[ID_OBJ]
           ,[ID_EMP]
           ,[COUNT]
           ,[INPUTPRICE])
     VALUES
           ('IF005'
           ,'IP002'
           ,'OB03'
           ,'U02'
           ,10
           ,'100000')
GO


INSERT INTO [dbo].[INPUT_INFO]
           ([ID_INF]
           ,[ID_INP]
           ,[ID_OBJ]
           ,[ID_EMP]
           ,[COUNT]
           ,[INPUTPRICE])
     VALUES
           ('IF006'
           ,'IP003'
           ,'OB01'
           ,'U02'
           ,10
           ,'100000')
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[FOOD_CATEGORY]
           ([ID_CAT]
           ,[DISPLAYNAME])
     VALUES
           ('CA01'
           ,'Espresso')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[FOOD_CATEGORY]
           ([ID_CAT]
           ,[DISPLAYNAME])
     VALUES
           ('CA02'
           ,'Coffee')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[FOOD_CATEGORY]
           ([ID_CAT]
           ,[DISPLAYNAME])
     VALUES
           ('CA03'
           ,'Milk ')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[FOOD_CATEGORY]
           ([ID_CAT]
           ,[DISPLAYNAME])
     VALUES
           ('CA04'
           ,'Macha')
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[FOOD_CATEGORY]
           ([ID_CAT]
           ,[DISPLAYNAME])
     VALUES
           ('CA05'
           ,'PinkTea')
GO



USE [DB_SOF_01]
GO

INSERT INTO [dbo].[FOOD]
           ([ID_FOD]
           ,[ID_CAT]
           ,[DISPLAYNAME]
           ,[OUTPUTPRICE])
     VALUES
           ('F01'
           ,'CA01'
           ,'Cappucino'
           ,10)
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[FOOD]
           ([ID_FOD]
           ,[ID_CAT]
           ,[DISPLAYNAME]
           ,[OUTPUTPRICE])
     VALUES
           ('F02'
           ,'CA01'
           ,'Americano'
           ,10)
GO

INSERT INTO [dbo].[FOOD]
           ([ID_FOD]
           ,[ID_CAT]
           ,[DISPLAYNAME]
           ,[OUTPUTPRICE])
     VALUES
           ('F03'
           ,'CA01'
           ,'Late'
           ,20)
GO

INSERT INTO [dbo].[FOOD]
           ([ID_FOD]
           ,[ID_CAT]
           ,[DISPLAYNAME]
           ,[OUTPUTPRICE])
     VALUES
           ('F04'
           ,'CA02'
           ,'Coffee Phin'
           ,20)
GO

INSERT INTO [dbo].[FOOD]
           ([ID_FOD]
           ,[ID_CAT]
           ,[DISPLAYNAME]
           ,[OUTPUTPRICE])
     VALUES
           ('F05'
           ,'CA02'
           ,'Coffee Cool'
           ,20)
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[BILL]
           ([ID_BIL]
           ,[DATETIME]
           ,[ID_EMP]
           ,[ID_TAB]
           ,[STATUS]
           ,[SUMPRICE]
           ,[SUBPRICE])
     VALUES
           ('B01'
           ,'6/1/2019'
           ,'U02'
           ,'TB01'
           ,'DONE'
           ,50
           ,0)
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[BILL]
           ([ID_BIL]
           ,[DATETIME]
           ,[ID_EMP]
           ,[ID_TAB]
           ,[STATUS]
           ,[SUMPRICE]
           ,[SUBPRICE])
     VALUES
           ('B02'
           ,'6/1/2019'
           ,'U02'
           ,'TB02'
           ,'DONE'
           ,60
           ,0)
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[BILL]
           ([ID_BIL]
           ,[DATETIME]
           ,[ID_EMP]
           ,[ID_TAB]
           ,[STATUS]
           ,[SUMPRICE]
           ,[SUBPRICE])
     VALUES
           ('B03'
           ,'6/1/2019'
           ,'U02'
           ,'TB01'
           ,'DONE'
           ,100
           ,0)
GO

USE [DB_SOF_01]
GO

INSERT INTO [dbo].[BILL]
           ([ID_BIL]
           ,[DATETIME]
           ,[ID_EMP]
           ,[ID_TAB]
           ,[STATUS]
           ,[SUMPRICE]
           ,[SUBPRICE])
     VALUES
           ('B04'
           ,'5/1/2019'
           ,'U02'
           ,'TB05'
           ,'DONE'
           ,50
           ,0)
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[BILL]
           ([ID_BIL]
           ,[DATETIME]
           ,[ID_EMP]
           ,[ID_TAB]
           ,[STATUS]
           ,[SUMPRICE]
           ,[SUBPRICE])
     VALUES
           ('B05'
           ,'5/10/2019'
           ,'U02'
           ,'TB06'
           ,'DONE'
           ,100
           ,0)
GO


USE [DB_SOF_01]
GO

INSERT INTO [dbo].[BILL_INFO]
           ([ID_BILF]
           ,[ID_FOD]
           ,[ID_BIL]
           ,[COUNT]
           ,[PRICE])
     VALUES
           ('BF01'
           ,'F01'
           ,'B01'
           ,4
           ,40)
GO

INSERT INTO [dbo].[BILL_INFO]
           ([ID_BILF]
           ,[ID_FOD]
           ,[ID_BIL]
           ,[COUNT]
           ,[PRICE])
     VALUES
           ('BF02'
           ,'F01'
           ,'B01'
           ,1
           ,10)
GO

INSERT INTO [dbo].[BILL_INFO]
           ([ID_BILF]
           ,[ID_FOD]
           ,[ID_BIL]
           ,[COUNT]
           ,[PRICE])
     VALUES
           ('BF03'
           ,'F02'
           ,'B02'
           ,6
           ,60)
GO

INSERT INTO [dbo].[BILL_INFO]
           ([ID_BILF]
           ,[ID_FOD]
           ,[ID_BIL]
           ,[COUNT]
           ,[PRICE])
     VALUES
           ('BF04'
           ,'F03'
           ,'B03'
           ,2
           ,40)
GO

INSERT INTO [dbo].[BILL_INFO]
           ([ID_BILF]
           ,[ID_FOD]
           ,[ID_BIL]
           ,[COUNT]
           ,[PRICE])
     VALUES
           ('BF05'
           ,'F04'
           ,'B03'
           ,1
           ,20)
GO


INSERT INTO [dbo].[BILL_INFO]
           ([ID_BILF]
           ,[ID_FOD]
           ,[ID_BIL]
           ,[COUNT]
           ,[PRICE])
     VALUES
           ('BF06'
           ,'F01'
           ,'B04'
           ,1
           ,10)
GO

INSERT INTO [dbo].[BILL_INFO]
           ([ID_BILF]
           ,[ID_FOD]
           ,[ID_BIL]
           ,[COUNT]
           ,[PRICE])
     VALUES
           ('BF07'
           ,'F02'
           ,'B04'
           ,1
           ,10)
GO

INSERT INTO [dbo].[BILL_INFO]
           ([ID_BILF]
           ,[ID_FOD]
           ,[ID_BIL]
           ,[COUNT]
           ,[PRICE])
     VALUES
           ('BF09'
           ,'F03'
           ,'B05'
           ,1
           ,20)
GO

INSERT INTO [dbo].[BILL_INFO]
           ([ID_BILF]
           ,[ID_FOD]
           ,[ID_BIL]
           ,[COUNT]
           ,[PRICE])
     VALUES
           ('BF11'
           ,'F04'
           ,'B05'
           ,1
           ,20)
GO

INSERT INTO [dbo].[BILL_INFO]
           ([ID_BILF]
           ,[ID_FOD]
           ,[ID_BIL]
           ,[COUNT]
           ,[PRICE])
     VALUES
           ('BF12'
           ,'F01'
           ,'B05'
           ,1
           ,10)
GO