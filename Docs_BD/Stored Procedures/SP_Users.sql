USE POSLyion
GO

CREATE PROC SP_CREATE_USER
@dni VARCHAR(30),
@full_name VARCHAR(100),
@email VARCHAR(155),
@username VARCHAR(30),
@password VARCHAR(155),
@role_id INT,
@phone VARCHAR(60),
@state BIT,
@message VARCHAR(360) OUTPUT,
@created_user_id INT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @created_user_id = 0
	IF NOT EXISTS (SELECT dni, username FROM Users WHERE dni = @dni OR username = @username)
	BEGIN
		INSERT INTO Users (dni, full_name, email, username, password, role_id, phone, state)
		VALUES (@dni, @full_name, @email, @username, @password, @role_id, @phone, @state)
		SET @created_user_id = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe un usuario con el mismo DNI o nombre de usuario. Por favor, verificar nuevamente.'
		SET @created_user_id = 0
	END
END
GO

/* TEST
SELECT * FROM USERS

DECLARE @created_user_id INT
DECLARE @message VARCHAR(360)

EXEC SP_CREATE_USER '43274499', 'full_name_prueba', 'emailprueba@hotmail.com', 'prueba_crud',
'123', 1, '3794902188', 1, @message OUTPUT, @created_user_id OUTPUT

SELECT @created_user_id
SELECT @message
*/

CREATE PROC SP_UPDATE_USER
@user_id INT,
@dni VARCHAR(30),
@full_name VARCHAR(100),
@email VARCHAR(155),
@username VARCHAR(30),
@password VARCHAR(155),
@role_id INT,
@phone VARCHAR(60),
@state BIT,
@message VARCHAR(360) OUTPUT,
@result BIT OUTPUT
AS
BEGIN
	IF NOT EXISTS (SELECT user_id, dni, username FROM Users WHERE user_id != @user_id AND (dni = @dni OR username = @username))
	BEGIN
		UPDATE Users SET
		dni = @dni,
		full_name = @full_name,
		email = @email,
		username = @username,
		password = @password,
		role_id = @role_id,
		phone = @phone,
		state = @state,
		modify_date = GETDATE()
		WHERE user_id = @user_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe un usuario con el mismo DNI o nombre de usuario. Por favor, verificar nuevamente.'
		SET @result = 0
	END
END
GO


/* TEST
SELECT * FROM USERS

DECLARE @result INT
DECLARE @message VARCHAR(360)

EXEC SP_UPDATE_USER 1002, '43274411', 'full_name_prueba', 'emailprueba@hotmail.com', 'prueba_crud',
'123', 1, '3794902111', 1, @message OUTPUT, @result OUTPUT

SELECT @result
SELECT @message
*/


CREATE PROC SP_DELETE_USER
@user_id INT,
@message VARCHAR(360) OUTPUT,
@result BIT OUTPUT
AS
BEGIN
	IF EXISTS (SELECT user_id FROM Users WHERE user_id = @user_id)
	BEGIN
		UPDATE Users
		SET state = 0
		WHERE user_id = @user_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra el usuario solicitado'
		SET @result = 0
	END
END
GO

/* TEST
SELECT * FROM USERS

DECLARE @result INT
DECLARE @message VARCHAR(360)

EXEC SP_DELETE_USER 1002, @message OUTPUT, @result OUTPUT

SELECT @result
SELECT @message
*/

CREATE PROC SP_RESTORE_USER
@user_id INT,
@message VARCHAR(360) OUTPUT,
@result INT OUTPUT
AS
BEGIN
	SET @message = ''
	IF EXISTS(SELECT user_id FROM Users WHERE user_id = @user_id)
	BEGIN
		UPDATE Users
		SET state = 1
		WHERE user_id = @user_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra el usuario solicitado'
		SET @result = 0
	END
END
GO

/* TEST
SELECT * FROM USERS

DECLARE @result INT
DECLARE @message VARCHAR(360)

EXEC SP_RESTORE_USER 1002, @message OUTPUT, @result OUTPUT

SELECT @result
SELECT @message
*/
