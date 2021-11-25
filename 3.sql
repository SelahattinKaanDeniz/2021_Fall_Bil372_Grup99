create table Personel
(
	PersonelID varchar(11) not null,
	Cinsiyet varchar(12) not null,
	Maas varchar(9) not null,
	DogumTarihi date not null,
	Ad varchar(30) not null,
	Soyad varchar(15) not null,
	Egitim varchar(80) not null,
	TCNO varchar(11) not null,
	SGN varchar(11) not null,
	IseAlimTarihi date not null,
	TelefonNO varchar(13) not null,
	Adres varchar(200) not null,
	Eposta varchar(50) not null,
	primary key (PersonelID)
)

create table Ucak
(
	UcakID varchar(11) not null,
	Model varchar(50) not null,
	YolcuKapasitesi varchar(10) not null,
	Agirlik varchar(10) not null,
	UreticiFirma varchar(50) not null,
	UretimYili varchar(10) not null,
	primary key (UcakID)
)

create table Murettebat
(
	MurettebatID varchar(11) not null,
	UcakID varchar(11) not null,
	PersonelID varchar(11) not null,
	YabanciDil varchar(80) not null,
	UcusSuresi varchar(20) not null,
	primary key (MurettebatID),
	foreign key (UcakID) references Ucak(UcakID),
	foreign key (PersonelID) references Personel(PersonelID)
)

create table Pilot
(
	MurettebatID varchar(11) not null,
	UcakID varchar(11) not null,
	PersonelID varchar(11) not null,
	LisansTuru varchar(20) not null,
	PilotRolu varchar(20) not null,
	foreign key (UcakID) references Ucak(UcakID),
	foreign key (PersonelID) references Personel(PersonelID),
	foreign key (MurettebatID) references Murettebat(MurettebatID)
)

create table KabinMemuru
(
	MurettebatID varchar(11) not null,
	UcakID varchar(11) not null,
	PersonelID varchar(11) not null,
	MedeniDurumu varchar(20) not null,
	foreign key (UcakID) references Ucak(UcakID),
	foreign key (PersonelID) references Personel(PersonelID),
	foreign key (MurettebatID) references Murettebat(MurettebatID)
)


create table Sefer
(
	SeferID varchar(11) not null,
	UcakID varchar(11) not null,
	UcusSuresi varchar(20) not null,
	SeferTarihi date not null,
	VarisZamani varchar(10) not null,
	KalkisZamani varchar(10) not null,
	VarisYeri varchar(100) not null,
	KalkisYeri varchar(100) not null,
	primary key (SeferID),
	foreign key (UcakID) references Ucak(UcakID)
)

create table Servis
(
	ServisID varchar(11) not null ,
	UcakID varchar(11) not null ,
	BaslangicTarihi varchar(11) not null,
	BitisTarihi date  not null,
	primary key (ServisID),
	foreign key (UcakID) references Ucak(UcakID)
)

create table GenelBakim
(
	PersonelID varchar(11) not null,
	ServisID varchar(11) not null,
	UcakID varchar(11) not null,
	BakimTuru varchar(11) not null,
	foreign key (UcakID) references Ucak(UcakID),
	foreign key (ServisID) references Servis(ServisID),
	foreign key (PersonelID) references Personel(PersonelID)
)

create table Tamir
(
	PersonelID varchar(11) not null,
	ServisID varchar(11) not null,
	UcakID varchar(11) not null,
	KazaTarihi varchar(11) not null,
	KazaSebebi varchar(11) not null,
	TamirSonucu varchar(11) not null,
	foreign key (UcakID) references Ucak(UcakID),
	foreign key (ServisID) references Servis(ServisID),
	foreign key (PersonelID) references Personel(PersonelID)
)

create table TamirPersoneli
(
	PersonelID varchar(11) not null,
	Uzmanlik varchar(11) not null,
	foreign key (PersonelID) references Personel(PersonelID)
)

create table ServisPersoneli
(
	PersonelID varchar(11) not null,
	CalistigiHavalimani varchar(11) not null,
	foreign key (PersonelID) references Personel(PersonelID)
)

create table GenelBakimTeknisyeni
(
	PersonelID varchar(11) not null,
	TeknisyenDerecesi varchar(11) not null
	foreign key (PersonelID) references Personel(PersonelID)
)


