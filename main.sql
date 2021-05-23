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

-------Улицы-------
--Пушкинская
--Шевченко
--Лермонтова
--Московская
--Киевская
--Школьная
--Советская
--Садовая

insert into Streets(Naz) values('Пушкинская')
insert into Streets(Naz) values('Шевченко')
insert into Streets(Naz) values('Лермонтова')
insert into Streets(Naz) values('Московская')
insert into Streets(Naz) values('Киевская')
insert into Streets(Naz) values('Школьная')
insert into Streets(Naz) values('Советская')
insert into Streets(Naz) values('Садовая')

go
Create table Towns
(
	TownID int not null Identity(1,1) Primary key,
	Naz nvarchar(20) not null
)
go
-------Города--------
--Харьков
--Киев
--Полтава
--Льввов
--Сумы
--Донецк
--Днепропетровск
--Херсон

insert into Towns(Naz) values('Харьков')
insert into Towns(Naz) values('Киев')
insert into Towns(Naz) values('Полтава')
insert into Towns(Naz) values('Львов')
insert into Towns(Naz) values('Сумы')
insert into Towns(Naz) values('Донецк')
insert into Towns(Naz) values('Днепропетровск')
insert into Towns(Naz) values('Херсон')



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

insert into Adress(UlicID, Dom, TownID) values(1,25,1) --Пушкинская 25 Харьков
insert into Adress(UlicID, Dom, TownID) values(2,117,2) --Шевченко 2 Киев
insert into Adress(UlicID, Dom, TownID) values(3,272,3) --Лермонтова 2 Полтава
insert into Adress(UlicID, Dom, TownID) values(4,4,4) --Московская 2 Льввов
insert into Adress(UlicID, Dom, TownID) values(5,6,5) --Киевская 2 Сумы
insert into Adress(UlicID, Dom, TownID) values(5,6,2) --Киевская 2 Киев

go

Create table Shops 
(
	ShopID int not null Identity(1,1) Primary key,
	DatOpen date not null Check(DatOpen >= '2017-05-28'), --Не более чем дата открытия первого магазина
	AdressID int not null,
	Foreign key (AdressID) References Adress(AdressID),
)
go
 
 insert into Shops(DatOpen, AdressID) values('2017-05-28', 1) --Пушкинская 25 Харьков
 insert into Shops(DatOpen, AdressID) values('2017-06-28', 2) --Шевченко 2 Киев
 insert into Shops(DatOpen, AdressID) values('2018-05-28', 3) --Лермонтова 2 Полтава
 insert into Shops(DatOpen, AdressID) values('2018-07-28', 4) --Московская 2 Льввов
 insert into Shops(DatOpen, AdressID) values('2019-04-28', 5) --Киевская 2 Сумы

go
Create table Kategory (
	KategoryID int not null Identity(1,1) Primary key,
	Naz nvarchar(30) not null,
)
go
use optik
go
-------категории товаров-----------
--контактные линзы
--оправы
--солнцезащитные очки
--средства для ухода
insert into Kategory(Naz) values('контактные линзы')
insert into Kategory(Naz) values('оправы')
insert into Kategory(Naz) values('солнцезащитные очки')
insert into Kategory(Naz) values('средства ухода')

go

Create table Products (
	ProductID int not null Identity(1,1) Primary key,
	Naz nvarchar(50) not null,
	KategoryID int not null,
	Counts int not null,
	Price int not null,
	Foreign key (KategoryID) References Kategory(KategoryID)
)

go
-----линзы----
insert into Products(Naz,KategoryID,Price,Counts) values('Air Optix plus HydraGlyde',1,242,10)
insert into Products(Naz,KategoryID,Price,Counts) values('Biofinity',1,250,5)
insert into Products(Naz,KategoryID,Price,Counts) values('Air Optix Night&Day Aqua',1,317,15)
insert into Products(Naz,KategoryID,Price,Counts) values('Ait Optix plus HydraGlyde',1,1080,20)
-----оправы----
insert into Products(Naz,KategoryID,Price,Counts) values('RAY-BAN RX 3447V 2500 50',2,4259,15)
insert into Products(Naz,KategoryID,Price,Counts) values('LUXOPTICA LXO 0047 BRN',2,599,30)
insert into Products(Naz,KategoryID,Price,Counts) values('CASTA CST1003 MBRN + Clip',2,1599,20)
insert into Products(Naz,KategoryID,Price,Counts) values('RAY-BAN RX 6378 2904 49',2,4559,10)
insert into Products(Naz,KategoryID,Price,Counts) values('LUXOPTICA LXO 0803 MSL',2,150,50)
-----солнцезащитные очки------
insert into Products(Naz,KategoryID,Price,Counts) values('RAY-BAN RB 4171 622/8G 54',3,4459,15)
insert into Products(Naz,KategoryID,Price,Counts) values('CASTA Casta F 431 GLD',3,400,40)
insert into Products(Naz,KategoryID,Price,Counts) values('POLAROID PLD PLD 6098/S',3,1819,25)
insert into Products(Naz,KategoryID,Price,Counts) values('LUXOPTICA LOS 105 BK',3,480,35)
insert into Products(Naz,KategoryID,Price,Counts) values('RAY-BAN RB 4146 901 51',3,5119,10)
-----средства ухода-----
insert into Products(Naz,KategoryID,Price,Counts) values('Раствор для линз Bausch & Lomb',4,103,60)
insert into Products(Naz,KategoryID,Price,Counts) values('Увлажняющие капли Avizor Moisture',4,253,55)
insert into Products(Naz,KategoryID,Price,Counts) values('Контейнер для контактных линз Baush',4,25,100)
insert into Products(Naz,KategoryID,Price,Counts) values('Пинцет для контактных линз',4,35,90)
go

Create table Positions (
	PositionID int not null Identity(1,1) Primary key,
	Naz nvarchar(30) not null,
	HoursPerWeek int not null Check(HoursPerWeek < 84), --7*12
	Rate int not null,
)
go
insert into Positions(Naz,HoursPerWeek,Rate) values('Стажер',30,6400)
insert into Positions(Naz,HoursPerWeek,Rate) values('Младший менеджер',35,9400)
insert into Positions(Naz,HoursPerWeek,Rate) values('Старший менджер',40,12800)
insert into Positions(Naz,HoursPerWeek,Rate) values('Гланвый менеджер',40,16400)

go
Create table Managers (
	ManagerID int not null Identity(1,1) Primary key,
	Fam nvarchar(30) not null,
	Iniz nvarchar(4) not null Check(Iniz like '[А-Я].[А-Я].'),
	PositionID int not null,
	ShopID int not null,
	Foreign key (PositionID) References Positions(PositionID),
	Foreign key (ShopID) References Shops(ShopID)
)
go

IF OBJECT_ID ('optik.TotalManagersInShop', 'TR') IS NOT NULL  
   DROP TRIGGER optik.TotalManagersInShop;  

go
Create trigger TotalManagersInShop
On Managers
After insert, update
AS
Begin
	declare @count int 
	Select @count = (
		Select count(Managers.ManagerID) from Managers
	)

	declare @shop int 
	select @shop =  (select ShopID from inserted)

	if (@count > 5 AND @shop = 1)
	begin 
		print('В 1 магазине не может быть больше 5 менеджеров')
		rollback transaction
	end
	else 
	begin
		print('Менеджер добавлен')
	end
	
end

go
--insert into Managers(Fam, Iniz, PositionID, ShopID) values('Пупкин', 'Д.И.', 2,1)
insert into Managers(Fam, Iniz, PositionID, ShopID) values('Кирова', 'М.И.', 2,1)
insert into Managers(Fam, Iniz, PositionID, ShopID) values('Васильев', 'К.С.', 2,1)
insert into Managers(Fam, Iniz, PositionID, ShopID) values('Иванов', 'А.В.', 2,1)
insert into Managers(Fam, Iniz, PositionID, ShopID) values('Пушкин', 'Б.В.', 2,1)
insert into Managers(Fam, Iniz, PositionID, ShopID) values('Шевченко', 'В.А.', 2,1)
insert into Managers(Fam, Iniz, PositionID, ShopID) values('Иванченко', 'И.И.', 1,2)
insert into Managers(Fam, Iniz, PositionID, ShopID) values('Петрова', 'П.П.', 3,2)

go

Create table Orders (
	OrderID int not null Identity(1,1) Primary key,
	Dat date not null,
	ManagerID int not null,
	TotalPrice int,
	Foreign key (ManagerID) References Managers(ManagerID),
)

Create table OrderDetail (
	id int not null Identity(1,1) Primary key,
	OrderID int not null,
	ProductID int not null,
	
	Foreign key (ProductID) References Products(ProductID),	
	Foreign key (OrderID) References Orders(OrderID)

)
go


IF OBJECT_ID ('optik.CreatingOrderPrice', 'TR') IS NOT NULL  
   DROP TRIGGER optik.CreatingOrderPrice;  

go

Create trigger CreatingOrderPrice
On OrderDetail
After insert, update
AS
Begin
	declare @price int 
	Select @price = (
		Select sum(products.Price) from Products, OrderDetail, Orders
		where products.ProductID = OrderDetail.ProductID and
		OrderDetail.OrderID = Orders.OrderID and
		Orders.OrderID in (select OrderID from inserted)
		)		
		update Orders
		set TotalPrice = @price 
		where Orders.OrderID in (select OrderID from inserted)

	
end

go

IF OBJECT_ID ('optik.CreatingOrderPriceDelete', 'TR') IS NOT NULL  
   DROP TRIGGER optik.CreatingOrderPriceDelete;  

go

Create trigger CreatingOrderPriceDelete
On OrderDetail
After delete
AS
Begin
	declare @price int 
	Select @price = (
		Select sum(products.Price) from Products, OrderDetail, Orders
		where products.ProductID = OrderDetail.ProductID and
		OrderDetail.OrderID = Orders.OrderID and
		Orders.OrderID in (select OrderID from deleted)
		)		
		update Orders
		set TotalPrice = @price 
		where Orders.OrderID in (select OrderID from deleted)

	
end

go

IF OBJECT_ID ('optik.NotMoreCount', 'TR') IS NOT NULL  
   DROP TRIGGER optik.NotMoreCount;  
GO

Create trigger NotMoreCount
on OrderDetail
After insert, update
AS
begin
	declare @count int
	declare @totalCount int

	select @count = (		
	Select COUNT(OrderDetail.ProductID) from OrderDetail
	where ProductID  in (select ProductID from inserted)
	)
	
	select @totalCount = (
		Select Products.Counts from Products
		where ProductID  in (select ProductID from inserted)
	)
	
	if(@count > @totalCount)
	begin
		print('На складе больше нет такого товара')
		rollback transaction
	end
	else 
	begin
		print('Товар добавлен')
	end


end
go

insert into Orders(Dat, ManagerID) values('2021-05-15',1)
insert into Orders(Dat, ManagerID) values('2021-02-15',2)
insert into Orders(Dat, ManagerID) values('2021-03-15',4)
insert into Orders(Dat, ManagerID) values('2021-02-16',3)
insert into Orders(Dat, ManagerID) values('2021-02-17',1)
insert into Orders(Dat, ManagerID) values('2021-02-18',1)
insert into Orders(Dat, ManagerID) values('2021-02-19',3)
insert into Orders(Dat, ManagerID) values('2021-02-20',3)
insert into Orders(Dat, ManagerID) values('2021-02-17',4)
go

insert into OrderDetail(OrderID, ProductID) values(1,2)
insert into OrderDetail(OrderID, ProductID) values(1,3)
insert into OrderDetail(OrderID, ProductID) values(1,4)

insert into OrderDetail(OrderID, ProductID) values(1,5)
insert into OrderDetail(OrderID, ProductID) values(1,8)
insert into OrderDetail(OrderID, ProductID) values(2,6)

go

if object_id('ProductInfoToDetail','v') is not null
drop view tst;
go
----предеставление о дополенной информации о деталях заказа
create view ProductInfoToDetail as
select id, OrderID, Products.Naz, Price, Kategory.Naz as Kategory
from OrderDetail
inner join Products
on OrderDetail.ProductID = Products.ProductID
inner join Kategory
on Products.KategoryID = Kategory.KategoryID
go

if object_id('ManagersAndOrders','v') is not null
drop view tst;
go
----представление о заказах и их менеджеров и их должностях
create view ManagersAndOrders as 
select OrderID, Dat, TotalPrice, Managers.Fam, Managers.Iniz, Positions.Naz
from Orders
inner join Managers
on Orders.ManagerID =  Managers.ManagerID
inner join Positions
on Managers.PositionID = Positions.PositionID

go

if object_id('ProductsSecondKat','v') is not null
drop view tst;
go
--пресдатвление о товарах 2й категории
create view ProductsSecondKat as 
select * from Products
where KategoryID = 2
go


if object_id('ProdBiggerInFirstShop','v') is not null
drop view tst;
go
--представление о товараха больше 1000грн купленных в 1м магазине
create view ProdBiggerInFirstShop as 
select Products.Naz, Products.KategoryID, Products.Counts, Products.Price, Managers.ShopID from Products
inner join OrderDetail
on  Products.ProductID = OrderDetail.ProductID
inner join Orders
on OrderDetail.OrderID = Orders.OrderID
inner join Managers
on Orders.ManagerID = Managers.ManagerID
where price > 1000 and ShopID = 1
go

if object_id('ManagersInKh','v') is not null
drop view tst;
go
--представление о менеджерах в Харькове
create view   ManagersInKh
as
select ManagerID, Fam, Iniz, PositionID, Towns.Naz from Managers
inner join Shops
on Managers.ShopID = Shops.ShopID 
inner join Adress
on Shops.AdressID = Adress.AdressID
inner join Towns
on Adress.TownID = Towns.TownID 
where Adress.TownID = 1

