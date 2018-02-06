CREATE TABLE n2mOrderDriver(
    Id BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Order] BIGINT FOREIGN KEY REFERENCES tblOrder(Id),
    [Driver] BIGINT FOREIGN KEY REFERENCES tblDriver(Id),
);
GO
