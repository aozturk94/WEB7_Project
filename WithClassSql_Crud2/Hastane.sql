USE aHastane
GO
CREATE TABLE tblBolumler
(
	ID int IDENTITY(1,1) NOT NULL,
	BolumAd varchar(30) UNIQUE NOT NULL,
	PRIMARY KEY(ID)
)
GO

INSERT INTO tblBolumler
VALUES
	('Dahilliye'),('Noröloji'),('Ortopedi')
GO

CREATE TABLE tblDoktorlar
(
	ID int IDENTITY(1,1) NOT NULL,
	SicilNo varchar(10) UNIQUE NOT NULL,
	AdSoyad varchar(40) NOT NULL,
	Tel varchar(20) NULL,
	Mail varchar(30) NULL,
	BolumID int NOT NULL,
	PRIMARY KEY(ID),
	FOREIGN KEY (BolumID) REFERENCES tblBolumler(ID)
)

GO

INSERT INTO tblDoktorlar VALUES
('58564','Ali Can','11111111111','alican@gmail.com',1),
('25486','Demet Evgar','22222222222','demetevgar@gmail.com',1),
('59877','Sedat Kanar','33333333333','sedatkanar@gmail.com',3),
('33666','Ferhunde Hanım','44444444444','ferhundehanim@gmail.com',2),
('44147','Zafer Kimki','55555555555','zaferkimki@gmail.com',2)
