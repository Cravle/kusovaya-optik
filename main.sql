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
)
go

Create table TabShopToOwner
(
ShopID int foreign key references Shops(ShopID ),
OwnerID int foreign key references Owners(OwnerID ),
Primary Key (ShopID, OwnerID )
)
GO

Create table Kategory (
	KategoryID int not null Identity(1,1) Primary key,
	Naz int not null,
)
go

Create table Products (
	ProductID int not null Identity(1,1) Primary key,
	Naz nvarchar(30) not null,
	KategoryID int not null,
	Counts int not null,
	Foreign key (KategoryID) References Kategory(KategoryID)
)
go

Create table Positions (
	PositionID int not null Identity(1,1) Primary key,
	Naz nvarchar(30) not null,
	StandartHours int not null,
	Rate int not null,
	SalePercent int not null
)

Create table Managers (
	ManagerID int not null Identity(1,1) Primary key,
	Fam nvarchar(30) not null,
	Iniz nvarchar(4) not null,
	PositionID int not null,
	Foreign key (PositionID) References Positions(PositionID)
)

Create table Orders (
	OrderID int not null Identity(1,1) Primary key,
	Dat date not null,
	ProductID int not null,
	ShopID int not null,
	ManagerID int not null,
	AddFee int not null,
	Foreign key (ManagerID) References Managers(ManagerID),
	Foreign key (ProductID) References Products(ProductID),
	Foreign key (ShopID) References Shops(ShopID)
)