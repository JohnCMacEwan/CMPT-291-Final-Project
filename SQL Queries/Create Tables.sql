USE CMPT291_Project
GO

DROP TABLE Rented
DROP TABLE Employee
DROP TABLE Customer
DROP TABLE Car
DROP TABLE CarType
DROP TABLE Branch

CREATE TABLE Branch (
	BID int PRIMARY KEY IDENTITY(0, 1),
	BranchName varchar(max),
	StreetNo int,
	StreetName varchar(max),
	City varchar(max),
	Province varchar(max),
	Country varchar(max)
)

CREATE TABLE CarType (
	CarType int PRIMARY KEY IDENTITY(0, 1),
	TypeName varchar(max),
	Daily money,
	Weekly money,
	Monthly money
)

CREATE TABLE Car (
	VIN char(17) PRIMARY KEY,
	Brand varchar(max),
	Make varchar(max),
	LicensePlate varchar(10),
	CarType int FOREIGN KEY REFERENCES CarType(CarType),
	BID int FOREIGN KEY REFERENCES Branch(BID)
)

CREATE TABLE Customer (
	CID int PRIMARY KEY IDENTITY(0, 1),
	FirstName varchar(max),
	LastName varchar(max),
	DoB date,
	DriversLicense varchar(max),
	PhoneNo char(12)
)

CREATE TABLE Employee (
	EID int PRIMARY KEY IDENTITY(0, 1),
	FirstName varchar(max),
	LastName varchar(max),
	Salary money,
	BID int FOREIGN KEY REFERENCES BRANCH(BID)
)

CREATE TABLE RENTED (
	RID int PRIMARY KEY IDENTITY(0, 1),
	PickupDate date,
	PickupBID int FOREIGN KEY REFERENCES Branch(BID),
	DropoffDate date,
	DropoffBID int FOREIGN KEY REFERENCES Branch(BID),
	VIN char(17) FOREIGN KEY REFERENCES Car(VIN) ON DELETE CASCADE,
	CID int FOREIGN KEY REFERENCES Customer(CID),
	EID int FOREIGN KEY REFERENCES Employee(EID),
	TotalPrice money
)