DROP TABLE Category
DROP TABLE DeliveryTypes
DROP TABLE Products
DROP TABLE Users
DROP TABLE Addresses

CREATE TABLE Products (
	Id int not null identity primary key,
	Name nvarchar(150) not null,
	ShortDescription nvarchar(300) not null,
	InStock bit not null
)

CREATE TABLE Category (
	Id int not null identity primary key,
	Name nvarchar(100) not null unique
)

CREATE TABLE DeliveryTypes (
	Id int not null identity primary key,
	Name nvarchar(50) not null unique
)

CREATE TABLE Addresses (
	Id int not null identity primary key,
	AddressLine nvarchar(100) not null,
	HouseNr smallint null,
	ZipCode char(5) not null,
	City nvarchar(50) not null
)

CREATE TABLE Users (
	Id int not null identity primary key,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email varchar(100) not null unique
)
GO

CREATE TABLE UserHashes (
	UserId int not null references Users(Id) primary key,
	UserHash varchar(max) not null,
	UserSalt varchar(max) not null
)

CREATE TABLE SubCategory (
	Id int not null identity primary key,
	Name nvarchar(100) not null unique,
	CategoryId int not null references Category(Id)
)

CREATE TABLE UserAddresses (
	Id int not null identity primary key,
	UserId int not null references Users(Id),
	AddressId int not null references Addresses(Id)
)

CREATE TABLE Orders (
	Id UNIQUEIDENTIFIER DEFAULT NEWID(),
	UserId int not null references Users(id),
	OrderDate datetimeoffset not null,
	OurReference nvarchar(100) null,
	Status nvarchar(50) not null,
	DeliveryTypeId int not null references DeliveryTypes(Id)
)
GO

CREATE TABLE OrderLines (
	OrderId UNIQUEIDENTIFIER DEFAULT NEWID(),
	ProductId int not null references Products(Id),
	Quantity int not null default 1,
	UnitPrice money not null default 0,
	primary key (OrderId, ProductId)
)

CREATE TABLE ProductDetails (
	Id int not null references Products(Id) primary key,
	LongDescription nvarchar(max) not null,
	Price money not null,
	ImageUrl nvarchar(max) not null,
	SubCategoryId int not null 
)
GO