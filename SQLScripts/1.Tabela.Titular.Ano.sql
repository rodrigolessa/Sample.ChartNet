USE [kadastro]
GO

/*	Trecho de Rollback do script:
    DROP TABLE [kadastro].[dbo].[TitularAno];
*/

CREATE TABLE [dbo].[TitularAno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titular] [varchar](250) NOT NULL,
	[2003] [int] NULL,
	[2004] [int] NULL,
	[2005] [int] NULL,
	[2006] [int] NULL,
	[2007] [int] NULL,
	[2008] [int] NULL,
	[2009] [int] NULL,
	[2010] [int] NULL,
	[2011] [int] NULL,
	[2012] [int] NULL,
	[2013] [int] NULL
)
GO

ALTER TABLE [dbo].[TitularAno] ADD CONSTRAINT [PK_TitularAno] PRIMARY KEY CLUSTERED ([Id] ASC)
GO

INSERT INTO [kadastro].[dbo].[TitularAno] VALUES ('QUALCOMM INCORPORATED (US)', 265, 226, 202, 280, 266, 34, 6, 1, 0, 0, 0)
INSERT INTO [kadastro].[dbo].[TitularAno] VALUES ('MICROSOFT CORPORATION (US)', 125, 248, 234, 265, 181, 4, 0, 0, 0, 0, 0)
INSERT INTO [kadastro].[dbo].[TitularAno] VALUES ('NOVARTIS AG (CH)', 104, 135, 130, 186, 187, 6, 1, 0, 0, 0, 0)
INSERT INTO [kadastro].[dbo].[TitularAno] VALUES ('3M INNOVATIVE PROPERTIES COMPANY (US)', 122, 183, 171, 168, 70, 2, 2, 7, 0, 1, 3)
INSERT INTO [kadastro].[dbo].[TitularAno] VALUES ('JOHNSON & JOHNSON (US)', 94, 113, 115, 243, 152, 8, 0, 0, 0, 0, 0)
INSERT INTO [kadastro].[dbo].[TitularAno] VALUES ('BASF AKTIENGESELLSCHAFT (DE)', 178, 202, 157, 164, 4, 0, 0, 0, 0, 0, 0)
INSERT INTO [kadastro].[dbo].[TitularAno] VALUES ('XEROX CORPORATION (US)', 83, 91, 90, 89, 87, 29, 27, 49, 38, 40, 38)
INSERT INTO [kadastro].[dbo].[TitularAno] VALUES ('THE PROCTER & GAMBLE COMPANY (US)', 111, 127, 158, 148, 101, 2, 1, 0, 0, 0, 0)
INSERT INTO [kadastro].[dbo].[TitularAno] VALUES ('THE GOODYEAR TIRE & RUBBER COMPANY (US)', 51, 85, 75, 67, 48, 72, 48, 47, 43, 35, 23)
INSERT INTO [kadastro].[dbo].[TitularAno] VALUES ('THOMSON LICENSING (FR)', 17, 134, 110, 108, 109, 38, 19, 11, 6, 12, 7)