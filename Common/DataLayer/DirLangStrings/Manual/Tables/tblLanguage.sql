﻿CREATE TABLE tblLanguage (
    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    EnumName NVARCHAR(16), 
    UIName NVARCHAR(16),
	IsDeleted BIT NOT NULL DEFAULT(0)
);
GO