USE [CompanyDataBase]
GO
/****** Object:  Table [dbo].[Departments]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_dbo.Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employeers]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employeers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FerstName] [nvarchar](50) NULL,
	[SecondName] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Mail] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_dbo.Employeers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DepVsEmplLink]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepVsEmplLink](
	[DepID] [int] NOT NULL,
	[EmplID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_DepVsEmplLink_Departments]    Script Date:******/
ALTER TABLE [dbo].[DepVsEmplLink]  WITH CHECK ADD  CONSTRAINT [FK_DepVsEmplLink_Departments] FOREIGN KEY([DepID])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[DepVsEmplLink] CHECK CONSTRAINT [FK_DepVsEmplLink_Departments]
GO
/****** Object:  ForeignKey [FK_DepVsEmplLink_Employeers]    Script Date:******/
ALTER TABLE [dbo].[DepVsEmplLink]  WITH CHECK ADD  CONSTRAINT [FK_DepVsEmplLink_Employeers] FOREIGN KEY([EmplID])
REFERENCES [dbo].[Employeers] ([Id])
GO
ALTER TABLE [dbo].[DepVsEmplLink] CHECK CONSTRAINT [FK_DepVsEmplLink_Employeers]
GO
