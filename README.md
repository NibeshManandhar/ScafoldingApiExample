# ScafoldingApiExample

#DB Name EmployeeDB

USE [EmployeeDB]
GO

/****** Object:  Table [dbo].[Department]    Script Date: 16.02.2021 22:30:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Department]') AND type in (N'U'))
DROP TABLE [dbo].[Department]
GO

/****** Object:  Table [dbo].[Department]    Script Date: 16.02.2021 22:30:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Department](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



USE [EmployeeDB]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 16.02.2021 22:31:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
DROP TABLE [dbo].[Employee]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 16.02.2021 22:31:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[Employee] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](200) NULL,
	[Department] [varchar](200) NULL,
	[DateofJoining] [date] NULL,
	[PhotoFileName] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


USE EmployeeDB
CREATE TABLE [dbo].[student]
(Student_ID int NOT NULL,
Student_name varchar(255) NOT NULL,
City varchar(255),
Marks int
CONSTRAINT CompKey_ID_NAME_1 PRIMARY KEY (Student_ID, Student_name));



Scafolding command
Scaffold-DbContext -Connection Name=EmployeeDB Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force

Scaffold-DbContext "Server=.\;Database=EmployeeDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force
