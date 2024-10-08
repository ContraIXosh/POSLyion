CREATE PROC SP_CREATE_CUSTOMER
	@dni VARCHAR(40),
	@full_name VARCHAR(100),
	@email VARCHAR(155),
	@phone VARCHAR(60),
	@message VARCHAR(360) OUTPUT,
	@created_customer_id INT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @created_customer_id = 0
	IF NOT EXISTS (SELECT * FROM Customers WHERE dni = @dni)
	BEGIN
		INSERT INTO Customers(dni, full_name, email, phone)
		VALUES(@dni, @full_name, @email, @phone)
		SET @created_customer_id = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe un cliente con el mismo DNI.'
	END
END
GO

CREATE PROC SP_UPDATE_CUSTOMER
	@customer_id INT,
	@dni VARCHAR(40),
	@full_name VARCHAR(100),
	@email VARCHAR(155),
	@phone VARCHAR(60),
	@state BIT,
	@message VARCHAR(360) OUTPUT,
	@result BIT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @result = 0
	IF NOT EXISTS (SELECT * FROM Customers WHERE dni = @dni AND customer_id != @customer_id)
	BEGIN
		UPDATE Customers
		SET
		dni = @dni,
		full_name = @full_name,
		email = @email,
		phone = @phone,
		state = @state,
		modify_date = GETDATE()
		WHERE customer_id = @customer_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe un cliente con el mismo DNI.'
	END
END
GO

CREATE PROC SP_DELETE_CUSTOMER
	@customer_id INT,
	@message VARCHAR(360) OUTPUT,
	@result BIT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @result = 0
	IF EXISTS (SELECT * FROM Customers WHERE customer_id = @customer_id)
	BEGIN
		UPDATE Customers
		SET
		state = 0
		WHERE customer_id = @customer_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra el cliente solicitado.'
	END
END
GO

CREATE PROC SP_RESTORE_CUSTOMER
	@customer_id INT,
	@message VARCHAR(360) OUTPUT,
	@result BIT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @result = 0
	IF EXISTS (SELECT * FROM Customers WHERE customer_id = @customer_id)
	BEGIN
		UPDATE Customers
		SET
		state = 1
		WHERE customer_id = @customer_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra el cliente solicitado.'
	END
END
