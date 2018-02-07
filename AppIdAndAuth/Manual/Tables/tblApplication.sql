﻿CREATE TABLE [dbo].[tblApplication]
(
    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    EnumName NVARCHAR(16),
	ProjectId BIGINT FOREIGN KEY REFERENCES tblProject(Id)
);
GO
