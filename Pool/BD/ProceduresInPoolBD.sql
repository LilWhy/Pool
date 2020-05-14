CREATE PROCEDURE Add_Swimmer
	@Name VARCHAR(255),
	@Surname VARCHAR(255),
	@Familyname VARCHAR(255),
	@Date_of_birth date,
	@Category varchar(255)
AS
BEGIN
	INSERT  Swimmers ([Name], [Surname], [Familyname], [Date_of_birth], [Category])
	values
	(@Name, @Surname, @Familyname, @Date_of_birth, @Category);
END
go

-- при изменении, стирается все и изменяется. Нужна проверка на введенные данные на фронте

CREATE PROCEDURE Update_Swimmer
	@Name VARCHAR(255),
	@Surname VARCHAR(255),
	@Familyname VARCHAR(255),
	@Date_of_birth date,
	@Category varchar(255),

	@Change_Name VARCHAR(255),
	@Change_Surname VARCHAR(255),
	@Change_Familyname VARCHAR(255),
	@Change_Age date,
	@Change_Category varchar(255)
AS
BEGIN
	UPDATE Swimmers SET [Name] = @Change_Name,  Surname = @Change_Surname, Familyname = @Change_Familyname, Date_of_birth = @Change_Age, Category = @Change_Category
	WHERE Name = @Name AND Surname = @Surname AND  Familyname = @Familyname AND Date_of_birth = @Date_of_birth AND Category = @Category
END
go


CREATE PROCEDURE Dell_Swimmer
	@ID_swimmer int
AS
BEGIN
	Delete from Swimmer_time where ID_swimmer = @ID_swimmer
	Delete from Swimmers where ID_swimmer = @ID_swimmer
END
go


CREATE PROCEDURE Add_time_swimmer
	@Time Time,
	@Distance int,
	@Style varchar(255),
	@Date date,
	@ID_swimmer int
AS
BEGIN
	INSERT Swimmer_time ([ID_swimmer], [Time], [Distance], [Style], [Date])
	values
		(@ID_swimmer, @Time, @Distance, @Style, @Date)
END
go


CREATE PROCEDURE Update_time_swimmer
	@Time Time,
	@ID_swimmer int			
AS
	UPDATE Swimmer_time SET Time = @Time
	WHERE ID_swimmer = @ID_swimmer
go



CREATE PROCEDURE ORDER_BY_Category
AS
BEGIN
	SELECT	* FROM Swimmers ORDER BY Category
END
go

CREATE PROCEDURE ORDER_BY_Age
AS
BEGIN
	SELECT	* FROM Swimmers ORDER BY Date_of_birth
END
go

CREATE PROCEDURE ORDER_BY_Name
AS
BEGIN
	SELECT	* FROM Swimmers ORDER BY Name
END
go

CREATE PROCEDURE ORDER_BY_Surmane
AS
BEGIN
	SELECT	* FROM Swimmers ORDER BY Surname
END
go

CREATE PROCEDURE ORDER_BY_Familyname
AS
BEGIN
	SELECT	* FROM Swimmers ORDER BY Familyname
END
go