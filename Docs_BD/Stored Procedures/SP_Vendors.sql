CREATE PROC SP_CREATE_VENDOR
	@cuit VARCHAR(40),
	@company_name VARCHAR(100),
	@email VARCHAR(155),
	@phone VARCHAR(60),
	@message VARCHAR(360) OUTPUT,
	@created_vendor_id INT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @created_vendor_id = 0
	IF NOT EXISTS (SELECT * FROM Vendors WHERE company_name = @company_name)
	BEGIN
		INSERT INTO Vendors(cuit, company_name, email, phone)
		VALUES(@cuit, @company_name, @email, @phone)
		SET @created_vendor_id = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe un proveedor con el mismo nombre.'
	END
END
GO

CREATE PROC SP_UPDATE_VENDOR
	@vendor_id INT,
	@cuit VARCHAR(40),
	@company_name VARCHAR(100),
	@email VARCHAR(155),
	@phone VARCHAR(60),
	@state BIT,
	@message VARCHAR(360) OUTPUT,
	@result BIT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @result = 0
	IF NOT EXISTS (SELECT * FROM Vendors WHERE company_name = @company_name AND vendor_id != @vendor_id)
	BEGIN
		UPDATE Vendors
		SET
		cuit = @cuit,
		company_name = @company_name,
		email = @email,
		phone = @phone,
		state = @state,
		modify_date = GETDATE()
		WHERE vendor_id = @vendor_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe un proveedor con el mismo nombre.'
	END
END
GO

CREATE PROC SP_DELETE_VENDOR
	@vendor_id INT,
	@message VARCHAR(360) OUTPUT,
	@result BIT OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Vendors WHERE vendor_id = @vendor_id)
	BEGIN
		UPDATE Vendors
		SET state = 0
		WHERE vendor_id = @vendor_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra el proveedor solicitado.'
	END
END
GO

CREATE PROC SP_RESTORE_VENDOR
	@vendor_id INT,
	@message VARCHAR(360) OUTPUT,
	@result BIT OUTPUT
AS
BEGIN
	IF EXISTS (SELECT * FROM Vendors WHERE vendor_id = @vendor_id)
	BEGIN
		UPDATE Vendors
		SET state = 1
		WHERE vendor_id = @vendor_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra el proveedor solicitado.'
	END
END