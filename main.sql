use master
go
if exists(Select * From sys.databases Where name = 'optik')
begin
	Alter database optik set single_user with rollback immediate
	Drop database optik
end
Create Database optik
go

use optik
go

Create table Streets
(
	UlicID int not null Identity(1,1) Primary key,
	Naz nvarchar(40) not null
)

go
Create table Towns
(
	TownID int not null Identity(1,1) Primary key,
	Naz nvarchar(40) not null
)
go

Create table Owners
(
	OwnerID int not null Identity(1,1) Primary key,
	Imya nvarchar(20) not null,
	Iniz nvarchar(4),
	Dolya int,
)

go

Create table Adress
(
	AdressID int not null Identity(1,1) Primary key,
	UlicID int not null,
	Dom int not null,
	TownID int not null, 
	Foreign key (UlicID) References Streets(UlicID),
	Foreign key (TownID) References Towns(TownID),
)
go

Create table Shops 
(
	ShopID int not null Identity(1,1) Primary key,
	AdressID int not null,
	OwnerID int not null,
	Foreign key (AdressID) References Adress(AdressID),
	Foreign key (OwnerID) References Owners(OwnerID),
)
go