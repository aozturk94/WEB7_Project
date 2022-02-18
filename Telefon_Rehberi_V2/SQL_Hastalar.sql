CREATE DATABASE aHastane
GO

USE aHastane

GO

CREATE TABLE tblHastalar
(
	ID int IDENTITY(1,1) NOT NULL,
	TcNo char(11) UNIQUE NOT NULL,
	Ad varchar(20) NOT NULL,
	Soyad varchar(20) NOT NULL,
	Cinsiyet char(1) NOT NULL,
	Adres varchar(30) NULL,
	Telefon char(11) NULL,
	Mail varchar(30) NULL,
	PRIMARY KEY(ID)
)

GO

INSERT INTO tblHastalar
(TcNo,Ad,Soyad,Cinsiyet)
VALUES
('11111111111','Erencan','GERMİRLİ','E'),
('22222222222','Selin','FERGENÇ','K'),
('33333333333','Sadullah','KULLAR','E'),
('44444444444','Neşe','LİBALIK','K')

GO
