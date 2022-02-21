﻿USE aHastane
CREATE TABLE tblRandevu
(
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	BolumID int NOT NULL,
	DoktorID int NOT NULL,
	HastaID int NOT NULL,
	Tarih DATE NOT NULL
	FOREIGN KEY (BolumID) REFERENCES tblBolumler(ID),
	FOREIGN KEY (DoktorID) REFERENCES tblDoktorlar(ID),
	FOREIGN KEY (HastaID) REFERENCES tblHastalar(ID)
)