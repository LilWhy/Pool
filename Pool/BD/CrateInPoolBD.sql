CREATE TABLE Swimmers (
	[ID_swimmer] int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] varchar(255) NOT NULL,
	[Surname] varchar(255) NOT NULL,
	[Familyname] varchar(255) NOT NULL,
	[Date_of_birth] DATE NOT NULL,
	[Category] varchar(255) NOT NULL
);
GO
CREATE TABLE Swimmer_time (
	[ID_swimmer_time] int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[ID_swimmer] int NOT NULL,
	[Time] TIME NOT NULL,
	[Distance] int NOT NULL,
	[Style] varchar(255) NOT NULL,
	[Date] date NOT NULL
);