CREATE PROC SP_CREATE_PRODUCT
	@bar_code VARCHAR(60),
	@description VARCHAR(60),
	@product_category_id INT,
	@cost_price DECIMAL(9, 2),
	@sale_price DECIMAL(9, 2),
	@current_stock INT,
	@minimum_stock INT,
	@message VARCHAR(360) OUTPUT,
	@created_product_id INT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @created_product_id = 0
	IF NOT EXISTS(SELECT * FROM Products WHERE bar_code = @bar_code)
	BEGIN
		INSERT INTO Products(bar_code, description, product_category_id, cost_price, sale_price, 
		current_stock, minimum_stock)
		VALUES(@bar_code, @description, @product_category_id, @cost_price, @sale_price,
		@current_stock, @minimum_stock)
		SET @created_product_id = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe un producto con el mismo código de barras.'
	END
END
GO

CREATE PROC SP_UPDATE_PRODUCT
	@product_id INT,
	@bar_code VARCHAR(60),
	@description VARCHAR(60),
	@product_category_id INT,
	@cost_price DECIMAL(9, 2),
	@sale_price DECIMAL(9, 2),
	@current_stock INT,
	@minimum_stock INT,
	@state BIT,
	@message VARCHAR(360) OUTPUT,
	@result INT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @result = 0
	IF NOT EXISTS(SELECT description FROM Products WHERE bar_code = @bar_code and product_id != @product_id)
	BEGIN
		UPDATE Products
		SET
		bar_code = @bar_code,
		description = @description,
		product_category_id = @product_category_id,
		cost_price = @cost_price,
		sale_price = @sale_price,
		current_stock = @current_stock,
		minimum_stock = @minimum_stock,
		state = @state,
		modify_date = GETDATE()
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'Ya existe un producto con el mismo código de barras.'
	END
END
GO

CREATE PROC SP_DELETE_PRODUCT
	@product_id INT,
	@message VARCHAR(360) OUTPUT,
	@result INT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @result = 0
	IF EXISTS (SELECT description FROM Products WHERE product_id = @product_id)
	BEGIN
		UPDATE Products
		SET
		state = 0
		WHERE product_id = @product_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra el producto solicitado.'
	END
END
GO

CREATE PROC SP_RESTORE_PRODUCT
	@product_id INT,
	@message VARCHAR(360) OUTPUT,
	@result INT OUTPUT
AS
BEGIN
	SET @message = ''
	SET @result = 0
	IF EXISTS (SELECT description FROM Products WHERE product_id = @product_id)
	BEGIN
		UPDATE Products
		SET
		state = 1
		WHERE product_id = @product_id
		SET @result = 1
	END
	ELSE
	BEGIN
		SET @message = 'No se encuentra el producto solicitado.'
	END
END
GO