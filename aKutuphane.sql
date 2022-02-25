CREATE DATABASE aKutuphane
USE aKutuphane

GO

CREATE TABLE tblTurler
(
	ID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	TurAd varchar(30) UNIQUE NOT NULL
)

GO

USE aKutuphane

INSERT INTO tblTurler VALUES

('Baþvuru'),
('Bilgisayar'),
('Edebiyat'),
('Ders Kitabý')

GO

USE aKutuphane

CREATE TABLE tblYazarlar
(
	ID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	AdSoyad varchar(30) NOT NULL,
	Cinsiyet varchar(1),
	DogumTarihi DATE,
	Uyruk varchar(7),
	OlumTarihi DATE,
	TurID int FOREIGN KEY REFERENCES tblTurler(ID) ON DELETE CASCADE --ON DELETE CASCADE silerken FOREIGN KEY'e denk gelen girdileri de silecek.
)

GO

USE aKutuphane

INSERT INTO tblYazarlar VALUES

	('Orhan Pamuk','E','1950-1-1','TC','1999-3-3',1),
	('Fyodor Dostoyevski','E','1821-11-11','FOREIGN','1999-3-3',2),
	('John Steinbeck','E','1902.02.27','FOREIGN','',3),
	('George Orwell','E','1903.06.25','FOREIGN','',4)

GO

USE aKutuphane
CREATE TABLE tblYayinevleri
(
	ID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Ad  varchar(40) UNIQUE NOT NULL,
	Adres varchar(50),
	Tel varchar(11)
)

GO
USE aKutuphane
INSERT INTO tblYayinevleri VALUES

	('SEL YAYINLARI','Beyoðlu','55555'),
	('CAN YAYINLARI','Bakýrköy','11111'),
	('TÜRKÝYE ÝÞ BANKASI KÜLTÜR YAYINLARI','Kadýköy','898989')

GO
USE aKutuphane
CREATE TABLE tblUyeler
(
	ID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	AdSoyad varchar(30) NOT NULL,
	Cinsiyet varchar(1),
	DogumTarihi DATE,
	UyelikTarihi DATE,
	UyelikTipi int,
	TcNo varchar(11) UNIQUE,
	Tel varchar(11),
	Mail varchar(40),
	Meslek varchar(40),
	EgitimDurumu int,
	CezaDurumu Bit
)

GO
USE aKutuphane
INSERT INTO tblUyeler VALUES
	
	('Ahmet Ekinci','E','1994-11-27','2011-11-27',1,'11111111111','05363636232','aekinci@outlook.com','Full-Stack Developer',3,0),
	('Ayþe Gürbüz','K','1995-5-17','2013-5-27',2,'22222222222','05073636265','aysebg@outlook.com','Developer',1,0),
	('Ceyda Sakarya','K','1995-5-17','2013-5-27',2,'33333333333','05363568422','ceycey@outlook.com','Öðretmen',4,0),
	('Demet Çolak','K','1995-5-17','2015-11-4',1,'44444444444','05563638252','demcolak@outlook.com','Öðrenci',2,0),
	('Ali Atay','E','1995-5-17','2016-5-5',2,'55555555555','0554363887','aliatay@outlook.com','Doktor',4,0)

GO
USE aKutuphane
CREATE TABLE tblKitaplar
(
	ISBN varchar(13) PRIMARY KEY NOT NULL,
	Ad varchar(50) NOT NULL,
	SayfaSayisi int,
	Stok int,
	TurID int NOT NULL,
	YazarID int NOT NULL,
	YayinEviID int NOT NULL,
	BasimTarihi DATE,
	KayitTarihi DATE,
	FOREIGN KEY (TurID) REFERENCES tblTurler(ID) ON DELETE CASCADE,
	FOREIGN KEY (YazarID) REFERENCES tblYazarlar(ID),
	FOREIGN KEY (YayinEviID) REFERENCES tblYayinevleri(ID) ON DELETE CASCADE
)

GO
USE aKutuphane
INSERT INTO tblKitaplar (ISBN, Ad, TurID, YazarID, YayinEviID) VALUES
	
	('44444','MASUMÝYET MÜZESÝ',2,3,2),
	('55555','SUÇ VE CEZA',3,1,1),
	('88888','FARELER VE ÝNSANLAR',4,2,1),
	('99999','1984',1,2,3),
	('77777','HAYVAN ÇÝFTLÝÐÝ',2,4,1)

GO
USE aKutuphane
CREATE TABLE tblOdunc
(
	ID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	UyeID int FOREIGN KEY REFERENCES tblUyeler(ID) ON DELETE CASCADE,
	KitapISBN varchar(13) FOREIGN KEY REFERENCES tblKitaplar(ISBN) ON DELETE CASCADE,
	VerilisTarihi DATE,
	TeslimTarihi DATE,
	Durum BIT
)

GO